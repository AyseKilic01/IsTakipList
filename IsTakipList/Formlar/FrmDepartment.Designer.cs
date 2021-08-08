namespace IsTakipList.Formlar
{
    partial class FrmDepartment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartment));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gctDepartman = new DevExpress.XtraGrid.GridControl();
            this.gvwDepartman = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rbeDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtDepartman = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.gctDepartman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwDepartman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbeDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartman.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gctDepartman
            // 
            this.gctDepartman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctDepartman.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gctDepartman.Location = new System.Drawing.Point(6, 112);
            this.gctDepartman.MainView = this.gvwDepartman;
            this.gctDepartman.Margin = new System.Windows.Forms.Padding(4);
            this.gctDepartman.Name = "gctDepartman";
            this.gctDepartman.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rbeDelete});
            this.gctDepartman.Size = new System.Drawing.Size(961, 226);
            this.gctDepartman.TabIndex = 0;
            this.gctDepartman.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwDepartman});
            // 
            // gvwDepartman
            // 
            this.gvwDepartman.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmID,
            this.clmCode,
            this.clmDelete});
            this.gvwDepartman.DetailHeight = 431;
            this.gvwDepartman.GridControl = this.gctDepartman;
            this.gvwDepartman.Name = "gvwDepartman";
            this.gvwDepartman.NewItemRowText = "Yeni Kayıt Satırı";
            this.gvwDepartman.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvwDepartman.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvwDepartman.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvwDepartman.OptionsSelection.MultiSelect = true;
            this.gvwDepartman.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvwDepartman.OptionsView.ShowGroupPanel = false;
            this.gvwDepartman.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // clmID
            // 
            this.clmID.Caption = "gridColumn1";
            this.clmID.FieldName = "ID";
            this.clmID.MinWidth = 25;
            this.clmID.Name = "clmID";
            this.clmID.Width = 94;
            // 
            // clmCode
            // 
            this.clmCode.Caption = "Departman Kodu";
            this.clmCode.FieldName = "departcode";
            this.clmCode.MinWidth = 25;
            this.clmCode.Name = "clmCode";
            this.clmCode.Visible = true;
            this.clmCode.VisibleIndex = 0;
            this.clmCode.Width = 1042;
            // 
            // clmDelete
            // 
            this.clmDelete.Caption = "Sil";
            this.clmDelete.ColumnEdit = this.rbeDelete;
            this.clmDelete.MinWidth = 25;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.Visible = true;
            this.clmDelete.VisibleIndex = 1;
            this.clmDelete.Width = 56;
            // 
            // rbeDelete
            // 
            this.rbeDelete.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            serializableAppearanceObject9.Image = ((System.Drawing.Image)(resources.GetObject("serializableAppearanceObject9.Image")));
            serializableAppearanceObject9.Options.UseImage = true;
            this.rbeDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.rbeDelete.Name = "rbeDelete";
            this.rbeDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.rbeDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.rbeDelete_ButtonClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnList);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.txtDepartman);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(967, 112);
            this.groupControl1.TabIndex = 1;
            // 
            // btnList
            // 
            this.btnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnList.ImageOptions.Image")));
            this.btnList.Location = new System.Drawing.Point(6, 26);
            this.btnList.Margin = new System.Windows.Forms.Padding(4);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(133, 28);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "Listele";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(98, 62);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(54, 22);
            this.txtID.TabIndex = 7;
            this.txtID.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 65);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Departman ID:";
            this.labelControl2.Visible = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(786, 29);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(133, 28);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(504, 29);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(133, 28);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(645, 29);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(133, 28);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtDepartman
            // 
            this.txtDepartman.Location = new System.Drawing.Point(213, 65);
            this.txtDepartman.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(179, 22);
            this.txtDepartman.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 89);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Departman Adı:";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(0, 112);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 226);
            this.splitterControl1.TabIndex = 2;
            this.splitterControl1.TabStop = false;
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 338);
            this.Controls.Add(this.gctDepartman);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.gctDepartman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwDepartman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbeDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartman.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gctDepartman;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwDepartman;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.TextEdit txtDepartman;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn clmID;
        private DevExpress.XtraGrid.Columns.GridColumn clmCode;
        private DevExpress.XtraGrid.Columns.GridColumn clmDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rbeDelete;
        private DevExpress.XtraEditors.SimpleButton btnList;
    }
}