using DatabaseExtension;
using KnowledgeBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DbAccessService
{
    /// <summary>
    /// WebService1 の概要の説明です
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // この Web サービスを、スクリプトから ASP.NET AJAX を使用して呼び出せるようにするには、次の行のコメントを解除します。
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public bool GetDataSet()
        {
            DataAccessManager dataAccessManager = new DataAccessManager();

            var test = dataAccessManager.GetResultList<KihonJouhouH>(new WhereClause());

            if (test.Count == 0)
            {
                return false;
            }

            return true;
        }
    }
}
