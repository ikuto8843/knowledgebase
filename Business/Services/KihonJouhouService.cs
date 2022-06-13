using KnowledgeBase.Settings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using KnowledgeBase.Dtos;
using KnowledgeBase.Entities;
using KnowledgeBase.Const;
using KnowledgeBase.Utilities;
using Business.Services;
using DatabaseExtension;
using System.Transactions;

namespace KnowledgeBase.Business
{
    public class KihonJouhouService : BaseService
    {
        #region 一覧画面

        /// <summary>
        /// 一覧画面DTOを取得します
        /// </summary>
        /// <param name="condition">検索条件DTO</param>
        /// <returns>一覧画面DTOリスト</returns>
        public List<KihonJouhouView.DataRow> GetViewData(KihonJouhouView.SearchCondition condition) {

            var dataList = new List<KihonJouhouView.DataRow>();

            List<KihonJouhou> headerEntityList = DataAccessManager.GetResultList<KihonJouhou>(
                new WhereClause()
                    .Forward("Name", condition.KoumokuName)
                    .Equal("Rating", !condition.IsRatingEnabled ? (int)condition.Rating : (int?)null)
                    .Equal("Category", !condition.IsCategoryEnabled ? (int)condition.Category : (int?)null)
            );

            foreach(var entity in headerEntityList)
            {
                dataList.Add(ToKihonjouhouDatarowDto(entity));
            }

            return dataList;
        }

        /// <summary>
        /// エンティティからDTOへ変換を行う
        /// </summary>
        /// <param name="entityList"></param>
        /// <returns></returns>
        private KihonJouhouView.DataRow ToKihonjouhouDatarowDto(KihonJouhou entity) {

            KihonJouhouView.DataRow dataRow = new KihonJouhouView.DataRow()
            {
                ID = entity.HeaderID,
                Name = entity.Name,
            };

            return dataRow;
        }

        #endregion

        #region 編集画面

        /// <summary>
        /// 編集画面のデータを取得する（詳細のみ）
        /// </summary>
        /// <param name="headerID">ヘッダーID</param>
        /// <returns></returns>
        public KihonJouhouDetail GetEditData(long ID) {

            var detailEntity = this.DataAccessManager.GetSingleResult<KihonJouhou>(
                new WhereClause()
                    .Equal("HeaderID", ID)
                );

            if (detailEntity == null) return null;

            //Entity → DTOへ変換
            KihonJouhouDetail detail = new KihonJouhouDetail()
            {
                Key = new KihonJouhouDetail.KeyArea()
                {
                    ID = detailEntity.ID
                },

                Data = new KihonJouhouDetail.DataArea()
                {
                    Name = detailEntity.Name,
                    Rating = (RatingEnum)detailEntity.Rating,
                    Detail = detailEntity.Detail,
                    Category = (CategoryEnum)detailEntity.Category,
                    HeaderID = detailEntity.HeaderID
                }
            };

            return detail;
        }

        #endregion

        #region 登録・更新・削除

        /// <summary>
        /// 登録を行う
        /// </summary>
        /// <param name="dto">項目No</param>
        public void Save(KihonJouhouDetail dto)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required))
            {
                //新規登録の場合
                if(dto.Key.ID == 0)
                {
                    KihonJouhouH headerEntity = new KihonJouhouH()
                    {
                        ID = 0,
                        Name = dto.Data.Name
                    };

                    this.DataAccessManager.Insert(headerEntity);

                    KihonJouhou detailEntity = new KihonJouhou()
                    {
                        ID = 0,
                        HeaderID = headerEntity.ID,
                        Name = dto.Data.Name,
                        Detail = dto.Data.Detail,
                        Category = (int)dto.Data.Category,
                        Rating = (int)dto.Data.Rating
                    };

                    this.DataAccessManager.Insert(detailEntity);
                }
                else
                {
                    KihonJouhouH headerEntity = new KihonJouhouH()
                    {
                        ID = dto.Data.HeaderID,
                        Name = dto.Data.Name
                    };

                    this.DataAccessManager.Update(headerEntity, new WhereClause("ID = " + dto.Data.HeaderID.ToString(), dto.Data.HeaderID));

                    KihonJouhou detailEntity = new KihonJouhou()
                    {
                        ID = dto.Key.ID,
                        HeaderID = headerEntity.ID,
                        Name = dto.Data.Name,
                        Detail = dto.Data.Detail,
                        Category = (int)dto.Data.Category,
                        Rating = (int)dto.Data.Rating
                    };

                    this.DataAccessManager.Update(detailEntity, new WhereClause("ID = " + dto.Key.ID, dto.Key.ID));
                }

                scope.Complete();
            }
        }

        /// <summary>
        /// データの削除
        /// </summary>
        /// <param name="id">該当ID</param>
        public bool Delete(long id)
        {
            var data = this.DataAccessManager.GetSingleResult<KihonJouhou>(new WhereClause("ID = " + id.ToString(), id));

            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required))
            {
                this.DataAccessManager.Delete<KihonJouhouH>(new WhereClause("ID = " + data.HeaderID.ToString(), data.HeaderID));
                this.DataAccessManager.Delete<KihonJouhou>(new WhereClause("ID = " + id.ToString(), id));
                scope.Complete();
            }

            return true;
        }

        #region SQL文作成

        /// <summary>
        /// ヘッダー用のSQLを作成
        /// </summary>
        /// <param name="modeName"></param>
        /// <returns></returns>
        private static string MakeSqlStringForHeader(ModeSelection modeName)
        {

            StringBuilder sb = new StringBuilder();

            switch (modeName)
            {

                case ModeSelection.register:
                    sb.Append("INSERT INTO");
                    sb.Append(" ");
                    sb.Append("dbo.KihonJouhouH");
                    sb.Append("(No, Name, Rating, Category)");
                    sb.Append(" ");
                    sb.Append("VALUES");
                    sb.Append("(@No, @Name ,@Rating, @Category)");
                    break;

                //更新
                case ModeSelection.update:
                    sb.Append("UPDATE");
                    sb.Append(" ");
                    sb.Append("dbo.KihonJouhouH");
                    sb.Append(" ");
                    sb.Append("SET");
                    sb.Append(" ");
                    sb.Append("Name = @Name");
                    sb.Append(",");
                    sb.Append("Rating = @Rating");
                    sb.Append(",");
                    sb.Append("Category = @Category");
                    sb.Append(" ");
                    sb.Append("WHERE");
                    sb.Append(" ");
                    sb.Append("No = @No");
                    break;

                //削除
                case ModeSelection.delete:
                    sb.Append("DELETE FROM");
                    sb.Append(" ");
                    sb.Append("dbo.KihonJouhouH");
                    sb.Append(" ");
                    sb.Append("WHERE");
                    sb.Append(" ");
                    sb.Append("No = @No");
                    break;
            }

            return sb.ToString();
        }

        /// <summary>
        ///明細用のSQLを作成する
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static string MakeSqlStringForDetail(ModeSelection name)
        {
            StringBuilder sb = new StringBuilder();

            switch (name)
            {
                //登録
                case ModeSelection.register:
                    sb.Append("INSERT INTO");
                    sb.Append(" ");
                    sb.Append("dbo.KihonJouhouM");
                    sb.Append("(No, Rating, Name, Detail, Category)");
                    sb.Append(" ");
                    sb.Append("VALUES");
                    sb.Append("(@No, @Rating, @Name, @Detail, @Category)");
                    break;

                //更新
                case ModeSelection.update:
                    sb.Append("UPDATE");
                    sb.Append(" ");
                    sb.Append("dbo.KihonJouhouM");
                    sb.Append(" ");
                    sb.Append("SET");
                    sb.Append(" ");
                    sb.Append("Rating = @Rating");
                    sb.Append(",");
                    sb.Append("Category = @Category");
                    sb.Append(",");
                    sb.Append("Name = @Name");
                    sb.Append(",");
                    sb.Append("Detail = @Detail");
                    sb.Append(" ");
                    sb.Append("WHERE");
                    sb.Append(" ");
                    sb.Append("No = @No");
                    break;

                //削除
                case ModeSelection.delete:
                    sb.Append("DELETE FROM");
                    sb.Append(" ");
                    sb.Append("dbo.KihonJouhouM");
                    sb.Append(" ");
                    sb.Append("WHERE");
                    sb.Append(" ");
                    sb.Append("No = @No");
                    break;
            }

            return sb.ToString();
        }

        #endregion

        #endregion
    }
}
