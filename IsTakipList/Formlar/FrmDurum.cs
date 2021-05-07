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
    public partial class FrmDurum : Form
    {
        public FrmDurum()
        {
            InitializeComponent();
        }
        WorkFollow db = new WorkFollow();
        private void FrmDurum_Load(object sender, EventArgs e)
        {
            var value = (from x in db.TblStatus
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
