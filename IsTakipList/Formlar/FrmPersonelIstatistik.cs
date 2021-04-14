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
    public partial class FrmPersonelIstatistik : Form
    {
        public FrmPersonelIstatistik()
        {
            InitializeComponent();
        }
        IsTakipListEntities db = new IsTakipListEntities();
        private void FrmPersonelIstatistik_Load(object sender, EventArgs e)
        {
            cntPersonel.Text = db.TblPersonel.Count().ToString();
            cntDepartman.Text = db.TblDepartman.Count().ToString();
            cntFirma.Text = db.TblFirmalar.Count().ToString();
            cntAktifGorev.Text = db.TblGorev.Count(x => x.Pasif == false).ToString();
            cntPasifGorev.Text = db.TblGorev.Count(x => x.Pasif == true).ToString();
            lblSonGorev.Text = db.TblGorev.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault();
            cntSehirSayisi.Text = db.TblFirmalar.Select(x => x.il).Distinct().Count().ToString();
            cntSektor.Text = db.TblFirmalar.Select(x => x.Sektor).Distinct().Count().ToString();

        }
    }
}
