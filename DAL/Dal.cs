using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yes.DAL
{
        public class Dal
        {
            System.Data.DataSet ds;
            OleDbConnection con;
            string dbpath;


            public Dal()
            {
                ds = new DataSet();
                dbpath = System.Windows.Forms.Application.StartupPath + @"\Microsoft Access waves.accdb";
                con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbpath);
            }


            public void AddTable(string tableName)
            {
                if (!(ds.Tables.Contains(tableName)))
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM " + tableName, con);
                    adapter.Fill(ds, tableName);
                }
            }


            public DataTable GetTable(string tableName)
            {
                this.AddTable(tableName);
                return ds.Tables[tableName];
            }


            public DataTable GetQuery(string SqlQuery)
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(SqlQuery, con);
                DataTable Query = new DataTable();
                adapter.Fill(Query);
                return Query;
            }


            public void Update(string tableName)
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from " + tableName, con);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.DeleteCommand = builder.GetDeleteCommand();
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.Update(ds, tableName);
            }
        }
    }

