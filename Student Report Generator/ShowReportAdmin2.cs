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
    public partial class ShowReportAdmin2 : Form
    {
        public ShowReportAdmin2()
        {
            InitializeComponent();
        }

        

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_login al = new Admin_login();
            al.Show();
        }
    }
}
