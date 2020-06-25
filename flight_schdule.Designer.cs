namespace OOP_Front_End
{
    partial class flight_schdule
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
            this.textBoxflightarrival = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.labelcashift = new System.Windows.Forms.Label();
            this.labelflightdate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxflightcapacity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxbooked = new System.Windows.Forms.TextBox();
            this.btnflightsch = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.F_name = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxflightarrival
            // 
            this.textBoxflightarrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxflightarrival.Location = new System.Drawing.Point(291, 144);
            this.textBoxflightarrival.Name = "textBoxflightarrival";
            this.textBoxflightarrival.Size = new System.Drawing.Size(200, 23);
            this.textBoxflightarrival.TabIndex = 43;
            this.textBoxflightarrival.TextChanged += new System.EventHandler(this.textBoxflightarrival_TextChanged);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(91, 141);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(120, 33);
            this.label.TabIndex = 42;
            this.label.Text = "Flight Arrival";
            // 
            // labelcashift
            // 
            this.labelcashift.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcashift.Location = new System.Drawing.Point(91, 196);
            this.labelcashift.Name = "labelcashift";
            this.labelcashift.Size = new System.Drawing.Size(137, 33);
            this.labelcashift.TabIndex = 41;
            this.labelcashift.Text = "Flight Capacity";
            // 
            // labelflightdate
            // 
            this.labelflightdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelflightdate.Location = new System.Drawing.Point(91, 98);
            this.labelflightdate.Name = "labelflightdate";
            this.labelflightdate.Size = new System.Drawing.Size(100, 33);
            this.labelflightdate.TabIndex = 39;
            this.labelflightdate.Text = "Flight Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(291, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 44;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBoxflightcapacity
            // 
            this.textBoxflightcapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxflightcapacity.Location = new System.Drawing.Point(291, 196);
            this.textBoxflightcapacity.Name = "textBoxflightcapacity";
            this.textBoxflightcapacity.Size = new System.Drawing.Size(200, 23);
            this.textBoxflightcapacity.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 33);
            this.label1.TabIndex = 46;
            this.label1.Text = "Booked ";
            // 
            // textBoxbooked
            // 
            this.textBoxbooked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxbooked.Location = new System.Drawing.Point(291, 256);
            this.textBoxbooked.Name = "textBoxbooked";
            this.textBoxbooked.Size = new System.Drawing.Size(200, 23);
            this.textBoxbooked.TabIndex = 47;
            // 
            // btnflightsch
            // 
            this.btnflightsch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnflightsch.Location = new System.Drawing.Point(262, 320);
            this.btnflightsch.Name = "btnflightsch";
            this.btnflightsch.Size = new System.Drawing.Size(75, 30);
            this.btnflightsch.TabIndex = 48;
            this.btnflightsch.Text = "Add";
            this.btnflightsch.UseVisualStyleBackColor = true;
            this.btnflightsch.Click += new System.EventHandler(this.btnflightsch_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(484, 320);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 30);
            this.delete.TabIndex = 49;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // F_name
            // 
            this.F_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_name.Location = new System.Drawing.Point(291, 45);
            this.F_name.Name = "F_name";
            this.F_name.Size = new System.Drawing.Size(200, 23);
            this.F_name.TabIndex = 51;
            this.F_name.TextChanged += new System.EventHandler(this.F_name_TextChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(91, 42);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(120, 33);
            this.name.TabIndex = 50;
            this.name.Text = "Flight Name";
            // 
            // flight_schdule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 362);
            this.Controls.Add(this.F_name);
            this.Controls.Add(this.name);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.btnflightsch);
            this.Controls.Add(this.textBoxbooked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxflightcapacity);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxflightarrival);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelcashift);
            this.Controls.Add(this.labelflightdate);
            this.Name = "flight_schdule";
            this.Text = "V";
            this.Load += new System.EventHandler(this.flight_schdule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelcashift;
        private System.Windows.Forms.Label labelflightdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxbooked;
        private System.Windows.Forms.Button btnflightsch;
        public System.Windows.Forms.TextBox textBoxflightcapacity;
        public System.Windows.Forms.TextBox textBoxflightarrival;
        private System.Windows.Forms.Button delete;
        public System.Windows.Forms.TextBox F_name;
        private System.Windows.Forms.Label name;
    }
}