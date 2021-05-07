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
    public partial class FrmGorevListesi : Form
    {
        public FrmGorevListesi()
        {
            InitializeComponent();
        }
        WorkFollow db = new WorkFollow();
        private void FrmGorevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblTask
                                       select new
                                       {
                                          Açıklama = x.statement
                                       }).ToList();
            cntAktifGorev.Text = db.TblTask.Count(x => x.passive == false).ToString();
            cntPasifGorev.Text = db.TblTask.Count(x => x.passive == true).ToString();
            cntDepartman.Text = db.TblDepartment.Count().ToString();
        }
    }
}
