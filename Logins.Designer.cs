namespace OOP_Front_End
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_reset = new System.Windows.Forms.Button();
            this.textBox1usernameres = new System.Windows.Forms.TextBox();
            this.textBox1passwordres = new System.Windows.Forms.TextBox();
            this.label1username = new System.Windows.Forms.Label();
            this.label1password = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonloginadmin = new System.Windows.Forms.Button();
            this.labeladminname = new System.Windows.Forms.Label();
            this.labeladminpass = new System.Windows.Forms.Label();
            this.buttonresetadmin = new System.Windows.Forms.Button();
            this.textBoxadminusername = new System.Windows.Forms.TextBox();
            this.textBoxpassadmin = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(210, 176);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(123, 34);
            this.btn_reset.TabIndex = 0;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // textBox1usernameres
            // 
            this.textBox1usernameres.Location = new System.Drawing.Point(210, 45);
            this.textBox1usernameres.Name = "textBox1usernameres";
            this.textBox1usernameres.Size = new System.Drawing.Size(123, 30);
            this.textBox1usernameres.TabIndex = 1;
            this.textBox1usernameres.TextChanged += new System.EventHandler(this.textBox1username_TextChanged);
            // 
            // textBox1passwordres
            // 
            this.textBox1passwordres.Location = new System.Drawing.Point(210, 114);
            this.textBox1passwordres.Name = "textBox1passwordres";
            this.textBox1passwordres.PasswordChar = '*';
            this.textBox1passwordres.Size = new System.Drawing.Size(123, 30);
            this.textBox1passwordres.TabIndex = 4;
            // 
            // label1username
            // 
            this.label1username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1username.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1username.Location = new System.Drawing.Point(16, 42);
            this.label1username.Name = "label1username";
            this.label1username.Size = new System.Drawing.Size(198, 37);
            this.label1username.TabIndex = 6;
            this.label1username.Text = "User Name";
            this.label1username.Click += new System.EventHandler(this.label1username_Click);
            // 
            // label1password
            // 
            this.label1password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1password.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1password.Location = new System.Drawing.Point(16, 102);
            this.label1password.Name = "label1password";
            this.label1password.Size = new System.Drawing.Size(143, 35);
            this.label1password.TabIndex = 7;
            this.label1password.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1username);
            this.groupBox1.Controls.Add(this.label1password);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.textBox1usernameres);
            this.groupBox1.Controls.Add(this.btn_submit);
            this.groupBox1.Controls.Add(this.textBox1passwordres);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(759, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 301);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign In";
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Image = global::OOP_Front_End.Properties.Resources.sign_check_icon;
            this.btn_submit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_submit.Location = new System.Drawing.Point(22, 176);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(107, 34);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Login";
            this.btn_submit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonloginadmin);
            this.groupBox2.Controls.Add(this.labeladminname);
            this.groupBox2.Controls.Add(this.labeladminpass);
            this.groupBox2.Controls.Add(this.buttonresetadmin);
            this.groupBox2.Controls.Add(this.textBoxadminusername);
            this.groupBox2.Controls.Add(this.textBoxpassadmin);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 301);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sign In";
            // 
            // buttonloginadmin
            // 
            this.buttonloginadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonloginadmin.Image = global::OOP_Front_End.Properties.Resources.sign_check_icon;
            this.buttonloginadmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonloginadmin.Location = new System.Drawing.Point(22, 176);
            this.buttonloginadmin.Name = "buttonloginadmin";
            this.buttonloginadmin.Size = new System.Drawing.Size(107, 34);
            this.buttonloginadmin.TabIndex = 8;
            this.buttonloginadmin.Text = "Login";
            this.buttonloginadmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonloginadmin.UseVisualStyleBackColor = true;
            this.buttonloginadmin.Click += new System.EventHandler(this.buttonloginadmin_Click);
            // 
            // labeladminname
            // 
            this.labeladminname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladminname.ForeColor = System.Drawing.Color.GreenYellow;
            this.labeladminname.Location = new System.Drawing.Point(16, 42);
            this.labeladminname.Name = "labeladminname";
            this.labeladminname.Size = new System.Drawing.Size(198, 37);
            this.labeladminname.TabIndex = 6;
            this.labeladminname.Text = "User Name";
            // 
            // labeladminpass
            // 
            this.labeladminpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladminpass.ForeColor = System.Drawing.Color.GreenYellow;
            this.labeladminpass.Location = new System.Drawing.Point(16, 102);
            this.labeladminpass.Name = "labeladminpass";
            this.labeladminpass.Size = new System.Drawing.Size(143, 35);
            this.labeladminpass.TabIndex = 7;
            this.labeladminpass.Text = "Password";
            // 
            // buttonresetadmin
            // 
            this.buttonresetadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonresetadmin.Location = new System.Drawing.Point(210, 176);
            this.buttonresetadmin.Name = "buttonresetadmin";
            this.buttonresetadmin.Size = new System.Drawing.Size(123, 34);
            this.buttonresetadmin.TabIndex = 0;
            this.buttonresetadmin.Text = "Reset";
            this.buttonresetadmin.UseVisualStyleBackColor = true;
            this.buttonresetadmin.Click += new System.EventHandler(this.buttonresetadmin_Click);
            // 
            // textBoxadminusername
            // 
            this.textBoxadminusername.Location = new System.Drawing.Point(210, 45);
            this.textBoxadminusername.Name = "textBoxadminusername";
            this.textBoxadminusername.Size = new System.Drawing.Size(123, 30);
            this.textBoxadminusername.TabIndex = 1;
            this.textBoxadminusername.TextChanged += new System.EventHandler(this.textBoxadminusername_TextChanged);
            // 
            // textBoxpassadmin
            // 
            this.textBoxpassadmin.Location = new System.Drawing.Point(210, 115);
            this.textBoxpassadmin.Name = "textBoxpassadmin";
            this.textBoxpassadmin.PasswordChar = '*';
            this.textBoxpassadmin.Size = new System.Drawing.Size(123, 30);
            this.textBoxpassadmin.TabIndex = 4;
            this.textBoxpassadmin.TextChanged += new System.EventHandler(this.textBoxpassadmin_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOP_Front_End.Properties.Resources.admin;
            this.pictureBox2.Location = new System.Drawing.Point(34, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 115);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_Front_End.Properties.Resources.picres1;
            this.pictureBox1.Location = new System.Drawing.Point(880, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 115);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1234, 643);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox textBox1usernameres;
        private System.Windows.Forms.TextBox textBox1passwordres;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label1username;
        private System.Windows.Forms.Label label1password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labeladminname;
        private System.Windows.Forms.Label labeladminpass;
        private System.Windows.Forms.Button buttonresetadmin;
        private System.Windows.Forms.TextBox textBoxadminusername;
        private System.Windows.Forms.TextBox textBoxpassadmin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonloginadmin;
    }
}

