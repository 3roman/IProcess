using ExcelDna.Integration;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace IThermal
{
    class IThermal : IExcelAddIn
    {
        public static DataSet AP_STD = new DataSet();

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
                MySqlDataAdapter apt = new MySqlDataAdapter(string.Empty, connection);
                apt.SelectCommand.CommandText = "SELECT * FROM heat_conversation";
                apt.Fill(AP_STD, "heat_conversation");
                apt.SelectCommand.CommandText = "SELECT * FROM personnel_protection";
                apt.Fill(AP_STD, "personnel_protection");
                apt.SelectCommand.CommandText = "SELECT * FROM freeze_protection";
                apt.Fill(AP_STD, "freeze_protection");
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
