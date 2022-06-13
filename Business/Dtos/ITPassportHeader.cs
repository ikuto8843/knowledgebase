using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowledgeBase.Const;

namespace KnowledgeBase.Dtos
{
    public class ITPassportHeader
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
        public List<DataRow> RowList { get; set; }

        //コンストラクタ
        public ITPassportHeader(){

            if (condition == null) {

                condition = new SearchCondition();
            }

            if (Row == null) {

                Row = new DataRow();
            }

            if (RowList == null) {

                RowList = new List<DataRow>();
            }
        }

        /// <summary>
        /// 検索条件
        /// </summary>
        public class SearchCondition{

            /// <summary>
            /// 項目No（ここから）
            /// </summary>
            public string KoumokuNoFrom { get; set; }

            /// <summary>
            /// 項目No（ここまで）
            /// </summary>
            public string KoumokuNoTo { get; set; }

            /// <summary>
            /// 項目名
            /// </summary>
            public string KoumokuName { get; set; }

            /// <summary>
            /// 重要度
            /// </summary>
            public RatingEnum? Rating { get; set; }

            /// <summary>
            /// 分野別（ストラテジ系・マネジメント系・テクノロジ系）
            /// </summary>
            public CategoryEnum? Category { get; set; }
        }

        /// <summary>
        /// 一覧データ
        /// </summary>
        public class DataRow
        {
            /// <summary>
            /// 項目No
            /// </summary>
            public string No { get; set; }

            /// <summary>
            /// 項目名
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// 重要度
            /// </summary>
            public RatingEnum Rating { get; set; }

            /// <summary>
            /// 分野別（ストラテジ系・マネジメント系・テクノロジ系）
            /// </summary>
            public CategoryEnum Category { get; set; }
        }
    }
}
