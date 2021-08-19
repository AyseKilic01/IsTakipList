using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLDataAccess.Concrete.EntityFramework
{
   public class DAL
    {
      static SqlConnection connection = new SqlConnection(ITLEntity.Connections.cons.getConnectionString());
        public static DataTable getData(string commandtext)
        {
           try {
                DataTable dt = new DataTable();
                
                SqlCommand command = new SqlCommand(commandtext);
                command.Connection = connection;
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlDataReader dr = command.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);
                return dt;
            }
            catch(Exception e)
            {
                XtraMessageBox.Show("Veri yok !!!", "Bilgi");
                return null;
            }
            finally
            {
                connection.Close();
            }
            
        }
    }
}
