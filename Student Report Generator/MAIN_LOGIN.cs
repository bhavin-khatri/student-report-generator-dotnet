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
    public partial class MAIN_LOGIN : Form
    {
        public MAIN_LOGIN()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            MAIN_LOGIN f2 = new MAIN_LOGIN();
            this.Visible = false;
            Student_login f1 = new Student_login();
            f1.Show();
        }

        private void MAIN_LOGIN_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MAIN_LOGIN f2 = new MAIN_LOGIN();
            f2.Close();
            this.Visible = false;
            Admin_login f1 = new Admin_login();
            f1.Show();
        }
    }
}
