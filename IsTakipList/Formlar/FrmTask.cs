using DevExpress.XtraEditors;
using ITLDataAccess.Concrete;
using ITLEntity.Concrete;
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
    public partial class FrmTask : Form
    {
        public FrmTask()
        {
            InitializeComponent();
          
        }
        IsTakiplistEntites db = new IsTakiplistEntites();
        private void FrmGorev_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.TblEmployees
                                select new
                                {
                             //       x.id,
                             //       nameSurname = x.name +" "+ x.surname

                                }).ToList();
            lueGorevli.Properties.DisplayMember = "nameSurname";
            lueGorevli.Properties.ValueMember = "ID";
            lueGorevli.Properties.DataSource = degerler;
            lueYetkili.Properties.DisplayMember = "nameSurname";
            lueYetkili.Properties.ValueMember = "ID";
            lueYetkili.Properties.DataSource = degerler;

        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tasks gorevs = new Tasks();
            gorevs.statement = txtAciklama.Text;
            gorevs.employee = Int32.Parse(lueGorevli.EditValue.ToString());
            gorevs.commissioner = Int32.Parse(lueYetkili.EditValue.ToString());
            gorevs.date = DateTime.Parse(lueDate.Text);
            gorevs.statu = "1";

            db.Tasks.Add(gorevs);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni Görev Eklendi");
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
