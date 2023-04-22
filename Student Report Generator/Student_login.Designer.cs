namespace Student_Report_Generator
{
    partial class Student_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_login));
            this.ids = new System.Windows.Forms.Label();
            this.passwords = new System.Windows.Forms.Label();
            this.idinputs = new System.Windows.Forms.TextBox();
            this.passwordinputs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hide = new System.Windows.Forms.PictureBox();
            this.hide2 = new System.Windows.Forms.PictureBox();
            this.Login_button = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ids
            // 
            this.ids.AutoSize = true;
            this.ids.BackColor = System.Drawing.Color.Transparent;
            this.ids.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ids.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(0)))));
            this.ids.Location = new System.Drawing.Point(315, 235);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(52, 29);
            this.ids.TabIndex = 2;
            this.ids.Text = "ID :";
            // 
            // passwords
            // 
            this.passwords.AutoSize = true;
            this.passwords.BackColor = System.Drawing.Color.Transparent;
            this.passwords.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(0)))));
            this.passwords.Location = new System.Drawing.Point(225, 305);
            this.passwords.Name = "passwords";
            this.passwords.Size = new System.Drawing.Size(142, 29);
            this.passwords.TabIndex = 3;
            this.passwords.Text = "Password :";
            // 
            // idinputs
            // 
            this.idinputs.BackColor = System.Drawing.Color.Black;
            this.idinputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idinputs.ForeColor = System.Drawing.Color.White;
            this.idinputs.Location = new System.Drawing.Point(373, 235);
            this.idinputs.Name = "idinputs";
            this.idinputs.Size = new System.Drawing.Size(254, 35);
            this.idinputs.TabIndex = 5;
            // 
            // passwordinputs
            // 
            this.passwordinputs.BackColor = System.Drawing.Color.Black;
            this.passwordinputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordinputs.ForeColor = System.Drawing.Color.White;
            this.passwordinputs.Location = new System.Drawing.Point(220, 195);
            this.passwordinputs.Name = "passwordinputs";
            this.passwordinputs.PasswordChar = '*';
            this.passwordinputs.Size = new System.Drawing.Size(254, 35);
            this.passwordinputs.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(205, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "STUDENT LOGIN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Student_Report_Generator.Properties.Resources.back_icon;
            this.pictureBox2.Location = new System.Drawing.Point(1, 512);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.hide);
            this.panel1.Controls.Add(this.hide2);
            this.panel1.Controls.Add(this.Login_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.passwordinputs);
            this.panel1.Location = new System.Drawing.Point(153, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 416);
            this.panel1.TabIndex = 11;
            // 
            // hide
            // 
            this.hide.BackColor = System.Drawing.Color.White;
            this.hide.Image = ((System.Drawing.Image)(resources.GetObject("hide.Image")));
            this.hide.Location = new System.Drawing.Point(437, 195);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(37, 35);
            this.hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hide.TabIndex = 28;
            this.hide.TabStop = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // hide2
            // 
            this.hide2.BackColor = System.Drawing.Color.White;
            this.hide2.Image = ((System.Drawing.Image)(resources.GetObject("hide2.Image")));
            this.hide2.Location = new System.Drawing.Point(437, 195);
            this.hide2.Name = "hide2";
            this.hide2.Size = new System.Drawing.Size(37, 35);
            this.hide2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hide2.TabIndex = 27;
            this.hide2.TabStop = false;
            this.hide2.Click += new System.EventHandler(this.hide2_Click);
            // 
            // Login_button
            // 
            this.Login_button.Image = global::Student_Report_Generator.Properties.Resources.login_button;
            this.Login_button.Location = new System.Drawing.Point(255, 273);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(120, 37);
            this.Login_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Login_button.TabIndex = 18;
            this.Login_button.TabStop = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::Student_Report_Generator.Properties.Resources.m3;
            this.pictureBox3.Location = new System.Drawing.Point(422, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(361, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "STUDENT REPORT GENERATOR";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Student_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Student_Report_Generator.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.idinputs);
            this.Controls.Add(this.passwords);
            this.Controls.Add(this.ids);
            this.Controls.Add(this.panel1);
            this.Name = "Student_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Login";
            this.Load += new System.EventHandler(this.Student_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ids;
        private System.Windows.Forms.Label passwords;
        private System.Windows.Forms.TextBox idinputs;
        private System.Windows.Forms.TextBox passwordinputs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Login_button;
        private System.Windows.Forms.PictureBox hide2;
        private System.Windows.Forms.PictureBox hide;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

