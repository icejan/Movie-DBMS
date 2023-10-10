using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;


namespace Movie_Store
{
    public partial class Form1 : Form
    {
        private DBConnection connection;
        private bool _dataChanged = false;
        private bool _querySelected = false;
        private bool dataHasChanged
        {
            get { return _dataChanged; }
            set
            {
                _dataChanged = value;
                if (_dataChanged == true)
                {
                    btnCommit.Enabled = true;
                    btnRevert.Enabled = true;
                }
                else
                {
                    btnCommit.Enabled = false;
                    btnRevert.Enabled = false;
                }
            }

        }
        private bool querySelected
        {
            get { return _querySelected; }
            set
            {
                _querySelected = value;
                if (_querySelected == true)
                {
                    cmbTableSelect.SelectedItem = null;
                    dgvMain.ReadOnly = true;
                    dgvMain.AllowUserToAddRows = false;
                    dgvMain.AllowUserToDeleteRows = false;
                }
                else
                {
                    dgvMain.ReadOnly = false;
                    dgvMain.AllowUserToAddRows = true;
                    dgvMain.AllowUserToDeleteRows = true;
                }
            }

        }
        public Form1()
        {
            InitializeComponent();
            connection = new DBConnection();
        }
        
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (connection.testConnection())
                MessageBox.Show("Connection is valid!");
        }

        private void cmbTableSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshTableView();
            querySelected = false;
            dataHasChanged = false;
        }

        private void refreshTableView()
        {
            object tableName = cmbTableSelect.SelectedItem;
            if (tableName == null) return;
            connection.loadTable(tableName.ToString());
            dgvMain.DataSource = null;
            dgvMain.DataSource = connection.dbTable;
        }

        private void simpleQuerySelected(object? sender, EventArgs e)
        {
            string script = ((ToolStripMenuItem)sender).Text;
            //MessageBox.Show("CLICK: " + script);
            connection.executeSimpleQuery(script);
            dgvMain.DataSource = null;
            dgvMain.DataSource = connection.dbTable;
            querySelected = true;
        }

        private void advancedQuerySelected(object? sender, EventArgs e)
        {
            string script = ((ToolStripMenuItem)sender).Text;
            //MessageBox.Show("CLICK: " + script);
            connection.executeAdvancedQuery(script);
            dgvMain.DataSource = null;
            dgvMain.DataSource = connection.dbTable;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            cmbTablesUpdateItems();
            if (connection.tableNames.Count == 0)
                btnDropTables.Enabled = false;
            else
                btnCreateTables.Enabled = false;
            populateQueries();
        }

        private void populateQueries()
        {
            connection.loadQueries();
            foreach (string query in connection.getQueries(true))
            {
                ToolStripItem item = new ToolStripMenuItem();
                item.Text = query;
                item.Click += advancedQuerySelected;
                menuAdvancedQueries.DropDownItems.Add(item);
            }
            foreach (string query in connection.getQueries(false))
            {
                ToolStripItem item = new ToolStripMenuItem();
                item.Text = query;
                item.Click += simpleQuerySelected;
                menuSimpleQueries.DropDownItems.Add(item);
            }
        }
            

        private void btnDropTables_Click(object sender, EventArgs e)
        {
            connection.executeScript(@"Scripts\DropTables.sql");
            cmbTableSelect.Items.Clear();
            dgvMain.DataSource = null;
            btnDropTables.Enabled = false;
            btnCreateTables.Enabled = true;
            btnPopulateTables.Enabled = false;
            //btnCommit.Enabled = false;
            //btnRevert.Enabled = false;
        }

        private void btnPopulateTables_Click(object sender, EventArgs e)
        {
            connection.executeScript(@"Scripts\InsertData.sql");
            refreshTableView();
            btnPopulateTables.Enabled = false;
        }

        private void btnCreateTables_Click(object sender, EventArgs e)
        {
            connection.executeScript(@"Scripts\CreateTables.sql");
            cmbTablesUpdateItems();
            btnDropTables.Enabled = true;
            btnCreateTables.Enabled = false;
            btnPopulateTables.Enabled = true;
        }

        private void cmbTablesUpdateItems()
        {

            foreach (string table in connection.tableNames)
            {
                cmbTableSelect.Items.Add(table);
            }
        }

        private void dgvMain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataHasChanged = true;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            connection.commitChanges();
            dataHasChanged = false;
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            dataHasChanged = false;
            refreshTableView();
        }

        private void customQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCustomQuery f = new formCustomQuery();
            f.ShowDialog();
            if ((f.DialogResult == DialogResult.OK) && !(string.IsNullOrWhiteSpace(f.query)))
            {
                connection.executeQuery(f.query);
                dgvMain.DataSource = null;
                dgvMain.DataSource = connection.dbTable;
                querySelected = true;
            }
        }

        private void dgvMain_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            dataHasChanged = true;
        }
    }
}