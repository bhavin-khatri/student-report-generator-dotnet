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
    public partial class AddReport : Form
    {
        SqlConnection con;
        SqlDataAdapter adp;
        DataTable dt;
        public AddReport()
        {
            InitializeComponent();
        }


        private void pictureBox2_Click(object sender, EventArgs e)//back button
        {
            this.Hide();
            Add_veiw a2 = new Add_veiw();
            a2.Show();
        }

        private void Add_Report_Load(object sender, EventArgs e)
        {
            
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            fillsemester();
            string con = ConfigurationManager.ConnectionStrings["srgcon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Student", con);
            dt = new DataTable();
            adp.Fill(dt);
            AddReportdataGridView.DataSource = dt;
            
        }

        private void fillsemester()
        {
            string con = ConfigurationManager.ConnectionStrings["srgcon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Semester", con);
            dt = new DataTable();
            adp.Fill(dt);
            select_sem_comboBox.DataSource = dt;
            select_sem_comboBox.DisplayMember = "Sem_Id";
            select_sem_comboBox.ValueMember = "Sem_Id";
        }

        

        private void select_sem_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["srgcon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Course where sid="+select_sem_comboBox.SelectedValue, con);
            dt = new DataTable();
            adp.Fill(dt);
            select_course_comboBox.DataSource = dt;
            select_course_comboBox.DisplayMember = "Course_Name";
            select_course_comboBox.ValueMember = "Cid";
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            Enter_id_textbox.Text = "";
            Name_textbox.Text = "";
            select_course_comboBox.ResetText();
            select_sem_comboBox.ResetText();
            enter_marks.Text = "";
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["srgcon"].ConnectionString;
            adp = new SqlDataAdapter("INSERT into Student values ('" + Enter_id_textbox.Text + "','"+Name_textbox.Text+"','"+select_sem_comboBox.Text+"','"+select_course_comboBox.Text+"','"+enter_marks.Text+"')" , con);
            dt = new DataTable();
            adp.Fill(dt);
            display();
        }

        private void display()
        {
            string con = ConfigurationManager.ConnectionStrings["srgcon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Student ", con);
            dt = new DataTable();
            adp.Fill(dt);
            AddReportdataGridView.DataSource = dt;
        }

        private void Enter_id_textbox_TextChanged_1(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["srgcon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Student where Student_id='" + Enter_id_textbox.Text + "'", con);
            dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Enter_id_textbox.Text = dt.Rows[0][0].ToString();
                Name_textbox.Text = dt.Rows[0][1].ToString();
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["srgcon"].ConnectionString;
            adp = new SqlDataAdapter("UPDATE Student SET  Student_Name='" + Name_textbox.Text + "',Semester='" + select_sem_comboBox.Text + "',Course='" + select_course_comboBox.Text + "',Marks='" + enter_marks.Text + "'where Student_Id='" + Enter_id_textbox.Text+"'", con);
            dt = new DataTable();
            adp.Fill(dt);
            display();
        }

        private void AddReportdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Enter_id_textbox.Text = AddReportdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            Name_textbox.Text = AddReportdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            select_sem_comboBox.Text = AddReportdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            select_course_comboBox.Text = AddReportdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            enter_marks.Text = AddReportdataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["srgcon"].ConnectionString;
            adp = new SqlDataAdapter("DELETE from Student where Student_Id='" + Enter_id_textbox.Text + "'", con);
            dt = new DataTable();
            adp.Fill(dt);
            display();
        }
    }
}

