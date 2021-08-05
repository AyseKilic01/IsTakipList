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
    public partial class FrmStatus : Form
    {
        public FrmStatus()
        {
            InitializeComponent();
        }
        IsTakiplistEntites db = new IsTakiplistEntites();
        private void FrmDurum_Load(object sender, EventArgs e)
        {
            var value = (from x in db.Status
                         select new
                         {
                             x.ID,
                             Açıklama = x.statement,
                             Görev = x.isTask,
                             Pasif = x.passive

                         }).ToList();
            gridControl1.DataSource = value;
            

        }
    }
}
