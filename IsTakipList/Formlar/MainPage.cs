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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        WorkFollow db = new WorkFollow();
        private void MainPage_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource =(from i in  db.TblTask
                                      select new {
                                        Görev =  i.statement,
                                         Görevli = i.TblEmployee.name + " " + i.TblEmployee.surname
            }).ToList();
           
        }
    }
}
