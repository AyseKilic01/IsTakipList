using DevExpress.XtraEditors;
using ITLBusiness.Concrete.Managers;
using ITLDataAccess.Concrete;
using ITLDataAccess.Concrete.EntityFramework;
using ITLEntity.Concrete;
using System;
using System.Windows.Forms;


namespace IsTakipList.Formlar
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
            List();
        }
        IsTakiplistEntites db = new IsTakiplistEntites();
        void List()
        {
            DepartmentManager category = new DepartmentManager(new EfTblDepartmentDAL());
            var categoryvalues = category.GetAllBL();
           gridControl1.DataSource = categoryvalues;
            //gridView1.Columns[0].Visible = false;
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblDepartment departman = new TblDepartment();
            departman.departcode = txtDepartman.Text;
            db.TblDepartments.Add(departman);
            db.SaveChanges();
            XtraMessageBox.Show("Eklendi");
            List();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            var value = db.TblDepartments.Find(x);
            db.TblDepartments.Remove(value);
            db.SaveChanges();
            XtraMessageBox.Show("Silindi");
            List();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtDepartman.Text = gridView1.GetFocusedRowCellValue("departcode").ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            var value = db.TblDepartments.Find(x);
            value.departcode = txtDepartman.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Güncellendi");
            List();
        }
    }
}
