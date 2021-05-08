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
            Formlar.FrmDepartment frm = new Formlar.FrmDepartment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPersonelList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmEmployee frm = new Formlar.FrmEmployee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPersonelIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmStatistic frm = new Formlar.FrmStatistic();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmlTaskDetail frm = new Formlar.FrmlTaskDetail();
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
            Formlar.FrmTask frm = new Formlar.FrmTask();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void btnDurum_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmStatus frm = new Formlar.FrmStatus();
            frm.MdiParent = this;
            
            frm.Show();
        }

        private void btnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmTaskDetail frm = new Formlar.FrmTaskDetail();
            frm.Show();
        }

        private void btnFirma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFirmDefinition frm = new Formlar.FrmFirmDefinition();
            frm.Show();
        }

        private void btnFirmList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnMainPage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.MainPage frm = new Formlar.MainPage();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
