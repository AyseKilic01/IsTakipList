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
    public partial class FrmGorev : Form
    {
        public FrmGorev()
        {
            InitializeComponent();
          
        }

        private void FrmGorev_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.TblPersonel
                                select new
                                {
                                    x.ID,
                                    AdSoyad = x.Ad +" "+ x.Soyad

                                }).ToList();
            lueGorevli.Properties.DisplayMember = "AdSoyad";
            lueGorevli.Properties.ValueMember = "ID";
            lueGorevli.Properties.DataSource = degerler;
            lueYetkili.Properties.DisplayMember = "AdSoyad";
            lueYetkili.Properties.ValueMember = "ID";
            lueYetkili.Properties.DataSource = degerler;

        }
        IsTakipListEntities db = new IsTakipListEntities();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblGorev gorevs = new TblGorev();
            gorevs.Aciklama = txtAciklama.Text;
            gorevs.Gorevli = Int32.Parse(lueGorevli.EditValue.ToString());
            gorevs.GorevVeren = Int32.Parse(lueYetkili.EditValue.ToString());
            gorevs.Tarih = DateTime.Parse(lueDate.Text);
            gorevs.Durum = "1";

            db.TblGorev.Add(gorevs);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Görev Eklendi");
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
