using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace FC.Common
{
    public class SqlCommon : IDisposable
    {
        public DataSet ExecuteProcedure(string procedureName, List<SqlParameter> sqlParameters)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Microsoft.Practices.EnterpriseLibrary.Data.Database db = factory.Create("dProvider");

            DbCommand dbCommand = db.GetStoredProcCommand(procedureName);

            if ((sqlParameters != null) && (sqlParameters.Count > 0))
            {
                foreach (SqlParameter sqlParameter in sqlParameters)
                {
                    db.AddInParameter(dbCommand, sqlParameter.ParameterName, sqlParameter.DbType, sqlParameter.Value);
                }
            }

            DataSet customerDataSet = db.ExecuteDataSet(dbCommand);
            return customerDataSet;
        }

        private string getConnectionString()
        {
            // TODO : config로 빼야함.

            //string server = ".";
            //string database = "financial_consulting";
            //string uid = "sa";
            //string pwd = "1";

            string server = "thefcdb01.database.windows.net";
            string database = "thefc";
            string uid = "fo2plot";
            string pwd = "new1234?";

            return this.makeConnectionString(server, database, uid, pwd);
        }

        /// <summary>
        /// ConnectionString 생성
        /// </summary>
        /// <param name="server">server</param>
        /// <param name="database">database</param>
        /// <param name="uid">uid</param>
        /// <param name="pwd">pwd</param>
        /// <returns></returns>
        private string makeConnectionString(string server, string database, string uid, string pwd)
        {
            return string.Format("server={0};database={1};uid={2};pwd={3};", server, database, uid, pwd);
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
