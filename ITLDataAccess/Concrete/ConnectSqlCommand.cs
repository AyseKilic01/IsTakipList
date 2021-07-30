using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLDataAccess.Concrete
{
    public class ConnectSqlCommand
    {
        public ConnectSqlCommand()
        {
            cnn = new SqlConnection(ConnectString.getConnectionString());
            cmm = cnn.CreateCommand();
        }
        SqlConnection cnn = null;
        SqlCommand cmm = null;

        public string CommandText
        {
            get { return cmm.CommandText; }
            set
            {
                cmm.CommandText = value;
            }
        }
        public SqlTransaction Transaction
        {
            get { return cmm.Transaction; }
            set
            {
                cmm.Transaction = value;
            }
        }
        public SqlCommand CommandObject
        {
            get { return cmm; }
        }
        public System.Data.SqlClient.SqlParameterCollection Parameters
        {
            get { return cmm.Parameters; }
        }

        public int ExecuteNonQuery()
        {
            return cmm.ExecuteNonQuery();
        }
    }
}
