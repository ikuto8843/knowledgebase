using KnowledgeBase.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace KnowledgeBase.Dtos
{
    public class KihonJouhouDetail
    {
        #region プロパティ

        /// <summary>
        /// キー部
        /// </summary>
        public KeyArea Key { get; set; }

        /// <summary>
        /// データ部
        /// </summary>
        public DataArea Data { get; set; }

        #endregion

        #region コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public KihonJouhouDetail() {

            if (this.Key == null) {

                this.Key = new KeyArea();
            }

            if (this.Data == null) {

                this.Data = new DataArea();
            }
        }

        #endregion

        #region DTOクラス

        public class KeyArea
        {
            /// <summary>
            /// ID
            /// </summary>
            public long ID { get; set; }

            /// <summary>
            /// 編集データかどうか
            /// </summary>
            public bool IsEditData => this.ID == 0 ? false : true;
        }

        public class DataArea
        {
            /// <summary>
            /// 項目名
            /// </summary>
            [Required]
            public string Name { get; set; }

            /// <summary>
            /// 項目に対する詳細説明
            /// </summary>
            public string Detail { get; set; }

            /// <summary>
            /// 重要度
            /// </summary>
            [Required]
            public RatingEnum Rating { get; set; }

            /// <summary>
            /// 分野
            /// </summary>
            [Required]
            public CategoryEnum Category { get; set; }

            /// <summary>
            /// ヘッダーID
            /// </summary>
            public long HeaderID { get; set; }
        }

        #endregion
    }
}
