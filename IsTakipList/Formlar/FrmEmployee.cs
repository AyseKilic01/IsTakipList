using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IsTakipList.Formlar
{
    
    public partial class FrmEmployee : Form
    {
        WorkFollow db = new WorkFollow();
        public FrmEmployee()
        {
            InitializeComponent();
        }
        void Listele()
        {
            var degerler = (from x in db.TblEmployee
                           select new
                           {
                               x.ID,
                               x.name,
                               x.surname,
                               x.mail,
                               x.phone,
                              Department = x.TblDepartment.departcode,
                               x.statu

                           }).ToList();
            gridControl1.DataSource = degerler.Where(x=>x.statu == true).ToList();
           
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            Listele();
            var departmanlar = (from x in db.TblDepartment
                                select new
                                {
                                    x.ID,
                                    x.departcode

                                }).ToList();
            lookUpDepartman.Properties.DisplayMember = "name";
            lookUpDepartman.Properties.ValueMember = "ID";
            lookUpDepartman.Properties.DataSource = departmanlar;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblEmployee t = new TblEmployee();
            t.name = txtAd.Text;
            t.surname = txtSoyad.Text;
            t.mail = txtMail.Text;
            t.phone = txtTel.Text;
            t.departmentID =Convert.ToInt32(lookUpDepartman.EditValue.ToString());
            db.TblEmployee.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Personel Eklendi");
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            var deger = db.TblEmployee.Find(x);
            deger.statu = false;
            db.SaveChanges();
            XtraMessageBox.Show("Personel listesinden çıkarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            var deger = db.TblEmployee.Find(x);
            deger.name = txtAd.Text;
            deger.surname = txtSoyad.Text;
            deger.mail = txtMail.Text;
            if(deger.departmentID != null)
                deger.departmentID = int.Parse(lookUpDepartman.EditValue.ToString());
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
