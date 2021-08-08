using DevExpress.XtraEditors;
using ITLBusiness.Concrete.Managers;
using ITLBusiness.ValidationRules;
using ITLDataAccess.Concrete;
using ITLDataAccess.Concrete.EntityFramework;
using ITLEntity.Concrete;
using System;
using System.Windows.Forms;


namespace IsTakipList.Formlar
{
    public partial class FrmDepartment : Form
    {
        #region objects
        DepartmentManager d = new DepartmentManager(new EfTblDepartmentDAL());
        IsTakipListEntities db = new IsTakipListEntities(); //burada olmasi kötü birşey
        DepartmentValidator validate = new DepartmentValidator();
        #endregion
        public FrmDepartment()
        {
            InitializeComponent();
            List();
        }
        
        void List()
        {        
            var categoryvalues = d.GetAllBL();
            gctDepartman.DataSource = categoryvalues;
            gvwDepartman.Columns[0].Visible = false;
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblDepartment departman = new TblDepartment();
            departman.departcode = txtDepartman.Text;
            d.Add(departman);
            List();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(gvwDepartman.GetFocusedRowCellValue("ID").ToString());
            var value = db.TblDepartments.Find(x);
            db.TblDepartments.Remove(value);
            db.SaveChanges();
            XtraMessageBox.Show("Silindi");
            List();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvwDepartman.GetFocusedRowCellValue("ID") != null)
            {
                txtID.Text = gvwDepartman.GetFocusedRowCellValue("ID").ToString();
                txtDepartman.Text = gvwDepartman.GetFocusedRowCellValue("departcode").ToString();
            }
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

        private void rbeDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int x = int.Parse(gvwDepartman.GetFocusedRowCellValue("ID").ToString());
            var delete = d.GetByID(x);
            d.Delete(delete);
            List();
        }
    }
}
