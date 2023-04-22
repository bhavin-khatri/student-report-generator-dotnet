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
    public partial class ViewAll : Form
    {
        SqlConnection con;
        SqlDataAdapter adp;
        DataTable dt;
        public ViewAll()
        {
            InitializeComponent();
        }

        private void ViewAll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sRGDataSet4.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.sRGDataSet4.Student);
            string con = ConfigurationManager.ConnectionStrings["srgcon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Student", con);
            dt = new DataTable();
            adp.Fill(dt);
            VIewAlldataGridView.DataSource = dt;
            //string con = ConfigurationManager.ConnectionStrings["srgcon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Semester", con);
            dt = new DataTable();
            adp.Fill(dt);
            sem_comboBox.DataSource = dt;
            sem_comboBox.DisplayMember = "Sem_Id";
            sem_comboBox.ValueMember = "Sem_Id";

        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["srgcon"].ConnectionString;
            adp = new SqlDataAdapter("select * from Student where Student_Id='"+idtextBox.Text+"'", con);
            dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count>1)
            {
                VIewAlldataGridView.DataSource = dt;
            }
            /*
            VIewAlldataGridView.DataSource = dt;
            adp = new SqlDataAdapter("select * from Student where Semester='" + sem_comboBox.Text + "'", con);
            dt = new DataTable();
            adp.Fill(dt);
            VIewAlldataGridView.DataSource = dt;
            adp = new SqlDataAdapter("select * from Student where Student_Id='" + idtextBox.Text + "' and Semester='"+sem_comboBox.Text+"'", con);
             dt = new DataTable();
             adp.Fill(dt);
             VIewAlldataGridView.DataSource = dt;*/
        }
    }
}
