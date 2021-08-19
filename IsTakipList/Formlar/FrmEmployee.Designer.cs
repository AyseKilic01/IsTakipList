namespace IsTakipList.Formlar
{
    partial class FrmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployee));
            this.gctEmployee = new DevExpress.XtraGrid.GridControl();
            this.gvwEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpDepartman = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gvcI_EmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcI_EmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcI_EmployeeSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcI_EmployeeMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcI_EmployeePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcI_EmployeeImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcI_EmployeeDepartID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcI_EmployeeStatu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcI_EmployeeDepartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gctEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpDepartman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gctEmployee
            // 
            this.gctEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctEmployee.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gctEmployee.Location = new System.Drawing.Point(6, 0);
            this.gctEmployee.MainView = this.gvwEmployee;
            this.gctEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.gctEmployee.Name = "gctEmployee";
            this.gctEmployee.Size = new System.Drawing.Size(588, 338);
            this.gctEmployee.TabIndex = 3;
            this.gctEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwEmployee});
            this.gctEmployee.Load += new System.EventHandler(this.gridControl1_Load);
            // 
            // gvwEmployee
            // 
            this.gvwEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gvcI_EmployeeID,
            this.gvcI_EmployeeName,
            this.gvcI_EmployeeSurname,
            this.gvcI_EmployeeMail,
            this.gvcI_EmployeePhone,
            this.gvcI_EmployeeImage,
            this.gvcI_EmployeeDepartID,
            this.gvcI_EmployeeStatu,
            this.gvcI_EmployeeDepartCode});
            this.gvwEmployee.DetailHeight = 431;
            this.gvwEmployee.GridControl = this.gctEmployee;
            this.gvwEmployee.Name = "gvwEmployee";
            this.gvwEmployee.OptionsView.ShowGroupPanel = false;
            this.gvwEmployee.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpDepartman);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtTel);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtSoyad);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtMail);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(594, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(373, 338);
            this.groupControl1.TabIndex = 4;
            // 
            // lookUpDepartman
            // 
            this.lookUpDepartman.Location = new System.Drawing.Point(167, 228);
            this.lookUpDepartman.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpDepartman.Name = "lookUpDepartman";
            this.lookUpDepartman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpDepartman.Properties.NullText = "";
            this.lookUpDepartman.Size = new System.Drawing.Size(133, 22);
            this.lookUpDepartman.TabIndex = 15;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(23, 231);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(121, 16);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Personel Departman:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(167, 188);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(133, 22);
            this.txtTel.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 197);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 16);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Personel Tel:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(167, 112);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(133, 22);
            this.txtSoyad.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 116);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 16);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Personel Soyadı:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(167, 150);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(133, 22);
            this.txtMail.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 154);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Personel Mail:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(167, 31);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(133, 22);
            this.txtID.TabIndex = 7;
            this.txtID.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 34);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Personel ID:";
            this.labelControl2.Visible = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(167, 362);
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
            this.btnSil.Location = new System.Drawing.Point(167, 326);
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
            this.btnEkle.Location = new System.Drawing.Point(167, 290);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(133, 28);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(167, 69);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(133, 22);
            this.txtAd.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 73);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Personel Adı:";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(0, 0);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 338);
            this.splitterControl1.TabIndex = 5;
            this.splitterControl1.TabStop = false;
            // 
            // gvcI_EmployeeID
            // 
            this.gvcI_EmployeeID.Caption = "EmployeeID";
            this.gvcI_EmployeeID.FieldName = "EmployeeID";
            this.gvcI_EmployeeID.MinWidth = 25;
            this.gvcI_EmployeeID.Name = "gvcI_EmployeeID";
            this.gvcI_EmployeeID.Width = 94;
            // 
            // gvcI_EmployeeName
            // 
            this.gvcI_EmployeeName.Caption = "Personel Adı";
            this.gvcI_EmployeeName.FieldName = "EmployeeName";
            this.gvcI_EmployeeName.MinWidth = 25;
            this.gvcI_EmployeeName.Name = "gvcI_EmployeeName";
            this.gvcI_EmployeeName.Visible = true;
            this.gvcI_EmployeeName.VisibleIndex = 0;
            this.gvcI_EmployeeName.Width = 94;
            // 
            // gvcI_EmployeeSurname
            // 
            this.gvcI_EmployeeSurname.Caption = "Personel Soyadı";
            this.gvcI_EmployeeSurname.FieldName = "EmployeeSurname";
            this.gvcI_EmployeeSurname.MinWidth = 25;
            this.gvcI_EmployeeSurname.Name = "gvcI_EmployeeSurname";
            this.gvcI_EmployeeSurname.Visible = true;
            this.gvcI_EmployeeSurname.VisibleIndex = 1;
            this.gvcI_EmployeeSurname.Width = 94;
            // 
            // gvcI_EmployeeMail
            // 
            this.gvcI_EmployeeMail.Caption = "Personel Mail";
            this.gvcI_EmployeeMail.FieldName = "EmployeeMail";
            this.gvcI_EmployeeMail.MinWidth = 25;
            this.gvcI_EmployeeMail.Name = "gvcI_EmployeeMail";
            this.gvcI_EmployeeMail.Visible = true;
            this.gvcI_EmployeeMail.VisibleIndex = 2;
            this.gvcI_EmployeeMail.Width = 94;
            // 
            // gvcI_EmployeePhone
            // 
            this.gvcI_EmployeePhone.Caption = "Personel Telefon";
            this.gvcI_EmployeePhone.FieldName = "EmployeePhone";
            this.gvcI_EmployeePhone.MinWidth = 25;
            this.gvcI_EmployeePhone.Name = "gvcI_EmployeePhone";
            this.gvcI_EmployeePhone.Visible = true;
            this.gvcI_EmployeePhone.VisibleIndex = 3;
            this.gvcI_EmployeePhone.Width = 94;
            // 
            // gvcI_EmployeeImage
            // 
            this.gvcI_EmployeeImage.Caption = "Personel Görsel";
            this.gvcI_EmployeeImage.FieldName = "EmployeeImage";
            this.gvcI_EmployeeImage.MinWidth = 25;
            this.gvcI_EmployeeImage.Name = "gvcI_EmployeeImage";
            this.gvcI_EmployeeImage.Visible = true;
            this.gvcI_EmployeeImage.VisibleIndex = 4;
            this.gvcI_EmployeeImage.Width = 94;
            // 
            // gvcI_EmployeeDepartID
            // 
            this.gvcI_EmployeeDepartID.Caption = "EmployeeDepartID";
            this.gvcI_EmployeeDepartID.FieldName = "EmployeeDepartID";
            this.gvcI_EmployeeDepartID.MinWidth = 25;
            this.gvcI_EmployeeDepartID.Name = "gvcI_EmployeeDepartID";
            this.gvcI_EmployeeDepartID.Width = 94;
            // 
            // gvcI_EmployeeStatu
            // 
            this.gvcI_EmployeeStatu.Caption = "Personel Statü";
            this.gvcI_EmployeeStatu.FieldName = "EmployeeStatu";
            this.gvcI_EmployeeStatu.MinWidth = 25;
            this.gvcI_EmployeeStatu.Name = "gvcI_EmployeeStatu";
            this.gvcI_EmployeeStatu.Visible = true;
            this.gvcI_EmployeeStatu.VisibleIndex = 5;
            this.gvcI_EmployeeStatu.Width = 94;
            // 
            // gvcI_EmployeeDepartCode
            // 
            this.gvcI_EmployeeDepartCode.Caption = "Personel Departmanı";
            this.gvcI_EmployeeDepartCode.FieldName = "EmployeeDepartCode";
            this.gvcI_EmployeeDepartCode.MinWidth = 25;
            this.gvcI_EmployeeDepartCode.Name = "gvcI_EmployeeDepartCode";
            this.gvcI_EmployeeDepartCode.Visible = true;
            this.gvcI_EmployeeDepartCode.VisibleIndex = 6;
            this.gvcI_EmployeeDepartCode.Width = 94;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 338);
            this.Controls.Add(this.gctEmployee);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.splitterControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.gctEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpDepartman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gctEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwEmployee;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lookUpDepartman;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn gvcI_EmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn gvcI_EmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn gvcI_EmployeeSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gvcI_EmployeeMail;
        private DevExpress.XtraGrid.Columns.GridColumn gvcI_EmployeePhone;
        private DevExpress.XtraGrid.Columns.GridColumn gvcI_EmployeeImage;
        private DevExpress.XtraGrid.Columns.GridColumn gvcI_EmployeeDepartID;
        private DevExpress.XtraGrid.Columns.GridColumn gvcI_EmployeeStatu;
        private DevExpress.XtraGrid.Columns.GridColumn gvcI_EmployeeDepartCode;
    }
}