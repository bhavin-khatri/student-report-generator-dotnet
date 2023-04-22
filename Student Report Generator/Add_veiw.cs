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
    public partial class Add_veiw : Form
    {
        public Add_veiw()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)//backbutton
        {
            this.Hide();
            Admin_login a1 = new Admin_login();
            a1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)//adddatabutton
        {
            this.Hide();
            AddReport ar = new AddReport();
            ar.Show();
        }

        private void Add_veiw_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            textBox1.Text = Admin_login.red_adminid;
        }

        private void label1_Click(object sender, EventArgs e)//adddatalable
        {
            this.Hide();
            AddReport ar = new AddReport();
            ar.Show();
        }

    }
}
