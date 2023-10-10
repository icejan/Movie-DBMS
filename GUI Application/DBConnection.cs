using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Movie_Store
{
    internal class DBConnection
    {
        internal struct programmedQuery
        {
            internal string name;
            internal string script;
        }

        private string connectionString = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = oracle.scs.ryerson.ca)(PORT = 1521)))(CONNECT_DATA=(SID=orcl))); User Id = dmcrowe; Password = 09167978;";
        private OracleConnection connection;
        private OracleDataAdapter adapter = new OracleDataAdapter();
        private OracleCommandBuilder commandBuilder;

        internal System.Data.DataTable dbTable;

        internal List<string> tableNames;
        internal List<programmedQuery> simpleQueries;
        internal List<programmedQuery> advancedQueries;

        internal DBConnection()
        {
            simpleQueries = new List<programmedQuery>();
            advancedQueries = new List<programmedQuery>();
            connection = new OracleConnection(connectionString);
            dbTable = new System.Data.DataTable();
            commandBuilder = new OracleCommandBuilder(adapter);
            tableNames = new List<string>();
            updateTableNames();
        }
        private programmedQuery? getQuery(List<programmedQuery> list, string name)
        {
            foreach (programmedQuery query in list)
            {
                if (query.name == name)
                    return query;
            }
            return null;
        }
        private int getQueryIndex(List<programmedQuery> list, string name)
        {
            foreach (programmedQuery query in list)
            {
                if (query.name == name)
                    return list.IndexOf(query);
            }
            return -1;
        }
        internal void executeSimpleQuery(string name)
        {
            connection.Open();
            OracleCommand command = connection.CreateCommand();
            command.CommandText =  simpleQueries[getQueryIndex(simpleQueries, name)].script;
            adapter.SelectCommand = command;
            dbTable = new System.Data.DataTable();
            adapter.Fill(dbTable);
            connection.Close();
        }

        internal void executeAdvancedQuery(string name)
        {
            connection.Open();
            OracleCommand command = connection.CreateCommand();
            command.CommandText = advancedQueries[getQueryIndex(advancedQueries, name)].script;
            adapter.SelectCommand = command;
            dbTable = new System.Data.DataTable();
            adapter.Fill(dbTable);
            connection.Close();
        }
        internal List<string> getQueries(bool isAdvanced)
        {
            List<string> queries = new List<string>();
            foreach (programmedQuery query in (isAdvanced ? advancedQueries : simpleQueries))
            {
                queries.Add(query.name);
            }
            return queries;
        }
        internal void commitChanges()
        {
            adapter.Update(dbTable);
        }
        internal void loadQueries()
        {
            loadQueries(simpleQueries, @"Scripts\SimpleQueries.sql");
            loadQueries(advancedQueries, @"Scripts\AdvancedQueries.sql");
        }
        private void loadQueries(List<programmedQuery> list, string path)
        {
            using (var fs = File.OpenRead(path))
            {
                using (var sr = new StreamReader(fs))
                {
                    string line;
                    programmedQuery query = new programmedQuery();
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.StartsWith("---"))
                        {
                            if (!string.IsNullOrEmpty(query.script))
                            {
                                query.script = query.script.Replace(";", "");
                                list.Add(query);
                            }
                            query = new programmedQuery();
                            query.name = line.Substring(3);
                        }
                        else if (!(string.IsNullOrWhiteSpace(line)) && !(line.StartsWith("--")))
                        {
                            query.script += line + " ";         
                        }
                    }
                    if (!string.IsNullOrEmpty(query.script))
                    {
                        query.script = query.script.Replace(";", "");
                        list.Add(query);
                    }
                }
            }
            return;
        }
        internal void executeScript(string path)
        {
            connection.Open();
            OracleCommand command = connection.CreateCommand();
            string[] script = Regex.Replace(File.ReadAllText(path), "(--.*)", "").Split(';');
            foreach (string s in script)
            {
                if (!string.IsNullOrWhiteSpace(s))
                {
                    command.CommandText = s.Replace("\n", "").Replace("\r","");
                    command.ExecuteNonQuery();
                }
            }
            
            connection.Close();
            updateTableNames();
        }

        internal void executeQuery(string query)
        {
            connection.Open();
            OracleCommand command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            dbTable = new System.Data.DataTable();
            adapter.Fill(dbTable);
            connection.Close();
        }

        internal void loadTable(string tableName)
        {
            OracleCommand command = connection.CreateCommand();
            command.CommandText = string.Format("SELECT * FROM {0}", tableName);
            adapter.SelectCommand = command;
            dbTable = new System.Data.DataTable();
            adapter.Fill(dbTable);
        }


        internal bool isOpen()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                return true;
            return false;
        }
        internal void openConnection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw new Exception(ex.Message);
            }
            if (!isOpen())
            {
                Debug.WriteLine("Cannot connect!");
                throw new Exception("Error connecting");
            }
        }

        internal bool testConnection()
        {
            openConnection();

            OracleCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM V$VERSION";
            OracleDataReader reader = command.ExecuteReader();
            Debug.WriteLine("###DB Version###");
            while (reader.Read())
            {
                Debug.WriteLine(reader.GetString(0));
            }
            connection.Close();
            return true;
        }
        internal void updateTableNames()
        {
            tableNames.Clear();
            openConnection();
            OracleCommand command = connection.CreateCommand();
            command.CommandText = "SELECT table_name FROM ALL_TABLES WHERE owner='DMCROWE' ORDER BY TABLE_name ASC";
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tableNames.Add(reader.GetString(0));
            }
            connection.Close();
        }
    }
}
