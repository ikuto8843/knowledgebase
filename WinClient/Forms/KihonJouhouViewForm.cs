using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnowledgeBase.NewBaseForms;
using KnowledgeBase.Business;
using KnowledgeBase.Settings;
using KnowledgeBase.Utilities;
using KnowledgeBase.Dtos;
using KnowledgeBase.Const;
using Core.Utilities;

namespace KnowledgeBase.Forms
{
    public partial class KihonJouhouViewForm : BaseViewForm<KihonJouhouView>
    {
        #region プロパティ

        /// <summary>
        /// 基本情報サービス
        /// </summary>
        KihonJouhouService KihonJouhouService { get; set; }

        #endregion

        #region コンストラクタ

        public KihonJouhouViewForm()
        {
            InitializeComponent();
            this.KihonJouhouService = new KihonJouhouService();
        }

        #endregion

        #region イベントハンドラ

        /// <summary>
        /// フォームロード
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void KihonJouhouViewForm_Load(object sender, EventArgs e)
        {
            //初期値の設定
            InitializeValues();
        }

        /// <summary>
        /// セルエンターイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShowEditFormForRevise();
            }
        }

        /// <summary>
        /// データ表示ボタン
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void btnShowDatatable_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        /// <summary>
        /// セルクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ShowEditFormForRevise();
            }
        }

        /// <summary>
        /// 戻るボタン
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region メソッド

        /// <summary>
        ///登録モード 
        /// </summary>
        public override void ShowEditFormForReister()
        {
            //登録モード
            SubFormDispatcher.ShowEditFormDialog<KihonJouhouDetail>(this);
        }

        /// <summary>
        /// 検索条件を元にデータグリッドビューへデータ表示する
        /// </summary>
        /// <param name="condition"></param>
        public override void ShowData()
        {
            //一覧画面表示用DTOリストを取得する
            var viewData = KihonJouhouService.GetViewData(this.BindingData.condition);

            //データグッドビューのデータソースに取得したDTOリストを注入
            this.dgRowList.DataSource = new BindingList<KihonJouhouView.DataRow>(viewData);
        }

        /// <summary>
        /// 検索データをエディットフォームに表示する
        /// </summary>
        public override void ShowEditFormForRevise()
        {
            BindingManagerBase bm =
                dgRowList.BindingContext[dgRowList.DataSource, dgRowList.DataMember];

            //選択した行に対応するデータを取得
            this.BindingData.Row = (KihonJouhouView.DataRow)bm.Current;

            SubFormDispatcher.ShowEditFormDialog<KihonJouhouDetail>(this, new KihonJouhouDetail.KeyArea() { ID = this.BindingData.Row .ID});
        }

        /// <summary>
        /// 初期値の設定
        /// </summary>
        private void InitializeValues()
        {
            //コンボボックスの設定
            this.cmbCategory.DataSource = Enum.GetValues(typeof(CategoryEnum));
            this.cmbRating.DataSource = Enum.GetValues(typeof(RatingEnum));
        }

        /// <summary>
        /// Webサイトの表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.fe-siken.com/");
        }

        #endregion
    }
}
