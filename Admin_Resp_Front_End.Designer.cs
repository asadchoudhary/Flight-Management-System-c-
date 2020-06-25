namespace OOP_Front_End
{
    partial class Admin_Res
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
            this.labelflightdateadminres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelcaatt = new System.Windows.Forms.Label();
            this.labelflightdate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxCA = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Submitbtnadmin = new System.Windows.Forms.Button();
            this.labelridadmin = new System.Windows.Forms.Label();
            this.textBoxrtidadmin = new System.Windows.Forms.TextBox();
            this.labelairportlocationadmin = new System.Windows.Forms.Label();
            this.labelairportcodeadmin = new System.Windows.Forms.Label();
            this.labelairportcountryadmin = new System.Windows.Forms.Label();
            this.labelairportnameadmin = new System.Windows.Forms.Label();
            this.comboBoxairportlocationadmin = new System.Windows.Forms.ComboBox();
            this.comboBoxairportcounteryadmin = new System.Windows.Forms.ComboBox();
            this.comboBoxairportcodeadmin = new System.Windows.Forms.ComboBox();
            this.comboBoxairportnameadmin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelflightdateadminres
            // 
            this.labelflightdateadminres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelflightdateadminres.Location = new System.Drawing.Point(36, 236);
            this.labelflightdateadminres.Name = "labelflightdateadminres";
            this.labelflightdateadminres.Size = new System.Drawing.Size(100, 34);
            this.labelflightdateadminres.TabIndex = 10;
            this.labelflightdateadminres.Text = "Flight Date";
            this.labelflightdateadminres.Click += new System.EventHandler(this.labelflightdate_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "Route :";
            // 
            // labelcaatt
            // 
            this.labelcaatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcaatt.Location = new System.Drawing.Point(36, 111);
            this.labelcaatt.Name = "labelcaatt";
            this.labelcaatt.Size = new System.Drawing.Size(145, 34);
            this.labelcaatt.TabIndex = 20;
            this.labelcaatt.Text = "Cabin Attendent";
            // 
            // labelflightdate
            // 
            this.labelflightdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelflightdate.Location = new System.Drawing.Point(36, 63);
            this.labelflightdate.Name = "labelflightdate";
            this.labelflightdate.Size = new System.Drawing.Size(100, 34);
            this.labelflightdate.TabIndex = 18;
            this.labelflightdate.Text = "Pilot :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(247, 238);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Asad mushtaq",
            "Mehwish ",
            "Waseem"});
            this.comboBox1.Location = new System.Drawing.Point(247, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxCA
            // 
            this.comboBoxCA.FormattingEnabled = true;
            this.comboBoxCA.Items.AddRange(new object[] {
            "Benish Kanwal",
            "Arham Arif",
            "Iqra Abbas"});
            this.comboBoxCA.Location = new System.Drawing.Point(247, 111);
            this.comboBoxCA.Name = "comboBoxCA";
            this.comboBoxCA.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCA.TabIndex = 26;
            this.comboBoxCA.SelectedIndexChanged += new System.EventHandler(this.comboBoxCA_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "F1-34",
            "F1-35",
            "F3-45",
            "F5-55",
            "F9-363"});
            this.comboBox2.Location = new System.Drawing.Point(247, 168);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Submitbtnadmin
            // 
            this.Submitbtnadmin.Location = new System.Drawing.Point(40, 368);
            this.Submitbtnadmin.Name = "Submitbtnadmin";
            this.Submitbtnadmin.Size = new System.Drawing.Size(86, 29);
            this.Submitbtnadmin.TabIndex = 28;
            this.Submitbtnadmin.Text = "Submit";
            this.Submitbtnadmin.UseVisualStyleBackColor = true;
            this.Submitbtnadmin.Click += new System.EventHandler(this.Submitbtnadmin_Click);
            // 
            // labelridadmin
            // 
            this.labelridadmin.AutoSize = true;
            this.labelridadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelridadmin.Location = new System.Drawing.Point(480, 58);
            this.labelridadmin.Name = "labelridadmin";
            this.labelridadmin.Size = new System.Drawing.Size(82, 24);
            this.labelridadmin.TabIndex = 39;
            this.labelridadmin.Text = "Route ID";
            // 
            // textBoxrtidadmin
            // 
            this.textBoxrtidadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxrtidadmin.Location = new System.Drawing.Point(790, 58);
            this.textBoxrtidadmin.Name = "textBoxrtidadmin";
            this.textBoxrtidadmin.Size = new System.Drawing.Size(135, 23);
            this.textBoxrtidadmin.TabIndex = 38;
            this.textBoxrtidadmin.TextChanged += new System.EventHandler(this.textBoxrtidadmin_TextChanged);
            // 
            // labelairportlocationadmin
            // 
            this.labelairportlocationadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelairportlocationadmin.Location = new System.Drawing.Point(480, 263);
            this.labelairportlocationadmin.Name = "labelairportlocationadmin";
            this.labelairportlocationadmin.Size = new System.Drawing.Size(145, 34);
            this.labelairportlocationadmin.TabIndex = 46;
            this.labelairportlocationadmin.Text = "Airport Location";
            // 
            // labelairportcodeadmin
            // 
            this.labelairportcodeadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelairportcodeadmin.Location = new System.Drawing.Point(480, 210);
            this.labelairportcodeadmin.Name = "labelairportcodeadmin";
            this.labelairportcodeadmin.Size = new System.Drawing.Size(145, 34);
            this.labelairportcodeadmin.TabIndex = 44;
            this.labelairportcodeadmin.Text = "Airport Code";
            // 
            // labelairportcountryadmin
            // 
            this.labelairportcountryadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelairportcountryadmin.Location = new System.Drawing.Point(480, 158);
            this.labelairportcountryadmin.Name = "labelairportcountryadmin";
            this.labelairportcountryadmin.Size = new System.Drawing.Size(145, 34);
            this.labelairportcountryadmin.TabIndex = 42;
            this.labelairportcountryadmin.Text = "Airpot Country";
            // 
            // labelairportnameadmin
            // 
            this.labelairportnameadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelairportnameadmin.Location = new System.Drawing.Point(480, 111);
            this.labelairportnameadmin.Name = "labelairportnameadmin";
            this.labelairportnameadmin.Size = new System.Drawing.Size(145, 34);
            this.labelairportnameadmin.TabIndex = 40;
            this.labelairportnameadmin.Text = "Airport Name";
            // 
            // comboBoxairportlocationadmin
            // 
            this.comboBoxairportlocationadmin.FormattingEnabled = true;
            this.comboBoxairportlocationadmin.Items.AddRange(new object[] {
            "Lahore",
            "Multan",
            "Sargodha",
            "Karachi",
            "Islamabad"});
            this.comboBoxairportlocationadmin.Location = new System.Drawing.Point(790, 263);
            this.comboBoxairportlocationadmin.Name = "comboBoxairportlocationadmin";
            this.comboBoxairportlocationadmin.Size = new System.Drawing.Size(135, 21);
            this.comboBoxairportlocationadmin.TabIndex = 51;
            // 
            // comboBoxairportcounteryadmin
            // 
            this.comboBoxairportcounteryadmin.FormattingEnabled = true;
            this.comboBoxairportcounteryadmin.Items.AddRange(new object[] {
            "Pakistan",
            "USA",
            "UK",
            "France",
            "UAE"});
            this.comboBoxairportcounteryadmin.Location = new System.Drawing.Point(790, 168);
            this.comboBoxairportcounteryadmin.Name = "comboBoxairportcounteryadmin";
            this.comboBoxairportcounteryadmin.Size = new System.Drawing.Size(135, 21);
            this.comboBoxairportcounteryadmin.TabIndex = 50;
            // 
            // comboBoxairportcodeadmin
            // 
            this.comboBoxairportcodeadmin.FormattingEnabled = true;
            this.comboBoxairportcodeadmin.Items.AddRange(new object[] {
            "F28",
            "F34",
            "F88",
            "F32",
            "F21"});
            this.comboBoxairportcodeadmin.Location = new System.Drawing.Point(790, 215);
            this.comboBoxairportcodeadmin.Name = "comboBoxairportcodeadmin";
            this.comboBoxairportcodeadmin.Size = new System.Drawing.Size(135, 21);
            this.comboBoxairportcodeadmin.TabIndex = 49;
            // 
            // comboBoxairportnameadmin
            // 
            this.comboBoxairportnameadmin.FormattingEnabled = true;
            this.comboBoxairportnameadmin.Items.AddRange(new object[] {
            "Allama Iqabla International Airport",
            "Quaid Azam International Airport",
            " Benazeer Bhutto International Airport",
            "PIA International Airport"});
            this.comboBoxairportnameadmin.Location = new System.Drawing.Point(790, 124);
            this.comboBoxairportnameadmin.Name = "comboBoxairportnameadmin";
            this.comboBoxairportnameadmin.Size = new System.Drawing.Size(135, 21);
            this.comboBoxairportnameadmin.TabIndex = 48;
            // 
            // Admin_Res
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 482);
            this.Controls.Add(this.comboBoxairportlocationadmin);
            this.Controls.Add(this.comboBoxairportcounteryadmin);
            this.Controls.Add(this.comboBoxairportcodeadmin);
            this.Controls.Add(this.comboBoxairportnameadmin);
            this.Controls.Add(this.labelairportlocationadmin);
            this.Controls.Add(this.labelairportcodeadmin);
            this.Controls.Add(this.labelairportcountryadmin);
            this.Controls.Add(this.labelairportnameadmin);
            this.Controls.Add(this.labelridadmin);
            this.Controls.Add(this.textBoxrtidadmin);
            this.Controls.Add(this.Submitbtnadmin);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBoxCA);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelcaatt);
            this.Controls.Add(this.labelflightdate);
            this.Controls.Add(this.labelflightdateadminres);
            this.Name = "Admin_Res";
            this.Text = "Admin_Res";
            this.Load += new System.EventHandler(this.Admin_Res_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelflightdateadminres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelcaatt;
        private System.Windows.Forms.Label labelflightdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxCA;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Submitbtnadmin;
        private System.Windows.Forms.Label labelridadmin;
        private System.Windows.Forms.TextBox textBoxrtidadmin;
        private System.Windows.Forms.Label labelairportlocationadmin;
        private System.Windows.Forms.Label labelairportcodeadmin;
        private System.Windows.Forms.Label labelairportcountryadmin;
        private System.Windows.Forms.Label labelairportnameadmin;
        private System.Windows.Forms.ComboBox comboBoxairportlocationadmin;
        private System.Windows.Forms.ComboBox comboBoxairportcounteryadmin;
        private System.Windows.Forms.ComboBox comboBoxairportcodeadmin;
        private System.Windows.Forms.ComboBox comboBoxairportnameadmin;
    }
}