using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Report_Generator
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void load_Tick(object sender, EventArgs e)
        {
            load_panel.Width += 3;
            if(load_panel.Width>=600)
            {
                load.Stop();
                MAIN_LOGIN m1 = new MAIN_LOGIN();
                m1.Show();
                this.Hide();
            }
        }
    }
}
