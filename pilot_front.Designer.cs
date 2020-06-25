namespace OOP_Front_End
{
    partial class pilot_front
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
            this.comboboxcamalefemale = new System.Windows.Forms.ComboBox();
            this.labelgender = new System.Windows.Forms.Label();
            this.textBoxcacionfo = new System.Windows.Forms.TextBox();
            this.labelcinfo = new System.Windows.Forms.Label();
            this.textBoxcacnic = new System.Windows.Forms.TextBox();
            this.labelcnic = new System.Windows.Forms.Label();
            this.textBoxcaage = new System.Windows.Forms.TextBox();
            this.labelage = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.textBoxcaaddress = new System.Windows.Forms.TextBox();
            this.labelcaaddress = new System.Windows.Forms.Label();
            this.Experience = new System.Windows.Forms.Label();
            this.textBoxcaname = new System.Windows.Forms.TextBox();
            this.labelcaname = new System.Windows.Forms.Label();
            this.textBoxexperience = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboboxcamalefemale
            // 
            this.comboboxcamalefemale.FormattingEnabled = true;
            this.comboboxcamalefemale.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboboxcamalefemale.Location = new System.Drawing.Point(649, 107);
            this.comboboxcamalefemale.Name = "comboboxcamalefemale";
            this.comboboxcamalefemale.Size = new System.Drawing.Size(132, 21);
            this.comboboxcamalefemale.TabIndex = 67;
            this.comboboxcamalefemale.SelectedIndexChanged += new System.EventHandler(this.comboboxcamalefemale_SelectedIndexChanged);
            // 
            // labelgender
            // 
            this.labelgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgender.Location = new System.Drawing.Point(457, 107);
            this.labelgender.Name = "labelgender";
            this.labelgender.Size = new System.Drawing.Size(120, 33);
            this.labelgender.TabIndex = 66;
            this.labelgender.Text = "Gender";
            // 
            // textBoxcacionfo
            // 
            this.textBoxcacionfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcacionfo.Location = new System.Drawing.Point(649, 65);
            this.textBoxcacionfo.Name = "textBoxcacionfo";
            this.textBoxcacionfo.Size = new System.Drawing.Size(132, 23);
            this.textBoxcacionfo.TabIndex = 65;
            this.textBoxcacionfo.TextChanged += new System.EventHandler(this.textBoxcacionfo_TextChanged);
            // 
            // labelcinfo
            // 
            this.labelcinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcinfo.Location = new System.Drawing.Point(457, 62);
            this.labelcinfo.Name = "labelcinfo";
            this.labelcinfo.Size = new System.Drawing.Size(167, 33);
            this.labelcinfo.TabIndex = 64;
            this.labelcinfo.Text = "Contact Info";
            // 
            // textBoxcacnic
            // 
            this.textBoxcacnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcacnic.Location = new System.Drawing.Point(235, 155);
            this.textBoxcacnic.Name = "textBoxcacnic";
            this.textBoxcacnic.Size = new System.Drawing.Size(132, 23);
            this.textBoxcacnic.TabIndex = 63;
            this.textBoxcacnic.TextChanged += new System.EventHandler(this.textBoxcacnic_TextChanged);
            // 
            // labelcnic
            // 
            this.labelcnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcnic.Location = new System.Drawing.Point(46, 152);
            this.labelcnic.Name = "labelcnic";
            this.labelcnic.Size = new System.Drawing.Size(100, 33);
            this.labelcnic.TabIndex = 62;
            this.labelcnic.Text = "CNIC";
            // 
            // textBoxcaage
            // 
            this.textBoxcaage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcaage.Location = new System.Drawing.Point(235, 204);
            this.textBoxcaage.Name = "textBoxcaage";
            this.textBoxcaage.Size = new System.Drawing.Size(132, 23);
            this.textBoxcaage.TabIndex = 61;
            this.textBoxcaage.TextChanged += new System.EventHandler(this.textBoxcaage_TextChanged);
            // 
            // labelage
            // 
            this.labelage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelage.Location = new System.Drawing.Point(46, 201);
            this.labelage.Name = "labelage";
            this.labelage.Size = new System.Drawing.Size(100, 33);
            this.labelage.TabIndex = 60;
            this.labelage.Text = "Age";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(423, 272);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(86, 29);
            this.delete.TabIndex = 59;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Submitbtncainfo_Click);
            // 
            // textBoxcaaddress
            // 
            this.textBoxcaaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcaaddress.Location = new System.Drawing.Point(235, 107);
            this.textBoxcaaddress.Name = "textBoxcaaddress";
            this.textBoxcaaddress.Size = new System.Drawing.Size(132, 23);
            this.textBoxcaaddress.TabIndex = 57;
            this.textBoxcaaddress.TextChanged += new System.EventHandler(this.textBoxcaaddress_TextChanged);
            // 
            // labelcaaddress
            // 
            this.labelcaaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcaaddress.Location = new System.Drawing.Point(46, 104);
            this.labelcaaddress.Name = "labelcaaddress";
            this.labelcaaddress.Size = new System.Drawing.Size(120, 33);
            this.labelcaaddress.TabIndex = 56;
            this.labelcaaddress.Text = "Address";
            // 
            // Experience
            // 
            this.Experience.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Experience.Location = new System.Drawing.Point(457, 152);
            this.Experience.Name = "Experience";
            this.Experience.Size = new System.Drawing.Size(100, 33);
            this.Experience.TabIndex = 55;
            this.Experience.Text = "Experience";
            // 
            // textBoxcaname
            // 
            this.textBoxcaname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcaname.Location = new System.Drawing.Point(235, 62);
            this.textBoxcaname.Name = "textBoxcaname";
            this.textBoxcaname.Size = new System.Drawing.Size(132, 23);
            this.textBoxcaname.TabIndex = 54;
            this.textBoxcaname.TextChanged += new System.EventHandler(this.textBoxcaname_TextChanged);
            // 
            // labelcaname
            // 
            this.labelcaname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcaname.Location = new System.Drawing.Point(46, 59);
            this.labelcaname.Name = "labelcaname";
            this.labelcaname.Size = new System.Drawing.Size(100, 33);
            this.labelcaname.TabIndex = 53;
            this.labelcaname.Text = "Name";
            // 
            // textBoxexperience
            // 
            this.textBoxexperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxexperience.Location = new System.Drawing.Point(649, 155);
            this.textBoxexperience.Name = "textBoxexperience";
            this.textBoxexperience.Size = new System.Drawing.Size(132, 23);
            this.textBoxexperience.TabIndex = 68;
            this.textBoxexperience.TextChanged += new System.EventHandler(this.textBoxexperience_TextChanged);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(305, 272);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(86, 29);
            this.update.TabIndex = 69;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(550, 272);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(105, 29);
            this.search.TabIndex = 70;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(178, 272);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(86, 29);
            this.submit.TabIndex = 71;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button3_Click);
            // 
            // pilot_front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 369);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.search);
            this.Controls.Add(this.update);
            this.Controls.Add(this.textBoxexperience);
            this.Controls.Add(this.comboboxcamalefemale);
            this.Controls.Add(this.labelgender);
            this.Controls.Add(this.textBoxcacionfo);
            this.Controls.Add(this.labelcinfo);
            this.Controls.Add(this.textBoxcacnic);
            this.Controls.Add(this.labelcnic);
            this.Controls.Add(this.textBoxcaage);
            this.Controls.Add(this.labelage);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.textBoxcaaddress);
            this.Controls.Add(this.labelcaaddress);
            this.Controls.Add(this.Experience);
            this.Controls.Add(this.textBoxcaname);
            this.Controls.Add(this.labelcaname);
            this.Name = "pilot_front";
            this.Text = "pilot_front";
            this.Load += new System.EventHandler(this.pilot_front_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboboxcamalefemale;
        private System.Windows.Forms.Label labelgender;
        public System.Windows.Forms.TextBox textBoxcacionfo;
        private System.Windows.Forms.Label labelcinfo;
        public System.Windows.Forms.TextBox textBoxcacnic;
        private System.Windows.Forms.Label labelcnic;
        public System.Windows.Forms.TextBox textBoxcaage;
        private System.Windows.Forms.Label labelage;
        private System.Windows.Forms.Button delete;
        public System.Windows.Forms.TextBox textBoxcaaddress;
        private System.Windows.Forms.Label labelcaaddress;
        private System.Windows.Forms.Label Experience;
        public System.Windows.Forms.TextBox textBoxcaname;
        private System.Windows.Forms.Label labelcaname;
        public System.Windows.Forms.TextBox textBoxexperience;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button submit;

    }
}