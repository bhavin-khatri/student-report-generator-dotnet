using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Student_Report_Generator
{
    public partial class ViewReport : Form
    {
        SqlConnection con;
        SqlDataAdapter adp;
        DataTable dt;
        public ViewReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sRGDataSet3.Student' table. You can move, or remove it, as needed.
           // this.studentTableAdapter.Fill(this.sRGDataSet3.Student);
            textBox_Id.Text = Student_login.red_studentid;
            fillsemester();
        }
        private void fillsemester()
        {
            string con = ConfigurationManager.ConnectionStrings["srgcon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Semester", con);
            dt = new DataTable();
            adp.Fill(dt);
            comboBox_Sem.DataSource = dt;
            comboBox_Sem.DisplayMember = "Sem_Id";
            comboBox_Sem.ValueMember = "Sem_Id";
        }




        private void logouts_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_login sl = new Student_login();
            sl.Show();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_login sl = new Student_login();
            sl.Show();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["srgcon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Student where Student_id='" + textBox_Id.Text + "'", con);
            dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                IDtextBox.Text = dt.Rows[0][0].ToString();
                NametextBox.Text = dt.Rows[0][1].ToString();
                
            }
            SemtextBox.Text =comboBox_Sem.Text;
            ProgrammetextBox.Text = "BSCIT";
            adp = new SqlDataAdapter("select Course,Marks from Student where Student_Id='"+ textBox_Id.Text+ "' and Semester='"+comboBox_Sem.SelectedValue+"'", con);
            dt = new DataTable();
            adp.Fill(dt);
            viewreportdataGridView.DataSource = dt;
        }
    }
}


