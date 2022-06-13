using KnowledgeBase.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IKihonjouhouService
    {
        /// <summary>
        /// 一覧画面DTOを取得します
        /// </summary>
        /// <param name="condition">検索条件DTO</param>
        /// <returns>一覧画面DTOリスト</returns>
        List<KihonJouhouView.DataRow> GetViewData(KihonJouhouView.SearchCondition condition);

        /// <summary>
        /// 編集画面のデータを取得する（詳細のみ）
        /// </summary>
        /// <param name="headerID">ヘッダーID</param>
        /// <returns></returns>
        KihonJouhouDetail GetEditData(long headerID);

        /// <summary>
        /// 登録を行う
        /// </summary>
        /// <param name="koumokuNo">項目No</param>
        /// <param name="koumokuName">項目名</param>
        /// <param name="koumokuDeitail">項目名の説明</param>
        bool Register(string koumokuNo, string koumokuName, string koumokuDetail, int rating, int category);

        /// <summary>
        /// データ更新
        /// </summary>
        /// <param name="koumokuNo">項目No</param>
        /// <param name="koumokuName">項目名</param>
        /// <param name="koumokuDetail">項目詳細</param>
        bool Update(string koumokuNo, string koumokuName, string koumokuDetail, int rating, int category);

        /// <summary>
        /// データの削除
        /// </summary>
        /// <param name="id">該当ID</param>
        bool Delete(string id);

        /// <summary>
        /// 最新の項目Noを取得する
        /// </summary>
        /// <returns></returns>
        string GetLatestKoumokuNo();
    }
}
