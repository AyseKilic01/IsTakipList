using DevExpress.XtraEditors;
using ITLDataAccess.Concrete;
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
    public partial class FrmFirmDefinition : Form
    {
        IsTakiplistEntites db = new IsTakiplistEntites();
        public FrmFirmDefinition()
        {
            InitializeComponent();
        }
        void List()
        {
            var values = (from x in db.Firms
                            select new
                            {
                                x.ID,
                                x.name,
                                x.address,
                                x.mail,
                                x.author,
                                x.phone,
                                x.city,
                                x.district

                            }).ToList();
            foreach (var i in values)
            {
                ListViewItem list = new ListViewItem();
                list.Text = i.ID.ToString();
                list.SubItems.Add(i.name.ToString());
                list.SubItems.Add(i.address.ToString());
                list.SubItems.Add(i.mail.ToString());
                list.SubItems.Add(i.author.ToString());
                list.SubItems.Add(i.phone.ToString());
                list.SubItems.Add(i.city.ToString());
                list.SubItems.Add(i.district.ToString());
                lstFirm.Items.Add(list);
            }
        }
        private void FrmFirmDefinition_Load(object sender, EventArgs e)
        {
            List();
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
            var value = db.Firms.Find(id);
            value.name = txtFirm.Text;
            value.address = txtAdres.Text;
            value.author = txtYetkili.Text;
            value.mail = txtMail.Text;
            value.city = txtIl.Text;
            value.district = txtIlce.Text;
            value.phone = txtTel.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Güncellendi");
            List();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
    }
}
