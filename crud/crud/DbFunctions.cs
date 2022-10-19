using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using System.Windows.Forms;
using System.Drawing;

namespace crud
{
    internal class DbFunctions
    {
        public DbFunctions() { 
            
        }

        private static string getConnectionString() {

            string host = "Server=localhost;";
            string port = "Port=5432;";
            string db = "Database='bodyon'";
            string user = "User Id='postgres'";
            string pass = "Password=senha@123";

            string conString = string.Format("{0}{1}{2}{3}{4}", host, port, db, user, pass);
            return conString;
        }

        public static NpgsqlConnection con = new NpgsqlConnection(getConnectionString());
        public static NpgsqlCommand cmd = default(NpgsqlCommand);
        public static string sql = string.Empty;

        public static DataTable performCRUD(NpgsqlCommand com) {
            NpgsqlDataAdapter dataAdapter = default(NpgsqlDataAdapter);
            DataTable dataTable = new DataTable();

            try
            {

                dataAdapter = new NpgsqlDataAdapter();
                dataAdapter.SelectCommand = com;
                dataAdapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex) {

                MessageBox.Show(
                    "Erro: " + ex.Message,
                    "CRUD Action fail",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );

                dataTable = null;

            }
            
            return dataTable;

        }

    }
}
