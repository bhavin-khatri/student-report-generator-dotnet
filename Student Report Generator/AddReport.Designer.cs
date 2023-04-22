namespace Student_Report_Generator
{
    partial class AddReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReport));
            this.select_sem_comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Enterid = new System.Windows.Forms.Label();
            this.Enter_id_textbox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Insert_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.enter_marks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.select_course_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AddReportdataGridView = new System.Windows.Forms.DataGridView();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sRGDataSet2 = new Student_Report_Generator.SRGDataSet2();
            this.studentTableAdapter = new Student_Report_Generator.SRGDataSet2TableAdapters.StudentTableAdapter();
            this.viewallbutton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddReportdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRGDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewallbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // select_sem_comboBox
            // 
            this.select_sem_comboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_sem_comboBox.FormattingEnabled = true;
            this.select_sem_comboBox.Location = new System.Drawing.Point(192, 66);
            this.select_sem_comboBox.Name = "select_sem_comboBox";
            this.select_sem_comboBox.Size = new System.Drawing.Size(166, 25);
            this.select_sem_comboBox.TabIndex = 3;
            this.select_sem_comboBox.Text = "Select Semester";
            this.select_sem_comboBox.SelectionChangeCommitted += new System.EventHandler(this.select_sem_comboBox_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 4;
            // 
            // Enterid
            // 
            this.Enterid.AutoSize = true;
            this.Enterid.BackColor = System.Drawing.Color.Transparent;
            this.Enterid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enterid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.Enterid.Location = new System.Drawing.Point(14, 15);
            this.Enterid.Name = "Enterid";
            this.Enterid.Size = new System.Drawing.Size(118, 22);
            this.Enterid.TabIndex = 5;
            this.Enterid.Text = "Student ID :";
            // 
            // Enter_id_textbox
            // 
            this.Enter_id_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_id_textbox.Location = new System.Drawing.Point(192, 15);
            this.Enter_id_textbox.Name = "Enter_id_textbox";
            this.Enter_id_textbox.Size = new System.Drawing.Size(166, 24);
            this.Enter_id_textbox.TabIndex = 6;
            this.Enter_id_textbox.TextChanged += new System.EventHandler(this.Enter_id_textbox_TextChanged_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Student_Report_Generator.Properties.Resources.back_icon;
            this.pictureBox2.Location = new System.Drawing.Point(1, 512);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(355, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "STUDENT REPORT GENERATOR";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::Student_Report_Generator.Properties.Resources.m3;
            this.pictureBox3.Location = new System.Drawing.Point(415, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(664, 192);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(91, 23);
            this.deletebutton.TabIndex = 22;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Insert_button);
            this.panel1.Controls.Add(this.reset_button);
            this.panel1.Controls.Add(this.Update_button);
            this.panel1.Controls.Add(this.enter_marks);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.select_course_comboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Name_textbox);
            this.panel1.Controls.Add(this.Name);
            this.panel1.Controls.Add(this.deletebutton);
            this.panel1.Controls.Add(this.Enterid);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Enter_id_textbox);
            this.panel1.Controls.Add(this.select_sem_comboBox);
            this.panel1.Location = new System.Drawing.Point(27, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 230);
            this.panel1.TabIndex = 23;
            // 
            // Insert_button
            // 
            this.Insert_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_button.Location = new System.Drawing.Point(767, 118);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(78, 23);
            this.Insert_button.TabIndex = 31;
            this.Insert_button.Text = "INSERT";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.Location = new System.Drawing.Point(375, 192);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(91, 23);
            this.reset_button.TabIndex = 30;
            this.reset_button.Text = "RESET";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_button.Location = new System.Drawing.Point(95, 192);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(80, 23);
            this.Update_button.TabIndex = 29;
            this.Update_button.Text = "UPDATE";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // enter_marks
            // 
            this.enter_marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_marks.Location = new System.Drawing.Point(555, 118);
            this.enter_marks.Name = "enter_marks";
            this.enter_marks.Size = new System.Drawing.Size(206, 24);
            this.enter_marks.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(398, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Enter Marks :";
            // 
            // select_course_comboBox
            // 
            this.select_course_comboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_course_comboBox.FormattingEnabled = true;
            this.select_course_comboBox.Location = new System.Drawing.Point(192, 120);
            this.select_course_comboBox.Name = "select_course_comboBox";
            this.select_course_comboBox.Size = new System.Drawing.Size(166, 25);
            this.select_course_comboBox.TabIndex = 26;
            this.select_course_comboBox.Text = "Select Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(14, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Select Course :";
            // 
            // Name_textbox
            // 
            this.Name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_textbox.Location = new System.Drawing.Point(555, 14);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(206, 24);
            this.Name_textbox.TabIndex = 24;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.Color.Transparent;
            this.Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.Name.Location = new System.Drawing.Point(398, 14);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(151, 22);
            this.Name.TabIndex = 23;
            this.Name.Text = "Student Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(14, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 22);
            this.label10.TabIndex = 7;
            this.label10.Text = "Select Semester :";
            // 
            // AddReportdataGridView
            // 
            this.AddReportdataGridView.AutoGenerateColumns = false;
            this.AddReportdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddReportdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.marksDataGridViewTextBoxColumn});
            this.AddReportdataGridView.DataSource = this.studentBindingSource;
            this.AddReportdataGridView.Location = new System.Drawing.Point(27, 334);
            this.AddReportdataGridView.Name = "AddReportdataGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AddReportdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AddReportdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddReportdataGridView.Size = new System.Drawing.Size(842, 172);
            this.AddReportdataGridView.TabIndex = 23;
            this.AddReportdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddReportdataGridView_CellClick);
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.Width = 250;
            // 
            // marksDataGridViewTextBoxColumn
            // 
            this.marksDataGridViewTextBoxColumn.DataPropertyName = "Marks";
            this.marksDataGridViewTextBoxColumn.HeaderText = "Marks";
            this.marksDataGridViewTextBoxColumn.Name = "marksDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.sRGDataSet2;
            // 
            // sRGDataSet2
            // 
            this.sRGDataSet2.DataSetName = "SRGDataSet2";
            this.sRGDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // viewallbutton
            // 
            this.viewallbutton.Image = ((System.Drawing.Image)(resources.GetObject("viewallbutton.Image")));
            this.viewallbutton.Location = new System.Drawing.Point(766, 522);
            this.viewallbutton.Name = "viewallbutton";
            this.viewallbutton.Size = new System.Drawing.Size(103, 40);
            this.viewallbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewallbutton.TabIndex = 24;
            this.viewallbutton.TabStop = false;
            // 
            // AddReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Student_Report_Generator.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 572);
            this.Controls.Add(this.viewallbutton);
            this.Controls.Add(this.AddReportdataGridView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
          //  this.Name = "AddReport";
            this.Text = "AddReport";
            this.Load += new System.EventHandler(this.Add_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddReportdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRGDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewallbutton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox select_sem_comboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Enterid;
        private System.Windows.Forms.TextBox Enter_id_textbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView AddReportdataGridView;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.ComboBox select_course_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enter_marks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button Update_button;
        private SRGDataSet2 sRGDataSet2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private SRGDataSet2TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox viewallbutton;
    }
}