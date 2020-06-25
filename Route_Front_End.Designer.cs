namespace OOP_Front_End
{
    partial class Route_Front_End
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
            this.labelsiatancerote = new System.Windows.Forms.Label();
            this.textBoxdistance = new System.Windows.Forms.TextBox();
            this.labelstaytime = new System.Windows.Forms.Label();
            this.textBoxstaytime = new System.Windows.Forms.TextBox();
            this.labelrouteno = new System.Windows.Forms.Label();
            this.textBoxrid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelsiatancerote
            // 
            this.labelsiatancerote.AutoSize = true;
            this.labelsiatancerote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsiatancerote.Location = new System.Drawing.Point(49, 148);
            this.labelsiatancerote.Name = "labelsiatancerote";
            this.labelsiatancerote.Size = new System.Drawing.Size(250, 24);
            this.labelsiatancerote.TabIndex = 37;
            this.labelsiatancerote.Text = "Destignation Route Distance ";
            // 
            // textBoxdistance
            // 
            this.textBoxdistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdistance.Location = new System.Drawing.Point(359, 151);
            this.textBoxdistance.Name = "textBoxdistance";
            this.textBoxdistance.Size = new System.Drawing.Size(135, 23);
            this.textBoxdistance.TabIndex = 36;
            this.textBoxdistance.TextChanged += new System.EventHandler(this.textBoxdistance_TextChanged);
            // 
            // labelstaytime
            // 
            this.labelstaytime.AutoSize = true;
            this.labelstaytime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstaytime.Location = new System.Drawing.Point(49, 100);
            this.labelstaytime.Name = "labelstaytime";
            this.labelstaytime.Size = new System.Drawing.Size(93, 24);
            this.labelstaytime.TabIndex = 35;
            this.labelstaytime.Text = "Stay Time";
            // 
            // textBoxstaytime
            // 
            this.textBoxstaytime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxstaytime.Location = new System.Drawing.Point(359, 103);
            this.textBoxstaytime.Name = "textBoxstaytime";
            this.textBoxstaytime.Size = new System.Drawing.Size(135, 23);
            this.textBoxstaytime.TabIndex = 34;
            this.textBoxstaytime.TextChanged += new System.EventHandler(this.textBoxstaytime_TextChanged);
            // 
            // labelrouteno
            // 
            this.labelrouteno.AutoSize = true;
            this.labelrouteno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrouteno.Location = new System.Drawing.Point(49, 57);
            this.labelrouteno.Name = "labelrouteno";
            this.labelrouteno.Size = new System.Drawing.Size(82, 24);
            this.labelrouteno.TabIndex = 33;
            this.labelrouteno.Text = "Route ID";
            // 
            // textBoxrid
            // 
            this.textBoxrid.Location = new System.Drawing.Point(359, 57);
            this.textBoxrid.Name = "textBoxrid";
            this.textBoxrid.Size = new System.Drawing.Size(135, 20);
            this.textBoxrid.TabIndex = 38;
            this.textBoxrid.TextChanged += new System.EventHandler(this.textBoxrid_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 39;
            this.button1.Text = "Add ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(460, 220);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(93, 37);
            this.Delete.TabIndex = 40;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Route_Front_End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 477);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxrid);
            this.Controls.Add(this.labelsiatancerote);
            this.Controls.Add(this.textBoxdistance);
            this.Controls.Add(this.labelstaytime);
            this.Controls.Add(this.textBoxstaytime);
            this.Controls.Add(this.labelrouteno);
            this.Name = "Route_Front_End";
            this.Text = "Route";
            this.Load += new System.EventHandler(this.Route_Front_End_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelsiatancerote;
        private System.Windows.Forms.TextBox textBoxdistance;
        private System.Windows.Forms.Label labelstaytime;
        private System.Windows.Forms.TextBox textBoxstaytime;
        private System.Windows.Forms.Label labelrouteno;
        private System.Windows.Forms.TextBox textBoxrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delete;
    }
}