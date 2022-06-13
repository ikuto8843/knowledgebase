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

namespace KnowledgeBase.Forms
{
    public partial class ITPassportViewForm : BaseViewForm
    {
        #region フィールド

        /// <summary>
        /// DTOクラス
        /// </summary>
        ITPassportHeader dto;

        #endregion

        #region プロパティ

        /// <summary>
        /// トランザクションチェック
        /// </summary>
        public static bool isTransacted { get; set; }

        #endregion

        #region コンストラクタ

        public ITPassportViewForm()
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
        private void ITPassportViewForm_Load(object sender, EventArgs e)
        {
            //コントロール初期化
            InitializeControls();

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
            var currentCell = this.dataGridView1.CurrentCell;

            if (e.KeyCode == Keys.Enter)
            {
                ShowEditFormForRevise();
            }
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

            SelectionForm.Show();
        }

        /// <summary>
        /// コンボボックスで選択したアイテムが変更されたときに発生するイベント（重要度）
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void cmbImportance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dto != null)
            {
                dto.condition.Rating = (RatingEnum)cmbImportance.SelectedValue;
            }
        }

        /// <summary>
        /// コンボボックスで選択したアイテムが変更されたときに発生するイベント（カテゴリ）
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dto != null)
            {
                dto.condition.Category = (CategoryEnum)cmbCategory.SelectedValue;
            }
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
                this.cmbImportance.Enabled = false;
                dto.condition.Rating = null;
            }
            else
            {
                this.cmbImportance.Enabled = true;
                dto.condition.Rating = (RatingEnum)this.cmbImportance.SelectedItem;
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

        #endregion

        #region メソッド

        /// <summary>
        ///登録モード 
        /// </summary>
        public override void ShowEditFormForReister()
        {
            //登録モード
            EditForm = new ITPassportEditForm();

            EditForm.ModeSelection = ModeSelection.register;

            this.EditForm.ViewForm = this;

            EditForm.Show();

            this.Hide();
        }

        /// <summary>
        /// 検索データをエディットフォームに表示する
        /// </summary>
        public override void ShowEditFormForRevise()
        {
            BindingManagerBase bm =
                dataGridView1.BindingContext[dataGridView1.DataSource, dataGridView1.DataMember];
            dto.Row = (ITPassportHeader.DataRow)bm.Current;

            this.Hide();

            this.EditForm = new ITPassportEditForm();

            this.EditForm.ModeSelection = ModeSelection.update;

            ITPassportDetail detail = new ITPassportDetail()
            {

                No = dto.Row.No,
                Name = dto.Row.Name
            };

            this.EditForm.SearchCondtion = detail;

            this.EditForm.ViewForm = this;

            EditForm.Show();
        }

        /// <summary>
        /// 検索条件を元にデータグリッドビューへデータ表示する
        /// </summary>
        /// <param name="condition"></param>
        public override void ShowData()
        {
            ITPassportService service = new ITPassportService();

            //一覧画面表示用DTOリストを取得する
            var viewData = service.GetViewData(dto.condition);

            //データグッドビューのデータソースに取得したDTOリストを注入
            this.dataGridView1.DataSource = viewData;

            //検索件数を表示
            this.lblSearchdNumbers.Text = "検索数 " + viewData.Count.ToString() + "件";

            //データ検索ヒット件数によって動作が変わる
            if (viewData.Count > 0)
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
        /// 初期値の設定とバインドを行う
        /// </summary>
        private void InitializeValues()
        {
            //DTO設定
            dto = new ITPassportHeader();
            dto.condition.KoumokuName = "";
            dto.condition.KoumokuNoFrom = "";
            dto.condition.KoumokuNoTo = "";
            dto.condition.Rating = Const.RatingEnum.aLittleImportant;
            dto.condition.Category = Const.CategoryEnum.management;

            //データバインド
            this.txtKoumokuName.DataBindings.Add(new Binding(nameof(txtKoumokuName.Text), dto.condition, nameof(dto.condition.KoumokuName)));
            this.txtKoumokuNoFrom.DataBindings.Add(new Binding(nameof(txtKoumokuNoFrom.Text), dto.condition, nameof(dto.condition.KoumokuNoFrom)));
            this.txtKoumokuNoTo.DataBindings.Add(new Binding(nameof(txtKoumokuNoTo.Text), dto.condition, nameof(dto.condition.KoumokuNoTo)));
            this.cmbImportance.DataBindings.Add(new Binding("SelectedItem", dto.condition, "Rating"));
            this.cmbCategory.DataBindings.Add(new Binding("SelectedItem", dto.condition, "Category"));
        }

        /// <summary>
        /// コントロールを初期化する
        /// </summary>
        private void InitializeControls()
        {
            //コンボボックスの設定
            this.cmbImportance.DataSource = Enum.GetValues(typeof(RatingEnum));
            this.cmbCategory.DataSource = Enum.GetValues(typeof(CategoryEnum));

            dataGridView1.KeyDown += new KeyEventHandler(this.dataGridView1_KeyDown);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);

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
    }

    #endregion

    /// <summary>
    /// プロパティ変更通知クラス（継承用）
    /// </summary>
    public class NofityPropertyChange : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NofityPropertyChanged(string info)
        {

            if (PropertyChanged != null)
            {

                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
