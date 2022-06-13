using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase.Utilities
{
    public class SqlStringBuilder
    {
        /// <summary>
        /// SQL文を取得する
        /// </summary>
        public string SqlString
        {
            get {

                if (!string.IsNullOrWhiteSpace(WhereClause))
                {
                    if (!whereFlagMent)
                    {
                        WhereClause = "Where " + WhereClause;
                        whereFlagMent = true;
                    }
                }

                return SelectClause + " " + WhereClause;
            }
        }

        /// <summary>
        /// Select句
        /// </summary>
        private string SelectClause;

        /// <summary>
        /// Where句
        /// </summary>
        public string WhereClause;

        /// <summary>
        /// Whereフラグ
        /// </summary>
        public bool whereFlagMent;

        #region メソッド

        public SqlStringBuilder Select(string tableName, List<string> selectList = null)
        {
            string sqlString = "SELECT ";

            //取得対象リストがない場合→すべて取得
            //取得対象リストがある場合→指定の要素のみを取得
            if (selectList == null)
            {
                sqlString += " * ";
            }
            else
            {

                int count = 1;

                foreach (string selectElement in selectList)
                {
                    sqlString += selectElement;

                    //最終要素までループがなされたら","をつけないようにする
                    if (count != selectList.Count)
                    {
                        sqlString += ", ";
                    }
                    else
                    {
                        sqlString += " ";
                    }

                    count++;
                }
            }

            //検索するテーブル名
            sqlString += "From " + tableName;

            SelectClause = sqlString;

            return this;
        }

        public SqlStringBuilder Equal(string columnName, object condtion)
        {
            if (condtion == null) return this;

            string sqlCondtion = columnName + " = " + condtion + " AND ";

            WhereClause += sqlCondtion;

            return this;
        }

        public SqlStringBuilder Between(string columnName, object lowerLimit, object upperLimit)
        {
            string sqlCondition = null;

            if (string.IsNullOrWhiteSpace((string)lowerLimit) && string.IsNullOrWhiteSpace((string)upperLimit))
            {
                sqlCondition = null;
            }
            else if (!string.IsNullOrWhiteSpace((string)lowerLimit) && string.IsNullOrWhiteSpace((string)upperLimit))
            {
                sqlCondition = columnName + " >= " + lowerLimit;
            }
            else if (string.IsNullOrWhiteSpace((string)lowerLimit) && !string.IsNullOrWhiteSpace((string)upperLimit))
            {
                sqlCondition = columnName + " <= " + upperLimit;
            }
            else
            {
                sqlCondition = columnName + " between " + lowerLimit + " and " + upperLimit;
            }

            if (!string.IsNullOrWhiteSpace(sqlCondition))
            {
                sqlCondition += " AND ";
            }

            WhereClause += sqlCondition;

            return this;
        }

        public SqlStringBuilder ForwardMatch(string columnName, object condtion)
        {

            if (string.IsNullOrWhiteSpace((string)condtion)) return this;

            string sqlCondition = columnName + " LIKE " + "'" + condtion + "%'" + " AND ";

            WhereClause += sqlCondition;

            return this;
        }

        public SqlStringBuilder BackwardMatch(string columnName, object condtion)
        {

            if (string.IsNullOrWhiteSpace((string)condtion)) return this;

            string sqlCondition = columnName + " LIKE " + "'%" + condtion + "'" + " AND ";

            WhereClause += sqlCondition;

            return this;
        }

        public SqlStringBuilder PartialMatch(string columnName, object condtion)
        {

            if (string.IsNullOrWhiteSpace((string)condtion)) return this;

            string sqlCondition = columnName + " LIKE " + "'%" + condtion + "%'" + " AND ";

            WhereClause += sqlCondition;

            return this;
        }

        #endregion

        public static class SQL
        {
            /// <summary>
            /// 選択
            /// </summary>
            /// <param name="tableName">テーブル名</param>
            /// <param name="selectList">取り出す要素のリスト（null → すべて取得）</param>
            /// <returns></returns>
            public static SqlStringBuilder Select(string tableName, List<string> selectList = null)
            {
                return new SqlStringBuilder().Select(tableName, selectList);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="columnName"></param>
            /// <param name="lowerLimit"></param>
            /// <param name="upperLimit"></param>
            /// <returns></returns>
            public static SqlStringBuilder Between(string columnName, object lowerLimit, object upperLimit)
            {
                return new SqlStringBuilder().Between(columnName, lowerLimit, upperLimit);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="columnName"></param>
            /// <param name="condition"></param>
            /// <returns></returns>
            public static SqlStringBuilder Euqal(string columnName, object condition)
            {
                return new SqlStringBuilder().Equal(columnName, condition);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="columnName"></param>
            /// <param name="condition"></param>
            /// <returns></returns>
            public static SqlStringBuilder ForwardMatch(string columnName, object condition)
            {
                return new SqlStringBuilder().ForwardMatch(columnName, condition);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="columnName"></param>
            /// <param name="condition"></param>
            /// <returns></returns>
            public static SqlStringBuilder BackwardMatch(string columnName, object condition)
            {
                return new SqlStringBuilder().BackwardMatch(columnName, condition);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="columnName"></param>
            /// <param name="condition"></param>
            /// <returns></returns>
            public static SqlStringBuilder PartialMatch(string columnName, object condition)
            {
                return new SqlStringBuilder().PartialMatch(columnName, condition);
            }
        }

    }
}
