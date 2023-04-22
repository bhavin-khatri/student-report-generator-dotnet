using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Student_Report_Generator
{
    public partial class Student_login : Form
    {
        public static string red_studentid = "";//redirect student id
        public Student_login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MAIN_LOGIN m1 = new MAIN_LOGIN();
            m1.Show();
        }



        private void Student_login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0,0,0);
        }

        private void Login_button_Click_1(object sender, EventArgs e)
        {
            string idpattern = @"^18bsit?\d{3}$";
            string passwordpattern = @"^[A-Z]{1}?\w{4,6}?\d{2,3}$";
            if (idinputs.Text == string.Empty)
            {
                errorProvider1.SetError(idinputs, "Enter ID");
            }
            else if (Regex.IsMatch(idinputs.Text, idpattern))
            {
                errorProvider1.Clear();
                MessageBox.Show(idinputs.Text);
            }
            else
            {
                errorProvider1.SetError(idinputs, "Wrong id");
            }
            if (passwordinputs.Text == string.Empty)
            {
                errorProvider1.SetError(passwordinputs, "Enter Password");
            }
            else if (Regex.IsMatch(passwordinputs.Text, passwordpattern))
            {
                errorProvider1.Clear();
                MessageBox.Show(passwordinputs.Text);
            }
            else
            {
                errorProvider1.SetError(passwordinputs, "Wrong password");
            }
            if (Regex.IsMatch(idinputs.Text, idpattern) && Regex.IsMatch(passwordinputs.Text, passwordpattern))
            {
                red_studentid = idinputs.Text;
                this.Hide();
                ViewReport v1 = new ViewReport();
                v1.Show();
            }
            
        }

        private void hide2_Click(object sender, EventArgs e)
        {
            if (passwordinputs.PasswordChar == '\0')
            {
                hide.BringToFront();
                passwordinputs.PasswordChar = '*';
            }
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if(passwordinputs.PasswordChar=='*')
            {
                hide2.BringToFront();
                passwordinputs.PasswordChar = '\0';
            }
        }
    }
}
