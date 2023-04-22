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
    public partial class Admin_login : Form
    {
        public static string red_adminid="";//red_admin=redirected admin id
        public Admin_login()
        {
            InitializeComponent();
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MAIN_LOGIN m1 = new MAIN_LOGIN();
            m1.Show();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string idpattern = @"^18bsit?\d{3}$";
            string passwordpattern = @"^[A-Z]{1}?\w{4,6}?\d{2,3}$";
            if(idinputa.Text==string.Empty)
            {
                errorProvider1.SetError(idinputa, "Enter ID");
            }
            else if(Regex.IsMatch(idinputa.Text, idpattern))
            {
                errorProvider1.Clear();
            //    MessageBox.Show(idinputa.Text);
            }
            else
            {
                errorProvider1.SetError(idinputa, "Wrong id");
            }
            if (passwordinputa.Text == string.Empty)
            {
                errorProvider1.SetError(passwordinputa, "Enter Password");
            }
            else if (Regex.IsMatch(passwordinputa.Text, passwordpattern))
            {
                errorProvider1.Clear();
            //    MessageBox.Show(passwordinputa.Text);
            }
            else
            {
                errorProvider1.SetError(passwordinputa, "Wrong password");
            }
            if (Regex.IsMatch(idinputa.Text, idpattern) && Regex.IsMatch(passwordinputa.Text, passwordpattern))
            {
                red_adminid = idinputa.Text;
                this.Hide();
                Add_veiw av = new Add_veiw();
                av.Show();
            }
        }

        private void hide2_Click(object sender, EventArgs e)
        {
            if(passwordinputa.PasswordChar=='\0')
            {
                hide.BringToFront();
                passwordinputa.PasswordChar = '*';
            }
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if (passwordinputa.PasswordChar == '*')
            {
                hide2.BringToFront();
                passwordinputa.PasswordChar = '\0';
            }
        }
    }
}
