namespace OOP_Front_End
{
    partial class Ticket_Front_End
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
            this.labelpaymentt = new System.Windows.Forms.Label();
            this.textBoxpaymebt = new System.Windows.Forms.TextBox();
            this.labelnoofpassngerst = new System.Windows.Forms.Label();
            this.textBoxnoofpassengers = new System.Windows.Forms.TextBox();
            this.labelticketnot = new System.Windows.Forms.Label();
            this.textBoxticketno = new System.Windows.Forms.TextBox();
            this.buttonticketadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tickettype = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelpaymentt
            // 
            this.labelpaymentt.AutoSize = true;
            this.labelpaymentt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpaymentt.Location = new System.Drawing.Point(295, 180);
            this.labelpaymentt.Name = "labelpaymentt";
            this.labelpaymentt.Size = new System.Drawing.Size(83, 24);
            this.labelpaymentt.TabIndex = 37;
            this.labelpaymentt.Text = "Payment";
            // 
            // textBoxpaymebt
            // 
            this.textBoxpaymebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpaymebt.Location = new System.Drawing.Point(506, 183);
            this.textBoxpaymebt.Name = "textBoxpaymebt";
            this.textBoxpaymebt.Size = new System.Drawing.Size(135, 23);
            this.textBoxpaymebt.TabIndex = 36;
            // 
            // labelnoofpassngerst
            // 
            this.labelnoofpassngerst.AutoSize = true;
            this.labelnoofpassngerst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnoofpassngerst.Location = new System.Drawing.Point(295, 135);
            this.labelnoofpassngerst.Name = "labelnoofpassngerst";
            this.labelnoofpassngerst.Size = new System.Drawing.Size(159, 24);
            this.labelnoofpassngerst.TabIndex = 35;
            this.labelnoofpassngerst.Text = "No of Passengers";
            // 
            // textBoxnoofpassengers
            // 
            this.textBoxnoofpassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnoofpassengers.Location = new System.Drawing.Point(506, 138);
            this.textBoxnoofpassengers.Name = "textBoxnoofpassengers";
            this.textBoxnoofpassengers.Size = new System.Drawing.Size(135, 23);
            this.textBoxnoofpassengers.TabIndex = 34;
            // 
            // labelticketnot
            // 
            this.labelticketnot.AutoSize = true;
            this.labelticketnot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelticketnot.Location = new System.Drawing.Point(295, 58);
            this.labelticketnot.Name = "labelticketnot";
            this.labelticketnot.Size = new System.Drawing.Size(90, 24);
            this.labelticketnot.TabIndex = 33;
            this.labelticketnot.Text = "Ticket No";
            // 
            // textBoxticketno
            // 
            this.textBoxticketno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxticketno.Location = new System.Drawing.Point(506, 58);
            this.textBoxticketno.Name = "textBoxticketno";
            this.textBoxticketno.Size = new System.Drawing.Size(135, 23);
            this.textBoxticketno.TabIndex = 32;
            this.textBoxticketno.TextChanged += new System.EventHandler(this.textBoxticketno_TextChanged);
            // 
            // buttonticketadd
            // 
            this.buttonticketadd.Location = new System.Drawing.Point(299, 250);
            this.buttonticketadd.Name = "buttonticketadd";
            this.buttonticketadd.Size = new System.Drawing.Size(93, 37);
            this.buttonticketadd.TabIndex = 40;
            this.buttonticketadd.Text = "Add ";
            this.buttonticketadd.UseVisualStyleBackColor = true;
            this.buttonticketadd.Click += new System.EventHandler(this.buttonticketadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Ticket Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tickettype
            // 
            this.tickettype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickettype.Location = new System.Drawing.Point(506, 99);
            this.tickettype.Name = "tickettype";
            this.tickettype.Size = new System.Drawing.Size(135, 23);
            this.tickettype.TabIndex = 41;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(650, 250);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(93, 37);
            this.delete.TabIndex = 43;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Ticket_Front_End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 352);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tickettype);
            this.Controls.Add(this.buttonticketadd);
            this.Controls.Add(this.labelpaymentt);
            this.Controls.Add(this.textBoxpaymebt);
            this.Controls.Add(this.labelnoofpassngerst);
            this.Controls.Add(this.textBoxnoofpassengers);
            this.Controls.Add(this.labelticketnot);
            this.Controls.Add(this.textBoxticketno);
            this.Name = "Ticket_Front_End";
            this.Text = "Ticket_Front_End";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelpaymentt;
        private System.Windows.Forms.TextBox textBoxpaymebt;
        private System.Windows.Forms.Label labelnoofpassngerst;
        private System.Windows.Forms.TextBox textBoxnoofpassengers;
        private System.Windows.Forms.Label labelticketnot;
        private System.Windows.Forms.TextBox textBoxticketno;
        private System.Windows.Forms.Button buttonticketadd;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tickettype;
        private System.Windows.Forms.Button delete;
    }
}