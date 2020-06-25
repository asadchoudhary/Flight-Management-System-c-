namespace OOP_Front_End
{
    partial class CA_Front_End
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
            this.labelcaaddress = new System.Windows.Forms.Label();
            this.labelcashift = new System.Windows.Forms.Label();
            this.labelcaname = new System.Windows.Forms.Label();
            this.comboBoxcashift = new System.Windows.Forms.ComboBox();
            this.Submitbtncainfo = new System.Windows.Forms.Button();
            this.comboboxcamalefemale = new System.Windows.Forms.ComboBox();
            this.labelgender = new System.Windows.Forms.Label();
            this.textBoxcacionfo = new System.Windows.Forms.TextBox();
            this.labelcinfo = new System.Windows.Forms.Label();
            this.textBoxcacnic = new System.Windows.Forms.TextBox();
            this.labelcnic = new System.Windows.Forms.Label();
            this.textBoxcaage = new System.Windows.Forms.TextBox();
            this.labelage = new System.Windows.Forms.Label();
            this.textBoxcaname = new System.Windows.Forms.TextBox();
            this.textBoxcaaddress = new System.Windows.Forms.TextBox();
            this.seach = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelcaaddress
            // 
            this.labelcaaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcaaddress.Location = new System.Drawing.Point(69, 85);
            this.labelcaaddress.Name = "labelcaaddress";
            this.labelcaaddress.Size = new System.Drawing.Size(120, 33);
            this.labelcaaddress.TabIndex = 37;
            this.labelcaaddress.Text = "Address";
            this.labelcaaddress.Click += new System.EventHandler(this.labelcaaddress_Click);
            // 
            // labelcashift
            // 
            this.labelcashift.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcashift.Location = new System.Drawing.Point(525, 133);
            this.labelcashift.Name = "labelcashift";
            this.labelcashift.Size = new System.Drawing.Size(100, 33);
            this.labelcashift.TabIndex = 34;
            this.labelcashift.Text = "Shift";
            this.labelcashift.Click += new System.EventHandler(this.labelcashift_Click);
            // 
            // labelcaname
            // 
            this.labelcaname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcaname.Location = new System.Drawing.Point(69, 40);
            this.labelcaname.Name = "labelcaname";
            this.labelcaname.Size = new System.Drawing.Size(100, 33);
            this.labelcaname.TabIndex = 32;
            this.labelcaname.Text = "Name";
            this.labelcaname.Click += new System.EventHandler(this.labelcaname_Click);
            // 
            // comboBoxcashift
            // 
            this.comboBoxcashift.FormattingEnabled = true;
            this.comboBoxcashift.Items.AddRange(new object[] {
            "12-8",
            "8-4",
            "4-12"});
            this.comboBoxcashift.Location = new System.Drawing.Point(717, 138);
            this.comboBoxcashift.Name = "comboBoxcashift";
            this.comboBoxcashift.Size = new System.Drawing.Size(132, 21);
            this.comboBoxcashift.TabIndex = 39;
            this.comboBoxcashift.SelectedIndexChanged += new System.EventHandler(this.comboBoxcashift_SelectedIndexChanged);
            // 
            // Submitbtncainfo
            // 
            this.Submitbtncainfo.Location = new System.Drawing.Point(276, 260);
            this.Submitbtncainfo.Name = "Submitbtncainfo";
            this.Submitbtncainfo.Size = new System.Drawing.Size(86, 29);
            this.Submitbtncainfo.TabIndex = 40;
            this.Submitbtncainfo.Text = "Submit";
            this.Submitbtncainfo.UseVisualStyleBackColor = true;
            this.Submitbtncainfo.Click += new System.EventHandler(this.Submitbtncainfo_Click);
            // 
            // comboboxcamalefemale
            // 
            this.comboboxcamalefemale.FormattingEnabled = true;
            this.comboboxcamalefemale.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboboxcamalefemale.Location = new System.Drawing.Point(717, 88);
            this.comboboxcamalefemale.Name = "comboboxcamalefemale";
            this.comboboxcamalefemale.Size = new System.Drawing.Size(132, 21);
            this.comboboxcamalefemale.TabIndex = 52;
            this.comboboxcamalefemale.SelectedIndexChanged += new System.EventHandler(this.comboboxcamalefemale_SelectedIndexChanged);
            // 
            // labelgender
            // 
            this.labelgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgender.Location = new System.Drawing.Point(525, 88);
            this.labelgender.Name = "labelgender";
            this.labelgender.Size = new System.Drawing.Size(120, 33);
            this.labelgender.TabIndex = 51;
            this.labelgender.Text = "Gender";
            this.labelgender.Click += new System.EventHandler(this.labelgender_Click);
            // 
            // textBoxcacionfo
            // 
            this.textBoxcacionfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcacionfo.Location = new System.Drawing.Point(717, 46);
            this.textBoxcacionfo.Name = "textBoxcacionfo";
            this.textBoxcacionfo.Size = new System.Drawing.Size(132, 23);
            this.textBoxcacionfo.TabIndex = 50;
            this.textBoxcacionfo.TextChanged += new System.EventHandler(this.textBoxcacionfo_TextChanged);
            // 
            // labelcinfo
            // 
            this.labelcinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcinfo.Location = new System.Drawing.Point(525, 43);
            this.labelcinfo.Name = "labelcinfo";
            this.labelcinfo.Size = new System.Drawing.Size(167, 33);
            this.labelcinfo.TabIndex = 49;
            this.labelcinfo.Text = "Contact Info";
            this.labelcinfo.Click += new System.EventHandler(this.labelcinfo_Click);
            // 
            // textBoxcacnic
            // 
            this.textBoxcacnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcacnic.Location = new System.Drawing.Point(258, 136);
            this.textBoxcacnic.Name = "textBoxcacnic";
            this.textBoxcacnic.Size = new System.Drawing.Size(132, 23);
            this.textBoxcacnic.TabIndex = 46;
            this.textBoxcacnic.TextChanged += new System.EventHandler(this.textBoxcacnic_TextChanged);
            // 
            // labelcnic
            // 
            this.labelcnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcnic.Location = new System.Drawing.Point(69, 133);
            this.labelcnic.Name = "labelcnic";
            this.labelcnic.Size = new System.Drawing.Size(100, 33);
            this.labelcnic.TabIndex = 45;
            this.labelcnic.Text = "CNIC";
            this.labelcnic.Click += new System.EventHandler(this.labelcnic_Click);
            // 
            // textBoxcaage
            // 
            this.textBoxcaage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcaage.Location = new System.Drawing.Point(258, 185);
            this.textBoxcaage.Name = "textBoxcaage";
            this.textBoxcaage.Size = new System.Drawing.Size(132, 23);
            this.textBoxcaage.TabIndex = 44;
            this.textBoxcaage.TextChanged += new System.EventHandler(this.textBoxcaage_TextChanged);
            // 
            // labelage
            // 
            this.labelage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelage.Location = new System.Drawing.Point(69, 182);
            this.labelage.Name = "labelage";
            this.labelage.Size = new System.Drawing.Size(100, 33);
            this.labelage.TabIndex = 43;
            this.labelage.Text = "Age";
            this.labelage.Click += new System.EventHandler(this.labelage_Click);
            // 
            // textBoxcaname
            // 
            this.textBoxcaname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcaname.Location = new System.Drawing.Point(258, 43);
            this.textBoxcaname.Name = "textBoxcaname";
            this.textBoxcaname.Size = new System.Drawing.Size(132, 23);
            this.textBoxcaname.TabIndex = 33;
            this.textBoxcaname.TextChanged += new System.EventHandler(this.textBoxcaname_TextChanged);
            // 
            // textBoxcaaddress
            // 
            this.textBoxcaaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcaaddress.Location = new System.Drawing.Point(258, 88);
            this.textBoxcaaddress.Name = "textBoxcaaddress";
            this.textBoxcaaddress.Size = new System.Drawing.Size(132, 23);
            this.textBoxcaaddress.TabIndex = 38;
            this.textBoxcaaddress.TextChanged += new System.EventHandler(this.textBoxcaaddress_TextChanged);
            // 
            // seach
            // 
            this.seach.Location = new System.Drawing.Point(422, 260);
            this.seach.Name = "seach";
            this.seach.Size = new System.Drawing.Size(86, 29);
            this.seach.TabIndex = 53;
            this.seach.Text = "Search";
            this.seach.UseVisualStyleBackColor = true;
            this.seach.Click += new System.EventHandler(this.seach_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(693, 260);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(86, 29);
            this.delete.TabIndex = 54;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 55;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CA_Front_End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.seach);
            this.Controls.Add(this.comboboxcamalefemale);
            this.Controls.Add(this.labelgender);
            this.Controls.Add(this.textBoxcacionfo);
            this.Controls.Add(this.labelcinfo);
            this.Controls.Add(this.textBoxcacnic);
            this.Controls.Add(this.labelcnic);
            this.Controls.Add(this.textBoxcaage);
            this.Controls.Add(this.labelage);
            this.Controls.Add(this.Submitbtncainfo);
            this.Controls.Add(this.comboBoxcashift);
            this.Controls.Add(this.textBoxcaaddress);
            this.Controls.Add(this.labelcaaddress);
            this.Controls.Add(this.labelcashift);
            this.Controls.Add(this.textBoxcaname);
            this.Controls.Add(this.labelcaname);
            this.Name = "CA_Front_End";
            this.Text = "CA_Front_End";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelcaaddress;
        private System.Windows.Forms.Label labelcashift;
        private System.Windows.Forms.Label labelcaname;
        private System.Windows.Forms.Button Submitbtncainfo;
        private System.Windows.Forms.Label labelgender;
        private System.Windows.Forms.Label labelcinfo;
        private System.Windows.Forms.Label labelcnic;
        private System.Windows.Forms.Label labelage;
        public System.Windows.Forms.TextBox textBoxcaname;
        public System.Windows.Forms.TextBox textBoxcaaddress;
        public System.Windows.Forms.ComboBox comboboxcamalefemale;
        public System.Windows.Forms.TextBox textBoxcacionfo;
        public System.Windows.Forms.TextBox textBoxcaage;
        public System.Windows.Forms.TextBox textBoxcacnic;
        public System.Windows.Forms.ComboBox comboBoxcashift;
        private System.Windows.Forms.Button seach;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button1;

    }
}