namespace Movie_Store
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateTables = new System.Windows.Forms.Button();
            this.btnPopulateTables = new System.Windows.Forms.Button();
            this.btnDropTables = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbTableSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnRevert = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSimpleQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdvancedQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.customQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTestConnection.Location = new System.Drawing.Point(3, 3);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(192, 27);
            this.btnTestConnection.TabIndex = 0;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.43689F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.56311F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 430);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnTestConnection, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCreateTables, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPopulateTables, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDropTables, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 394);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 33);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnCreateTables
            // 
            this.btnCreateTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateTables.Location = new System.Drawing.Point(201, 3);
            this.btnCreateTables.Name = "btnCreateTables";
            this.btnCreateTables.Size = new System.Drawing.Size(192, 27);
            this.btnCreateTables.TabIndex = 1;
            this.btnCreateTables.Text = "Create Tables";
            this.btnCreateTables.UseVisualStyleBackColor = true;
            this.btnCreateTables.Click += new System.EventHandler(this.btnCreateTables_Click);
            // 
            // btnPopulateTables
            // 
            this.btnPopulateTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPopulateTables.Enabled = false;
            this.btnPopulateTables.Location = new System.Drawing.Point(399, 3);
            this.btnPopulateTables.Name = "btnPopulateTables";
            this.btnPopulateTables.Size = new System.Drawing.Size(192, 27);
            this.btnPopulateTables.TabIndex = 2;
            this.btnPopulateTables.Text = "Populate Tables";
            this.btnPopulateTables.UseVisualStyleBackColor = true;
            this.btnPopulateTables.Click += new System.EventHandler(this.btnPopulateTables_Click);
            // 
            // btnDropTables
            // 
            this.btnDropTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDropTables.Location = new System.Drawing.Point(597, 3);
            this.btnDropTables.Name = "btnDropTables";
            this.btnDropTables.Size = new System.Drawing.Size(194, 27);
            this.btnDropTables.TabIndex = 3;
            this.btnDropTables.Text = "Drop Tables";
            this.btnDropTables.UseVisualStyleBackColor = true;
            this.btnDropTables.Click += new System.EventHandler(this.btnDropTables_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(3, 43);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 25;
            this.dgvMain.Size = new System.Drawing.Size(794, 345);
            this.dgvMain.TabIndex = 2;
            this.dgvMain.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellValueChanged);
            this.dgvMain.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvMain_UserDeletedRow);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 367F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.69789F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.30211F));
            this.tableLayoutPanel3.Controls.Add(this.cmbTableSelect, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 34);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // cmbTableSelect
            // 
            this.cmbTableSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTableSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableSelect.FormattingEnabled = true;
            this.cmbTableSelect.Location = new System.Drawing.Point(483, 3);
            this.cmbTableSelect.Name = "cmbTableSelect";
            this.cmbTableSelect.Size = new System.Drawing.Size(308, 23);
            this.cmbTableSelect.TabIndex = 0;
            this.cmbTableSelect.SelectedIndexChanged += new System.EventHandler(this.cmbTableSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Table:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnCommit, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnRevert, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(361, 28);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnCommit
            // 
            this.btnCommit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCommit.Enabled = false;
            this.btnCommit.Location = new System.Drawing.Point(3, 3);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(174, 22);
            this.btnCommit.TabIndex = 0;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnRevert
            // 
            this.btnRevert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRevert.Enabled = false;
            this.btnRevert.Location = new System.Drawing.Point(183, 3);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(175, 22);
            this.btnRevert.TabIndex = 1;
            this.btnRevert.Text = "Revert";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSimpleQueries,
            this.menuAdvancedQueries,
            this.customQueryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSimpleQueries
            // 
            this.menuSimpleQueries.Name = "menuSimpleQueries";
            this.menuSimpleQueries.Size = new System.Drawing.Size(98, 20);
            this.menuSimpleQueries.Text = "Simple Queries";
            // 
            // menuAdvancedQueries
            // 
            this.menuAdvancedQueries.Name = "menuAdvancedQueries";
            this.menuAdvancedQueries.Size = new System.Drawing.Size(115, 20);
            this.menuAdvancedQueries.Text = "Advanced Queries";
            // 
            // customQueryToolStripMenuItem
            // 
            this.customQueryToolStripMenuItem.Name = "customQueryToolStripMenuItem";
            this.customQueryToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.customQueryToolStripMenuItem.Text = "Custom Query";
            this.customQueryToolStripMenuItem.Click += new System.EventHandler(this.customQueryToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Movie Store DB";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTestConnection;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnCreateTables;
        private Button btnPopulateTables;
        private Button btnDropTables;
        private DataGridView dgvMain;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox cmbTableSelect;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnCommit;
        private Button btnRevert;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuSimpleQueries;
        private ToolStripMenuItem menuAdvancedQueries;
        private ToolStripMenuItem customQueryToolStripMenuItem;
    }
}