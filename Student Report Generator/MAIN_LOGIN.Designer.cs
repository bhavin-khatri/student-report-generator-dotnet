namespace Student_Report_Generator
{
    partial class MAIN_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN_LOGIN));
            this.sys_name = new System.Windows.Forms.Label();
            this.LOGIN_BOX = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_icon = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LOGIN_BOX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sys_name
            // 
            this.sys_name.AutoSize = true;
            this.sys_name.BackColor = System.Drawing.Color.Transparent;
            this.sys_name.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sys_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.sys_name.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sys_name.Location = new System.Drawing.Point(200, 146);
            this.sys_name.Name = "sys_name";
            this.sys_name.Size = new System.Drawing.Size(490, 35);
            this.sys_name.TabIndex = 0;
            this.sys_name.Text = "STUDENT REPORT GENERATOR";
            // 
            // LOGIN_BOX
            // 
            this.LOGIN_BOX.BackColor = System.Drawing.Color.Transparent;
            this.LOGIN_BOX.Controls.Add(this.label1);
            this.LOGIN_BOX.Controls.Add(this.admin_icon);
            this.LOGIN_BOX.Controls.Add(this.pictureBox4);
            this.LOGIN_BOX.Controls.Add(this.pictureBox3);
            this.LOGIN_BOX.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_BOX.Location = new System.Drawing.Point(179, 184);
            this.LOGIN_BOX.Name = "LOGIN_BOX";
            this.LOGIN_BOX.Size = new System.Drawing.Size(532, 289);
            this.LOGIN_BOX.TabIndex = 3;
            this.LOGIN_BOX.TabStop = false;
            this.LOGIN_BOX.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(373, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student";
            // 
            // admin_icon
            // 
            this.admin_icon.AutoSize = true;
            this.admin_icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.admin_icon.Location = new System.Drawing.Point(84, 232);
            this.admin_icon.Name = "admin_icon";
            this.admin_icon.Size = new System.Drawing.Size(88, 36);
            this.admin_icon.TabIndex = 7;
            this.admin_icon.Text = "Admin";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(335, 86);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(162, 143);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.CursorChanged += new System.EventHandler(this.groupBox1_Enter);
            this.pictureBox4.Click += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(45, 86);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(173, 143);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Student_Report_Generator.Properties.Resources.m3;
            this.pictureBox1.Location = new System.Drawing.Point(336, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MAIN_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Student_Report_Generator.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LOGIN_BOX);
            this.Controls.Add(this.sys_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MAIN_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN PAGE";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.MAIN_LOGIN_Load);
            this.CursorChanged += new System.EventHandler(this.groupBox1_Enter);
            this.LOGIN_BOX.ResumeLayout(false);
            this.LOGIN_BOX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sys_name;
        private System.Windows.Forms.GroupBox LOGIN_BOX;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label admin_icon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

