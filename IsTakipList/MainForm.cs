using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDepartmanList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartman frm = new Formlar.FrmDepartman();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPersonelList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersonel frm = new Formlar.FrmPersonel();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPersonelIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersonelIstatistik frm = new Formlar.FrmPersonelIstatistik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevListesi frm = new Formlar.FrmGorevListesi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.OpenForm frm = new Formlar.OpenForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnGorevTanimi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorev frm = new Formlar.FrmGorev();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void btnDurum_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDurum frm = new Formlar.FrmDurum();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevDetay frm = new Formlar.FrmGorevDetay();
            frm.Show();
        }

        private void btnFirma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFirmaTanim frm = new Formlar.FrmFirmaTanim();
            frm.Show();
        }

        private void btnFirmList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
