namespace Student_Report_Generator
{
    partial class ViewAll
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
            this.VIewAlldataGridView = new System.Windows.Forms.DataGridView();
            this.IDlabel = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.findbutton = new System.Windows.Forms.Button();
            this.semlabel = new System.Windows.Forms.Label();
            this.sem_comboBox = new System.Windows.Forms.ComboBox();
            this.editbutton = new System.Windows.Forms.Button();
            this.sRGDataSet4 = new Student_Report_Generator.SRGDataSet4();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Student_Report_Generator.SRGDataSet4TableAdapters.StudentTableAdapter();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VIewAlldataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRGDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VIewAlldataGridView
            // 
            this.VIewAlldataGridView.AutoGenerateColumns = false;
            this.VIewAlldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VIewAlldataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.marksDataGridViewTextBoxColumn});
            this.VIewAlldataGridView.DataSource = this.studentBindingSource;
            this.VIewAlldataGridView.Location = new System.Drawing.Point(12, 62);
            this.VIewAlldataGridView.Name = "VIewAlldataGridView";
            this.VIewAlldataGridView.Size = new System.Drawing.Size(776, 376);
            this.VIewAlldataGridView.TabIndex = 0;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(25, 13);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(38, 20);
            this.IDlabel.TabIndex = 1;
            this.IDlabel.Text = "ID :";
            // 
            // idtextBox
            // 
            this.idtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtextBox.Location = new System.Drawing.Point(69, 9);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(161, 24);
            this.idtextBox.TabIndex = 2;
            // 
            // findbutton
            // 
            this.findbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findbutton.Location = new System.Drawing.Point(547, 6);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(66, 27);
            this.findbutton.TabIndex = 3;
            this.findbutton.Text = "Find";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // semlabel
            // 
            this.semlabel.AutoSize = true;
            this.semlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semlabel.Location = new System.Drawing.Point(265, 13);
            this.semlabel.Name = "semlabel";
            this.semlabel.Size = new System.Drawing.Size(55, 20);
            this.semlabel.TabIndex = 4;
            this.semlabel.Text = "Sem :";
            // 
            // sem_comboBox
            // 
            this.sem_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sem_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sem_comboBox.FormattingEnabled = true;
            this.sem_comboBox.Location = new System.Drawing.Point(326, 11);
            this.sem_comboBox.Name = "sem_comboBox";
            this.sem_comboBox.Size = new System.Drawing.Size(104, 26);
            this.sem_comboBox.TabIndex = 5;
            // 
            // editbutton
            // 
            this.editbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.Location = new System.Drawing.Point(698, 8);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(66, 27);
            this.editbutton.TabIndex = 6;
            this.editbutton.Text = "EDIT";
            this.editbutton.UseVisualStyleBackColor = true;
            // 
            // sRGDataSet4
            // 
            this.sRGDataSet4.DataSetName = "SRGDataSet4";
            this.sRGDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.sRGDataSet4;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.Width = 125;
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
            // ViewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.sem_comboBox);
            this.Controls.Add(this.semlabel);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.VIewAlldataGridView);
            this.Name = "ViewAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAll";
            this.Load += new System.EventHandler(this.ViewAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VIewAlldataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRGDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VIewAlldataGridView;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.Label semlabel;
        private System.Windows.Forms.ComboBox sem_comboBox;
        private System.Windows.Forms.Button editbutton;
        private SRGDataSet4 sRGDataSet4;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private SRGDataSet4TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksDataGridViewTextBoxColumn;
    }
}