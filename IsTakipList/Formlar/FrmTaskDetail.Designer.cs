namespace IsTakipList.Formlar
{
    partial class FrmTaskDetail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaskDetail));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnGorev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmnAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolGorevSil = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1327, 510);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnID,
            this.columnGorev,
            this.colmnAciklama,
            this.columnDate,
            this.columnTime});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Yeni Kayıt Satırı";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // columnID
            // 
            this.columnID.Caption = "ID";
            this.columnID.FieldName = "ID";
            this.columnID.MinWidth = 25;
            this.columnID.Name = "columnID";
            this.columnID.Visible = true;
            this.columnID.VisibleIndex = 0;
            this.columnID.Width = 94;
            // 
            // columnGorev
            // 
            this.columnGorev.Caption = "Görev";
            this.columnGorev.FieldName = "Gorev";
            this.columnGorev.MinWidth = 25;
            this.columnGorev.Name = "columnGorev";
            this.columnGorev.Visible = true;
            this.columnGorev.VisibleIndex = 1;
            this.columnGorev.Width = 94;
            // 
            // colmnAciklama
            // 
            this.colmnAciklama.Caption = "Açıklama";
            this.colmnAciklama.FieldName = "Aciklama";
            this.colmnAciklama.MinWidth = 25;
            this.colmnAciklama.Name = "colmnAciklama";
            this.colmnAciklama.Visible = true;
            this.colmnAciklama.VisibleIndex = 2;
            this.colmnAciklama.Width = 94;
            // 
            // columnDate
            // 
            this.columnDate.Caption = "Tarih";
            this.columnDate.FieldName = "Tarih";
            this.columnDate.MinWidth = 25;
            this.columnDate.Name = "columnDate";
            this.columnDate.Visible = true;
            this.columnDate.VisibleIndex = 3;
            this.columnDate.Width = 94;
            // 
            // columnTime
            // 
            this.columnTime.Caption = "Saat";
            this.columnTime.FieldName = "Saat";
            this.columnTime.MinWidth = 25;
            this.columnTime.Name = "columnTime";
            this.columnTime.Visible = true;
            this.columnTime.VisibleIndex = 4;
            this.columnTime.Width = 94;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGorevSil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // toolGorevSil
            // 
            this.toolGorevSil.Name = "toolGorevSil";
            this.toolGorevSil.Size = new System.Drawing.Size(210, 24);
            this.toolGorevSil.Text = "Görev Detay Sil";
            this.toolGorevSil.Click += new System.EventHandler(this.toolGorevSil_Click);
            // 
            // FrmGorevDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 510);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGorevDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev Detayı";
            this.Load += new System.EventHandler(this.FrmGorevDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn columnID;
        private DevExpress.XtraGrid.Columns.GridColumn columnGorev;
        private DevExpress.XtraGrid.Columns.GridColumn colmnAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn columnDate;
        private DevExpress.XtraGrid.Columns.GridColumn columnTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolGorevSil;
    }
}