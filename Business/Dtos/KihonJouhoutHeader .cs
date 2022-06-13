using KnowledgeBase.Const;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase.Dtos
{
    public class KihonJouhouView
    {
        /// <summary>
        /// 検索条件クラス
        /// </summary>
        public SearchCondition condition { get; set; }

        /// <summary>
        /// 一覧データ
        /// </summary>
        public DataRow Row { get; set; }

        /// <summary>
        /// データ表示用リスト
        /// </summary>
        public DataArea Data { get; set; }

        //コンストラクタ
        public KihonJouhouView(){

            if (condition == null) {

                condition = new SearchCondition();
            }

            if (Row == null) {

                Row = new DataRow();
            }

            if (Data == null) {

                Data = new DataArea();
            }
        }

        /// <summary>
        /// 検索条件
        /// </summary>
        public class SearchCondition{

            /// <summary>
            /// 項目名
            /// </summary>
            public string KoumokuName { get; set; }

            /// <summary>
            /// 重要度
            /// </summary>
            public RatingEnum Rating { get; set; }


            /// <summary>
            /// 重要度の条件を有効にするかどうか
            /// </summary>
            public bool IsRatingEnabled { get; set; }

            /// <summary>
            /// 分野別（ストラテジ系・マネジメント系・テクノロジ系）
            /// </summary>
            public CategoryEnum Category { get; set; }

            /// <summary>
            /// 分野別の条件を有効にするかどうか
            /// </summary>
            public bool IsCategoryEnabled { get; set; }
        }

        /// <summary>
        /// 検索データ
        /// </summary>
        public class DataArea
        {
            /// <summary>
            /// 一覧
            /// </summary>
            public BindingList<DataRow> RowList { get; set; } = new BindingList<DataRow>();
        }

        /// <summary>
        /// 一覧データ
        /// </summary>
        public class DataRow
        {
            /// <summary>
            /// ID
            /// </summary>
            public long ID { get; set; }

            /// <summary>
            /// 項目名
            /// </summary>
            public string Name { get; set; }
        }
    }
}
