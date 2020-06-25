namespace OOP_Front_End
{
    partial class Airport_Front_End
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
            this.labelairportcode = new System.Windows.Forms.Label();
            this.labelairportcountry = new System.Windows.Forms.Label();
            this.labelairportname = new System.Windows.Forms.Label();
            this.labelairportlocation = new System.Windows.Forms.Label();
            this.comboBoxairportcountery = new System.Windows.Forms.ComboBox();
            this.comboBoxairportlocation = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxairname = new System.Windows.Forms.TextBox();
            this.textBoxaircode = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelairportcode
            // 
            this.labelairportcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelairportcode.Location = new System.Drawing.Point(60, 159);
            this.labelairportcode.Name = "labelairportcode";
            this.labelairportcode.Size = new System.Drawing.Size(145, 34);
            this.labelairportcode.TabIndex = 28;
            this.labelairportcode.Text = "Airport Code";
            // 
            // labelairportcountry
            // 
            this.labelairportcountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelairportcountry.Location = new System.Drawing.Point(60, 107);
            this.labelairportcountry.Name = "labelairportcountry";
            this.labelairportcountry.Size = new System.Drawing.Size(145, 34);
            this.labelairportcountry.TabIndex = 26;
            this.labelairportcountry.Text = "Airpot Country";
            // 
            // labelairportname
            // 
            this.labelairportname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelairportname.Location = new System.Drawing.Point(60, 60);
            this.labelairportname.Name = "labelairportname";
            this.labelairportname.Size = new System.Drawing.Size(145, 34);
            this.labelairportname.TabIndex = 24;
            this.labelairportname.Text = "Airport Name";
            // 
            // labelairportlocation
            // 
            this.labelairportlocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelairportlocation.Location = new System.Drawing.Point(60, 212);
            this.labelairportlocation.Name = "labelairportlocation";
            this.labelairportlocation.Size = new System.Drawing.Size(145, 34);
            this.labelairportlocation.TabIndex = 30;
            this.labelairportlocation.Text = "Airport Location";
            // 
            // comboBoxairportcountery
            // 
            this.comboBoxairportcountery.FormattingEnabled = true;
            this.comboBoxairportcountery.Items.AddRange(new object[] {
            "Pakistan",
            "USA",
            "UK",
            "France",
            "UAE"});
            this.comboBoxairportcountery.Location = new System.Drawing.Point(271, 107);
            this.comboBoxairportcountery.Name = "comboBoxairportcountery";
            this.comboBoxairportcountery.Size = new System.Drawing.Size(121, 21);
            this.comboBoxairportcountery.TabIndex = 34;
            this.comboBoxairportcountery.SelectedIndexChanged += new System.EventHandler(this.comboBoxairportcountery_SelectedIndexChanged);
            // 
            // comboBoxairportlocation
            // 
            this.comboBoxairportlocation.FormattingEnabled = true;
            this.comboBoxairportlocation.Items.AddRange(new object[] {
            "Lahore",
            "Multan",
            "Sargodha",
            "Karachi",
            "Islamabad"});
            this.comboBoxairportlocation.Location = new System.Drawing.Point(271, 212);
            this.comboBoxairportlocation.Name = "comboBoxairportlocation";
            this.comboBoxairportlocation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxairportlocation.TabIndex = 35;
            this.comboBoxairportlocation.SelectedIndexChanged += new System.EventHandler(this.comboBoxairportlocation_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(64, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 31);
            this.button1.TabIndex = 36;
            this.button1.Text = "Add Airport";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxairname
            // 
            this.textBoxairname.Location = new System.Drawing.Point(271, 60);
            this.textBoxairname.Name = "textBoxairname";
            this.textBoxairname.Size = new System.Drawing.Size(121, 20);
            this.textBoxairname.TabIndex = 37;
            this.textBoxairname.TextChanged += new System.EventHandler(this.textBoxairname_TextChanged);
            // 
            // textBoxaircode
            // 
            this.textBoxaircode.Location = new System.Drawing.Point(271, 164);
            this.textBoxaircode.Name = "textBoxaircode";
            this.textBoxaircode.Size = new System.Drawing.Size(121, 20);
            this.textBoxaircode.TabIndex = 38;
            this.textBoxaircode.TextChanged += new System.EventHandler(this.textBoxaircode_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(330, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 31);
            this.button2.TabIndex = 39;
            this.button2.Text = "Delete Airport";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Airport_Front_End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 354);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxaircode);
            this.Controls.Add(this.textBoxairname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxairportlocation);
            this.Controls.Add(this.comboBoxairportcountery);
            this.Controls.Add(this.labelairportlocation);
            this.Controls.Add(this.labelairportcode);
            this.Controls.Add(this.labelairportcountry);
            this.Controls.Add(this.labelairportname);
            this.Name = "Airport_Front_End";
            this.Text = "Airport_Front_End";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelairportcode;
        private System.Windows.Forms.Label labelairportcountry;
        private System.Windows.Forms.Label labelairportname;
        private System.Windows.Forms.Label labelairportlocation;
        private System.Windows.Forms.ComboBox comboBoxairportcountery;
        private System.Windows.Forms.ComboBox comboBoxairportlocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxairname;
        private System.Windows.Forms.TextBox textBoxaircode;
        private System.Windows.Forms.Button button2;
    }
}