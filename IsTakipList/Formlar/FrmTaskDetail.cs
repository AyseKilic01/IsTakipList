using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipList.Formlar
{
    public partial class FrmTaskDetail : Form
    {
        public FrmTaskDetail()
        {
            InitializeComponent();
        }
        WorkFollow db = new WorkFollow();
        private void FrmGorevDetay_Load(object sender, EventArgs e)
        {
            db.TblDetailTask.Load();
            bindingSource1.DataSource = db.TblDetailTask.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void toolGorevSil_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
