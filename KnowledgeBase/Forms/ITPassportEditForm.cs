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
using KnowledgeBase.Const;
using KnowledgeBase.Dtos;
using KnowledgeBase.Settings;
using KnowledgeBase.Utilities;

namespace KnowledgeBase.Forms
{
    public partial class ITPassportEditForm : BaseEditForm
    {

        #region フィールド

        /// <summary>
        /// 詳細DTO
        /// </summary>
        public ITPassportDetail dto;

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ITPassportEditForm()
        {
            InitializeComponent();

            //コンボボックスの設定
            this.cmbImportance.DataSource = Enum.GetValues(typeof(RatingEnum));
            this.cmbCategory.DataSource = Enum.GetValues(typeof(CategoryEnum));

            this.txtKoumokuName.Select();
        }

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void TransactionEditForm_Load(object sender, EventArgs e)
        {
            //値の設定
            switch (ModeSelection)
            {
                case ModeSelection.register:
                    SetValuesForRegister();
                    break;

                case ModeSelection.update:

                    //検索条件
                    var searchCondtion = (ITPassportDetail)SearchCondtion;

                    //DTOを取得
                    dto = ITPassportService.GetEditData(searchCondtion.No);

                    //値を設する
                    SetValuesForUpdate(dto);

                    break;
            }

            //コントロールの設定
            SetUpControls(ModeSelection);
        }

        #region 登録・更新・削除

        /// <summary>
        /// 登録または更新します
        /// </summary>
        public override void UpdateOrRegister()
        {
            bool isSuccessed = true;

            switch (ModeSelection)
            {
                case ModeSelection.register:

                    isSuccessed = ITPassportService.Register(dto.No, dto.Name, dto.Detail, (int)dto.Rating, (int)dto.Category);

                    break;

                case ModeSelection.update:

                    isSuccessed = ITPassportService.Update(dto.No, dto.Name, dto.Detail, (int)dto.Rating, (int)dto.Category);

                    break;
            }

            if (isSuccessed)
            {

                MessageBox.Show("実行完了");

                this.ViewForm.IsTransacted = true;

                this.ViewForm.Show();

                this.Close();
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
            bool isSuccessed = ITPassportService.Delete(txtKoumokuNumber.Text);

            //削除に成功した場合のみ一覧画面へ戻る
            if (isSuccessed) {

                this.Close();

                this.ViewForm.IsTransacted = true;

                this.ViewForm.Show();
            }
        }

        #endregion

        #region 値設定

        /// <summary>
        /// 登録モードの初期値を設定する
        /// </summary>
        private void SetValuesForRegister() {

            dto = new ITPassportDetail()
            {
                No = ITPassportService.GetLatestKoumokuNo(),
                Name = "",
                Rating = RatingEnum.aLittleImportant,
                Category = CategoryEnum.management,
                Detail = ""
            };

            this.txtKoumokuNumber.DataBindings.Add(new Binding("Text", dto, "No"));
            this.txtKoumokuName.DataBindings.Add(new Binding("Text", dto, "Name"));
            this.cmbImportance.DataBindings.Add(new Binding("SelectedItem", dto, "Rating"));
            this.cmbCategory.DataBindings.Add(new Binding("SelectedItem", dto, "Category"));

            label1.Text = EnumUtility.GetEnumDescription(ModeSelection);
        }

        /// <summary>
        /// 更新モードの初期値を設定する
        /// </summary>
        private void SetValuesForUpdate(ITPassportDetail dto) {

            //バインディング
            this.txtKoumokuNumber.DataBindings.Add(new Binding("Text", dto, "No"));
            this.txtKoumokuName.DataBindings.Add(new Binding("Text", dto, "Name"));
            this.cmbImportance.DataBindings.Add(new Binding("SelectedItem", dto, "Rating"));
            this.cmbCategory.DataBindings.Add(new Binding("SelectedItem", dto, "Category"));

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
    }
}
