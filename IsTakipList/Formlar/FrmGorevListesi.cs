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
        IsTakipListEntities db = new IsTakipListEntities();
        private void FrmGorevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGorev
                                       select new
                                       {
                                          Açıklama = x.Aciklama
                                       }).ToList();
            cntAktifGorev.Text = db.TblGorev.Count(x => x.Pasif == false).ToString();
            cntPasifGorev.Text = db.TblGorev.Count(x => x.Pasif == true).ToString();
            cntDepartman.Text = db.TblDepartman.Count().ToString();
        }
    }
}
