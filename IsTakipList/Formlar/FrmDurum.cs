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
        IsTakipListEntities db = new IsTakipListEntities();
        private void FrmDurum_Load(object sender, EventArgs e)
        {
            var deger = (from x in db.TblDurum
                         select new
                         {
                             x.ID,
                             Açıklama = x.Aciklama,
                             Görev = x.IsGorev,
                             Pasif = x.Pasif

                         }).ToList();
            gridControl1.DataSource = deger;
            

        }
    }
}
