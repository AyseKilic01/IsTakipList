using DevExpress.XtraEditors;
using ITLBusiness.Concrete.Managers;
using ITLDataAccess.Concrete;
using ITLDataAccess.Concrete.EntityFramework;
using ITLEntity.Concrete;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace IsTakipList.Formlar
{

    public partial class FrmEmployee : Form
    {
        #region objects
        IsTakipListEntities db = new IsTakipListEntities();
        EmployeeManager manager = new EmployeeManager(new EfTblEmployeeDAL());
        ITLEntity.Concrete.TblEmployee empl = new ITLEntity.Concrete.TblEmployee();
        #endregion
        public FrmEmployee()
        {
            InitializeComponent();
        }
        void Listele()
        {
            var degerler = manager.GetAllBL();
            gridControl1.DataSource = degerler.Where(x=>x.statu == true).ToList();
        }
        void ListDepart()
        {
            var departmanlar = (from x in db.TblDepartments
                                select new
                                {
                                    x.ID,
                                    x.departcode

                                }).ToList();
            lookUpDepartman.Properties.DisplayMember = "name";
            lookUpDepartman.Properties.ValueMember = "ID";
            lookUpDepartman.Properties.DataSource = departmanlar;
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            Listele();
            ListDepart();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            empl.ID = Convert.ToInt32(txtID.Text);
            
            XtraMessageBox.Show("Yeni Personel Eklendi");
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            var deger = db.TblEmployees.Find(x);
            //deger.statu = false;
            db.SaveChanges();
            XtraMessageBox.Show("Personel listesinden çıkarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            var deger = db.TblEmployees.Find(x);
           // deger.name = txtAd.Text;
           // deger.surname = txtSoyad.Text;
           // deger.mail = txtMail.Text;
           // if(deger.departmentID != null)
           //     deger.departmentID = int.Parse(lookUpDepartman.EditValue.ToString());
            XtraMessageBox.Show("Departman boş olamaz !!!", "Bilgi", MessageBoxButtons.OKCancel);         
            db.SaveChanges();
            XtraMessageBox.Show("Güncellendi", "Bilgi", MessageBoxButtons.OK);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("name").ToString();
            txtSoyad.Text = gridView1.GetFocusedRowCellValue("surname").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("mail").ToString();
            lookUpDepartman.Text = gridView1.GetFocusedRowCellValue("Department").ToString();
        }
    }
}
