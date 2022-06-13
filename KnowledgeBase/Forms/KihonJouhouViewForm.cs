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
using KnowledgeBase.BaseForms;
using KnowledgeBase.Business;
using KnowledgeBase.Settings;
using KnowledgeBase.Utilities;
using KnowledgeBase.Dtos;
using KnowledgeBase.Const;
using KnowledgeBase.NewBaseForms;

namespace KnowledgeBase.Forms
{
    public partial class KihonJouhouViewForm : BaseViewForm
    {
        #region フィールド

        /// <summary>
        /// DTOクラス
        /// </summary>
        KihonJouhouHeader dto;

        #endregion

        #region プロパティ

        /// <summary>
        /// トランザクションチェック
        /// </summary>
        public bool isTransacted { get; set; }

        #endregion

        #region コンストラクタ

        public KihonJouhouViewForm()
        {
            InitializeComponent();
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

            //コントロールの初期化
            InitializeControls();
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
                //修正モード
                //EditForm = new KihonJouhouEditForm();

                EditForm.ModeSelection = ModeSelection.update;

                ShowEditFormForRevise();

                e.Handled = true;
            }
        }

        /// <summary>
        /// セルクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //修正モード
            //EditForm = new KihonJouhouEditForm();

            EditForm.ModeSelection = ModeSelection.update;

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

            SelectionForm.Show();
        }

        /// <summary>
        /// チェックボックスチェック状態変更イベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void checkBoxJuuyoudo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxJuuyoudo.Checked)
            {
                this.cmbRating.Enabled = false;
                dto.condition.Rating = null;
            }
            else
            {
                this.cmbRating.Enabled = true;
                dto.condition.Rating = (RatingEnum)this.cmbRating.SelectedItem;
            }
        }

        /// <summary>
        /// チェックボックスチェック状態変更イベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void checkBoxCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxCategory.Checked)
            {
                this.cmbCategory.Enabled = false;
                dto.condition.Category = null;
            }
            else
            {
                this.cmbCategory.Enabled = true;
                dto.condition.Category = (CategoryEnum)this.cmbCategory.SelectedItem;
            }
        }

        /// <summary>
        /// コンボボックス選択変更イベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void cmbRating_SelectedValueChanged(object sender, EventArgs e)
        {
            if (dto == null)
            {

                dto = new KihonJouhouHeader();
            }

            this.dto.condition.Rating = (RatingEnum)cmbRating.SelectedItem;
        }

        /// <summary>
        /// コンボボックス選択変更イベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void cmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {

            if (dto == null)
            {

                dto = new KihonJouhouHeader();
            }

            this.dto.condition.Category = (CategoryEnum)cmbCategory.SelectedItem;
        }

        #endregion

        #region メソッド

        /// <summary>
        ///登録モード 
        /// </summary>
        public override void ShowEditFormForReister()
        {
            //登録モード
            //this.EditForm = new KihonJouhouEditForm();
            EditForm.ModeSelection = ModeSelection.register;
            EditForm.Show();
            EditForm.ViewForm = this;

            this.Hide();
        }

        /// <summary>
        /// 検索条件を元にデータグリッドビューへデータ表示する
        /// </summary>
        /// <param name="condition"></param>
        public override void ShowData()
        {
            ServiceReference1.WebService1SoapClient serviceReference1 = new KnowledgeBase.ServiceReference1.WebService1SoapClient();

            var data = serviceReference1.GetDataSet();

            KihonJouhouService service = new KihonJouhouService();

            //一覧画面表示用DTOリストを取得する
            var viewData = service.GetViewData(dto.condition);

            //データグッドビューのデータソースに取得したDTOリストを注入
            this.dataGridView1.DataSource = viewData;

            int searchedCount = 0;

            if (viewData != null)
            {
                searchedCount = viewData.Count;
            }

            //検索件数を表示
            this.lblSearchdNumbers.Text = "検索数 " + searchedCount.ToString() + "件";

            //データ検索ヒット件数によって動作が変わる
            if (searchedCount > 0)
            {
                this.dataGridView1.Select();
            }
            else
            {
                MessageBox.Show("データが見つかりません。");
                this.txtKoumokuNoFrom.Select();
            }
        }

        /// <summary>
        /// 検索データをエディットフォームに表示する
        /// </summary>
        public override void ShowEditFormForRevise()
        {
            KihonJouhouEditForm editForm = new KihonJouhouEditForm();

            //更新モード
            editForm.ModeSelection = ModeSelection.update;

            BindingManagerBase bm =
                dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember];

            //選択した行に対応するデータを取得
            dto.Row = (KihonJouhouHeader.DataRow)bm.Current;

            //編集画面用DTO
            KihonJouhouDetail.KeyArea detailKey = new KihonJouhouDetail.KeyArea() { No = dto.Row.No };

            //DTOを編集画面に渡す
            //EditForm.keyArea = detailKey;
            editForm.SearchCondtion = detailKey;

            //編集画面の表示
            editForm.Show();
            editForm.ViewForm = this;

            this.Hide();
        }

        /// <summary>
        /// 初期値の設定
        /// </summary>
        private void InitializeValues()
        {
            //DTO設定
            var key = new KihonJouhouHeader.SearchCondition();
            key.KoumokuName = "";
            key.KoumokuNoFrom = "";
            key.KoumokuNoTo = "";
            key.Rating = RatingEnum.notImportant;
            key.Category = CategoryEnum.management;

            dto = new KihonJouhouHeader();
            dto.condition = key;

            //データバインド
            this.txtKoumokuName.DataBindings.Add(new Binding("Text", key, "KoumokuName"));
            this.txtKoumokuNoFrom.DataBindings.Add(new Binding("Text", key, "KoumokuNoFrom"));
            this.txtKoumokuNoTo.DataBindings.Add(new Binding("Text", key, "KoumokuNoTo"));
            this.cmbRating.DataBindings.Add(new Binding("SelectedItem", key, "Rating"));
        }

        /// <summary>
        /// コントロールの初期化
        /// </summary>
        private void InitializeControls()
        {
            //幅・高さの最低サイズを設定
            this.minimumHeight = 662;
            this.minimumWidth = 628;

            //データグリッドビューは行選択モード
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //イベントハンドラ
            dataGridView1.KeyDown += new KeyEventHandler(this.dataGridView1_KeyDown);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);

            //コンボボックスの設定
            this.cmbRating.DataSource = Enum.GetValues(typeof(RatingEnum));
            this.cmbCategory.DataSource = Enum.GetValues(typeof(CategoryEnum));

            // DataGirdViewのTypeを取得
            System.Type dgvtype = typeof(DataGridView);

            // プロパティ設定の取得
            System.Reflection.PropertyInfo dgvPropertyInfo =
            dgvtype.GetProperty(
            "DoubleBuffered", System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.NonPublic);

            // 対象のDataGridViewにtrueをセットする
            dgvPropertyInfo.SetValue(dataGridView1, true, null);
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
