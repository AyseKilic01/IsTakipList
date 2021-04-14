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
    
    public partial class FrmPersonel : Form
    {
        IsTakipListEntities db = new IsTakipListEntities();
        public FrmPersonel()
        {
            InitializeComponent();
        }
        void Listele()
        {
            var degerler = (from x in db.TblPersonel
                           select new
                           {
                               x.ID,
                               x.Ad,
                               x.Soyad,
                               x.MailAdres,
                               x.Telefon,
                              Departman = x.TblDepartman.Ad,
                               x.Durum

                           }).ToList();
            gridControl1.DataSource = degerler.Where(x=>x.Durum == true).ToList();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            Listele();
            var departmanlar = (from x in db.TblDepartman
                                select new
                                {
                                    x.ID,
                                    x.Ad

                                }).ToList();
            lookUpDepartman.Properties.DisplayMember = "Ad";
            lookUpDepartman.Properties.ValueMember = "ID";
            lookUpDepartman.Properties.DataSource = departmanlar;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblPersonel t = new TblPersonel();
            t.Ad = txtAd.Text;
            t.Soyad = txtSoyad.Text;
            t.MailAdres = txtMail.Text;
            t.Telefon = txtTel.Text;
            t.Departman =Convert.ToInt32(lookUpDepartman.EditValue.ToString());
            db.TblPersonel.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Personel Eklendi");
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            var deger = db.TblPersonel.Find(x);
            deger.Durum = false;
            db.SaveChanges();
            XtraMessageBox.Show("Personel listesinden çıkarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            var deger = db.TblPersonel.Find(x);
            deger.Ad = txtAd.Text;
            deger.Soyad = txtSoyad.Text;
            deger.MailAdres = txtMail.Text;
            if(deger.Departman != null)
                deger.Departman = int.Parse(lookUpDepartman.EditValue.ToString());
            XtraMessageBox.Show("Departman boş olamaz !!!", "Bilgi", MessageBoxButtons.OKCancel);         
            db.SaveChanges();
            XtraMessageBox.Show("Güncellendi", "Bilgi", MessageBoxButtons.OK);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("MailAdres").ToString();
            lookUpDepartman.Text = gridView1.GetFocusedRowCellValue("Departman").ToString();
        }
    }
}
