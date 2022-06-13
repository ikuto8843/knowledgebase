using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnowledgeBase.NewBaseForms;
using KnowledgeBase.Business;
using KnowledgeBase.Dtos;
using KnowledgeBase.Settings;
using KnowledgeBase.Utilities;
using KnowledgeBase.Const;
using Business.Services;

namespace KnowledgeBase.Forms
{
    public partial class KihonJouhouEditForm : BaseEditForm<KihonJouhouDetail>
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
            if(ModeSelection == ModeSelection.update)
            {
                //検索条件
                var searchCondtion = (KihonJouhouDetail.KeyArea)SearchCondtion;

                //DTOを取得
                var dto = KihonJouhouService.GetEditData(searchCondtion.ID);

                //値を設する
                this.BindingData = dto;
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
            KihonJouhouService.Save(this.BindingData);
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
            bool isSuccessed = KihonJouhouService.Delete(this.BindingData.Key.ID);

            //削除に成功した場合のみ一覧画面へ戻る
            if (isSuccessed) {

                this.Close();
            }
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
