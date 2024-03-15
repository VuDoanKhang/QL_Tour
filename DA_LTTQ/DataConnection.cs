using System.Data.SqlClient;

namespace QLTour
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = @"Data Source=DESKTOP-DISN8LS\KHANGSQLSERVER;Initial Catalog=QLTour;Integrated Security=True";
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
