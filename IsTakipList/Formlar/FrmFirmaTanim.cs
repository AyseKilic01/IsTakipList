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
    public partial class FrmFirmaTanim : Form
    {
        IsTakipListEntities db = new IsTakipListEntities();
        public FrmFirmaTanim()
        {
            InitializeComponent();
        }
        void Listele()
        {
            var degerler = (from x in db.TblFirmalar
                            select new
                            {
                                x.ID,
                                x.Ad,
                                x.Adres,
                                x.MailAdres,
                                x.Yetkili,
                                x.Telefon,
                                x.il,
                                x.ilce

                            }).ToList();
            foreach (var i in degerler)
            {
                ListViewItem list = new ListViewItem();
                list.Text = i.ID.ToString();
                list.SubItems.Add(i.Ad.ToString());
                list.SubItems.Add(i.Adres.ToString());
                list.SubItems.Add(i.MailAdres.ToString());
                list.SubItems.Add(i.Yetkili.ToString());
                list.SubItems.Add(i.Telefon.ToString());
                list.SubItems.Add(i.il.ToString());
                list.SubItems.Add(i.ilce.ToString());
                lstFirm.Items.Add(list);
            }
        }

        private void FrmFirmaTanim_Load(object sender, EventArgs e)
        {
            Listele();
        }
        int id = 0;
        private void lstFirm_Click(object sender, EventArgs e)
        {
            id = int.Parse(lstFirm.SelectedItems[0].SubItems[0].Text);
            txtFirm.Text = lstFirm.SelectedItems[0].SubItems[1].Text.Trim();
            txtAdres.Text = lstFirm.SelectedItems[0].SubItems[2].Text.Trim();
            txtMail.Text = lstFirm.SelectedItems[0].SubItems[3].Text.Trim();
            txtYetkili.Text = lstFirm.SelectedItems[0].SubItems[4].Text.Trim();
            txtTel.Text = lstFirm.SelectedItems[0].SubItems[5].Text.Trim();
            txtIl.Text = lstFirm.SelectedItems[0].SubItems[6].Text.Trim();
            txtIlce.Text = lstFirm.SelectedItems[0].SubItems[7].Text.Trim();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var deger = db.TblFirmalar.Find(id);
            deger.Ad = txtFirm.Text;
            deger.Adres = txtAdres.Text;
            deger.Yetkili = txtYetkili.Text;
            deger.MailAdres = txtMail.Text;
            deger.il = txtIl.Text;
            deger.ilce = txtIlce.Text;
            deger.Telefon = txtTel.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Güncellendi");
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
    }
}
