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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
            Listele();
        }
        IsTakipListEntities db = new IsTakipListEntities();
        void Listele()
        {
            var deger = (from x in db.TblDepartman
                        select new
                        {
                            x.Ad,
                            x.ID
                        }).ToList();
            gridControl1.DataSource = deger;
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblDepartman departman = new TblDepartman();
            departman.Ad = txtDepartman.Text;
            db.TblDepartman.Add(departman);
            db.SaveChanges();
            XtraMessageBox.Show("Eklendi");
            Listele();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            var deger = db.TblDepartman.Find(x);
            db.TblDepartman.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Silindi");
            Listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtDepartman.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            var deger = db.TblDepartman.Find(x);
            deger.Ad = txtDepartman.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Güncellendi");
            Listele();
        }
    }
}
