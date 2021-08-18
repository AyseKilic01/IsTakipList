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
                DataTable dt = null;
                SqlCommand command = new SqlCommand(commandtext);
                connection.Open();
                command.Connection = connection;
                var dataReader = command.ExecuteReader();
                dt.Load(dataReader);
                connection.Close();
                return dt;
            }
            catch(Exception e)
            {
                XtraMessageBox.Show("Veri yok !!!", "Bilgi");
                return null;
            }
            
        }
    }
}
