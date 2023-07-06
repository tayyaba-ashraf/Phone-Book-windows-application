namespace PhoneBookWindowsApplication_VisualProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Login_groupBox1 = new System.Windows.Forms.GroupBox();
            this.Email_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password_checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Password_text = new System.Windows.Forms.TextBox();
            this.UserName_text = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.UserName_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Login_groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Login_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_groupBox1
            // 
            this.Login_groupBox1.Controls.Add(this.Email_text);
            this.Login_groupBox1.Controls.Add(this.label2);
            this.Login_groupBox1.Controls.Add(this.password_checkBox1);
            this.Login_groupBox1.Controls.Add(this.button1);
            this.Login_groupBox1.Controls.Add(this.Password_text);
            this.Login_groupBox1.Controls.Add(this.UserName_text);
            this.Login_groupBox1.Controls.Add(this.password_label);
            this.Login_groupBox1.Controls.Add(this.UserName_label);
            this.Login_groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Login_groupBox1.Location = new System.Drawing.Point(294, 65);
            this.Login_groupBox1.Name = "Login_groupBox1";
            this.Login_groupBox1.Size = new System.Drawing.Size(437, 323);
            this.Login_groupBox1.TabIndex = 0;
            this.Login_groupBox1.TabStop = false;
            this.Login_groupBox1.Text = "          LOGIN IN";
            // 
            // Email_text
            // 
            this.Email_text.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_text.Location = new System.Drawing.Point(124, 34);
            this.Email_text.Name = "Email_text";
            this.Email_text.Size = new System.Drawing.Size(282, 33);
            this.Email_text.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "EMAIL:";
            // 
            // password_checkBox1
            // 
            this.password_checkBox1.AutoSize = true;
            this.password_checkBox1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_checkBox1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.password_checkBox1.Location = new System.Drawing.Point(135, 162);
            this.password_checkBox1.Name = "password_checkBox1";
            this.password_checkBox1.Size = new System.Drawing.Size(185, 24);
            this.password_checkBox1.TabIndex = 5;
            this.password_checkBox1.Text = "SHOW PASSWORD";
            this.password_checkBox1.UseVisualStyleBackColor = true;
            this.password_checkBox1.CheckedChanged += new System.EventHandler(this.password_checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(66, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 101);
            this.button1.TabIndex = 3;
            this.button1.Text = "                      LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Password_text
            // 
            this.Password_text.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_text.Location = new System.Drawing.Point(124, 78);
            this.Password_text.Name = "Password_text";
            this.Password_text.Size = new System.Drawing.Size(282, 33);
            this.Password_text.TabIndex = 1;
            this.Password_text.UseSystemPasswordChar = true;
            // 
            // UserName_text
            // 
            this.UserName_text.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_text.Location = new System.Drawing.Point(124, 123);
            this.UserName_text.Name = "UserName_text";
            this.UserName_text.Size = new System.Drawing.Size(282, 33);
            this.UserName_text.TabIndex = 2;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.password_label.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(5, 92);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(110, 19);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "PASSWORD :";
            this.password_label.Click += new System.EventHandler(this.password_label_Click);
            // 
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserName_label.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_label.Location = new System.Drawing.Point(5, 137);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(111, 19);
            this.UserName_label.TabIndex = 0;
            this.UserName_label.Text = "USERNAME :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(240, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN FORM";
            // 
            // Login_pictureBox1
            // 
            this.Login_pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.Login_pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("Login_pictureBox1.Image")));
            this.Login_pictureBox1.Location = new System.Drawing.Point(12, 94);
            this.Login_pictureBox1.Name = "Login_pictureBox1";
            this.Login_pictureBox1.Size = new System.Drawing.Size(276, 294);
            this.Login_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Login_pictureBox1.TabIndex = 2;
            this.Login_pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Red;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(385, 419);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(263, 19);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<<<<<Not Registered yet ?? Please SignUp>>>>";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.DarkViolet;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(760, 457);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Login_pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Login_groupBox1.ResumeLayout(false);
            this.Login_groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Login_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Login_groupBox1;
        private System.Windows.Forms.TextBox Password_text;
        private System.Windows.Forms.TextBox UserName_text;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label UserName_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox password_checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Login_pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox Email_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}

