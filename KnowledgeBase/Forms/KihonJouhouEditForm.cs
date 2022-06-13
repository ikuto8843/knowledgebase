using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnowledgeBase.BaseForms;
using KnowledgeBase.Business;
using KnowledgeBase.Dtos;
using KnowledgeBase.Settings;
using KnowledgeBase.Utilities;
using KnowledgeBase.Const;
using Business.Services;
using CustomAttribute;

namespace KnowledgeBase.Forms
{
    public partial class KihonJouhouEditForm : BaseEditForm
    {

        #region フィールド

        /// <summary>
        /// 詳細DTO
        /// </summary>
        public KihonJouhouDetail.KeyArea keyArea;

        #endregion

        #region プロパティ

        /// <summary>
        /// 基本情報サービス
        /// </summary>
        KihonJouhouService KihonJouhouService { get; set; }

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public KihonJouhouEditForm()
        {
            InitializeComponent();

            KihonJouhouService = new KihonJouhouService();
        }

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void TransactionEditForm_Load(object sender, EventArgs e)
        {
            //コンボボックスに値を設定する
            cmbRating.DataSource = Enum.GetValues(typeof(RatingEnum));
            cmbCategory.DataSource = Enum.GetValues(typeof(CategoryEnum));

            //値の設定
            switch (ModeSelection)
            {
                case ModeSelection.register:
                    SetValuesForRegister();
                    break;

                case ModeSelection.update:

                    //検索条件
                    var searchCondtion = (KihonJouhouDetail.KeyArea)SearchCondtion;

                    //DTOを取得
                    var dto = KihonJouhouService.GetEditData(searchCondtion.No);

                    //値を設する
                    SetValuesForUpdate(dto);
                    break;
            }

            //コントロールの設定
            SetUpControls(ModeSelection);
        }

        /// <summary>
        /// 登録ボタン押下イベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            UpdateOrRegister();
        }

        #region 登録・更新・削除

        /// <summary>
        /// 登録または更新します
        /// </summary>
        public override void UpdateOrRegister()
        {
            bool isSuccessed = true;

            //更新要素
            elements.id = txtKoumokuNumber.Text;
            elements.Name = txtKoumokuName.Text;
            elements.Detail = txtDetails.Text;
            RatingEnum rating = (RatingEnum)cmbRating.SelectedItem;
            CategoryEnum category = (CategoryEnum)cmbCategory.SelectedItem;

            //モードにより登録・更新を行う
            switch (ModeSelection)
            {
                case ModeSelection.register:

                    isSuccessed = KihonJouhouService.Register(elements.id, elements.Name, elements.Detail, (int)rating, (int)category);

                    break;

                case ModeSelection.update:

                    isSuccessed = KihonJouhouService.Update(elements.id, elements.Name, elements.Detail, (int)rating, (int)category);

                    break;
            }

            //正常に完了したかどうか
            if (isSuccessed)
            {

                MessageBox.Show("実行完了");

                ViewForm.IsTransacted = true;

                this.Close();

                ViewForm.Show();
            }
            else {

                MessageBox.Show("実行に失敗しました");
            }
        }

        /// <summary>
        /// 削除します
        /// </summary>
        public override void Delete() {

            //削除確認ダイアログの表示
            var dialogResult = MessageBox.Show("本当に削除しますか？？", "削除確認", MessageBoxButtons.YesNoCancel);

            //削除ダイアログでYes以外を選択した場合は処理を行わない。
            if (dialogResult != DialogResult.Yes) return;

            //削除に成功したか否か
            bool isSuccessed = KihonJouhouService.Delete(txtKoumokuNumber.Text);

            //削除に成功した場合のみ一覧画面へ戻る
            if (isSuccessed) {

                this.Close();

                ViewForm.IsTransacted = true;

                ViewForm.Show();
            }
        }

        #endregion

        #region 値設定

        /// <summary>
        /// 登録モードの初期値を設定する
        /// </summary>
        private void SetValuesForRegister() {

            this.txtKoumokuNumber.Text = KihonJouhouService.GetLatestKoumokuNo();
            this.txtKoumokuName.Text = null;

            label1.Text = EnumUtility.GetEnumDescription(ModeSelection);
        }

        /// <summary>
        /// 更新モードの初期値を設定する
        /// </summary>
        private void SetValuesForUpdate(KihonJouhouDetail dto) {

            //バインディング
            this.txtKoumokuNumber.DataBindings.Add(new Binding("Text", dto.Key, "No"));
            this.txtKoumokuName.DataBindings.Add(new Binding("Text", dto.Data, "Name"));
            this.cmbRating.DataBindings.Add(new Binding("SelectedItem", dto.Data, "Rating"));
            this.cmbCategory.DataBindings.Add(new Binding("SelectedItem", dto.Data, "Category"));
            this.txtDetails.DataBindings.Add(new Binding("Text", dto.Data, "Detail"));

            label1.Text = EnumUtility.GetEnumDescription(ModeSelection);
        }

        #endregion

        #region コントロール設定

        /// <summary>
        /// モードによってコントロールの状態を変更する
        /// </summary>
        /// <param name="transacitonMode">現在のモード</param>
        private void SetUpControls(ModeSelection transacitonMode)
        {

            if(transacitonMode == ModeSelection.register)
            {
                this.btnDelete.Visible = false;
            }
            else if(transacitonMode == ModeSelection.update)
            {
                this.btnDelete.Visible = true;
            }
        }

        #endregion

        #region DTOクラス

        /// <summary>
        /// DTOクラス
        /// </summary>
        public class elements
        {
            public static string id { get; set; }
            public static string Detail { get; set; }
            public static string Name { get; set; }
        }

        #endregion
    }
}
