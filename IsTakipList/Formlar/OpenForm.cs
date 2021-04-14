using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipList.Formlar
{
    public partial class OpenForm : Form
    {
        public OpenForm()
        {
            InitializeComponent();
        }

        private void OpenForm_Load(object sender, EventArgs e)
        {
            List<AppForm> apps = new List<AppForm>();
            Type formType = typeof(Form);
            foreach(Type t in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (formType.IsAssignableFrom(t))
                {
                    apps.Add(new AppForm()
                    {
                        ID = t.FullName,
                        FormName = t.Name
                    });
                }
            }
            gridControl1.DataSource = apps;
        }
    }
}
