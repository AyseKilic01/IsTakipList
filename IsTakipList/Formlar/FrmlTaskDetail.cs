﻿using ITLDataAccess.Concrete;
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
    public partial class FrmlTaskDetail : Form
    {
        public FrmlTaskDetail()
        {
            InitializeComponent();
        }
        IsTakiplistEntites db = new IsTakiplistEntites();
        private void FrmGorevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Tasks
                                       select new
                                       {
                                          Açıklama = x.statement
                                       }).ToList();
            cntAktifGorev.Text = db.Tasks.Count(x => x.passive == false).ToString();
            cntPasifGorev.Text = db.Tasks.Count(x => x.passive == true).ToString();
            cntDepartman.Text = db.TblDepartments.Count().ToString();
        }
    }
}
