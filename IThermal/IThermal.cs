using ExcelDna.Integration;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace IThermal
{
    class IThermal : IExcelAddIn
    {
        public static DataTable freeze_protecion = new DataTable();
        public static DataTable heat_conversation = new DataTable();
        public static DataTable heat_tracing = new DataTable();
        public static DataTable personnel_protection = new DataTable();

        public void AutoClose()
        {
            //throw new System.NotImplementedException();
        }

        public void AutoOpen()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM freeze_protecion", connection);
                freeze_protecion.Load(cmd.ExecuteReader());
                cmd.CommandText = "SELECT * FROM heat_conversation";
                heat_conversation.Load(cmd.ExecuteReader());
                cmd.CommandText = "SELECT * FROM heat_tracing";
                heat_tracing.Load(cmd.ExecuteReader());
                cmd.CommandText = "SELECT * FROM personnel_protection";
                personnel_protection.Load(cmd.ExecuteReader());
            }
            catch
            {

            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
