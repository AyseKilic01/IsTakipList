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
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }
        IsTakipListEntities db = new IsTakipListEntities();
        private void FrmPersonelIstatistik_Load(object sender, EventArgs e)
        {
            cntPersonel.Text = db.TblEmployees.Count().ToString();
            cntDepartman.Text = db.TblDepartments.Count().ToString();
            cntFirma.Text = db.Firms.Count().ToString();
            cntAktifGorev.Text = db.Tasks.Count(x => x.passive == false).ToString();
            cntPasifGorev.Text = db.Tasks.Count(x => x.passive == true).ToString();
            lblSonGorev.Text = db.Tasks.OrderByDescending(x => x.ID).Select(x => x.statement).FirstOrDefault();
            cntSehirSayisi.Text = db.Firms.Select(x => x.city).Distinct().Count().ToString();
            cntSektor.Text = db.Firms.Select(x => x.sector).Distinct().Count().ToString();

        }
    }
}
