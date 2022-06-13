using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace KnowledgeBase.Settings
{
    /// <summary>
    /// 各種設定
    /// </summary>
    public static class DataBaseAccessSet
    {
        /// <summary>
        /// データベースへの接続文字列を取得
        /// </summary>
        /// <returns></returns>
        public static SqlConnection sqlConnection()
        {
            string connectString = ConfigurationManager.ConnectionStrings["KnowledgeBase"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectString);

            return connection;
        }
    }
}
