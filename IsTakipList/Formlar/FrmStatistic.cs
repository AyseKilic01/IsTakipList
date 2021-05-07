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
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }
        WorkFollow db = new WorkFollow();
        private void FrmPersonelIstatistik_Load(object sender, EventArgs e)
        {
            cntPersonel.Text = db.TblEmployee.Count().ToString();
            cntDepartman.Text = db.TblDepartment.Count().ToString();
            cntFirma.Text = db.TblFirmList.Count().ToString();
            cntAktifGorev.Text = db.TblTask.Count(x => x.passive == false).ToString();
            cntPasifGorev.Text = db.TblTask.Count(x => x.passive == true).ToString();
            lblSonGorev.Text = db.TblTask.OrderByDescending(x => x.ID).Select(x => x.statement).FirstOrDefault();
            cntSehirSayisi.Text = db.TblFirmList.Select(x => x.city).Distinct().Count().ToString();
            cntSektor.Text = db.TblFirmList.Select(x => x.sector).Distinct().Count().ToString();

        }
    }
}
