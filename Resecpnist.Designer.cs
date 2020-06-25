namespace OOP_Front_End
{
    partial class Resecpnist
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPassengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketToolStripMenuItem,
            this.planeToolStripMenuItem,
            this.passengerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTicketToolStripMenuItem});
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ticketToolStripMenuItem.Text = "Ticket ";
            this.ticketToolStripMenuItem.Click += new System.EventHandler(this.ticketToolStripMenuItem_Click);
            // 
            // addTicketToolStripMenuItem
            // 
            this.addTicketToolStripMenuItem.Name = "addTicketToolStripMenuItem";
            this.addTicketToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addTicketToolStripMenuItem.Text = "Add Ticket";
            this.addTicketToolStripMenuItem.Click += new System.EventHandler(this.addTicketToolStripMenuItem_Click);
            // 
            // planeToolStripMenuItem
            // 
            this.planeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlaneToolStripMenuItem});
            this.planeToolStripMenuItem.Name = "planeToolStripMenuItem";
            this.planeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.planeToolStripMenuItem.Text = "Plane";
            // 
            // addPlaneToolStripMenuItem
            // 
            this.addPlaneToolStripMenuItem.Name = "addPlaneToolStripMenuItem";
            this.addPlaneToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addPlaneToolStripMenuItem.Text = "Add Plane";
            this.addPlaneToolStripMenuItem.Click += new System.EventHandler(this.addPlaneToolStripMenuItem_Click);
            // 
            // passengerToolStripMenuItem
            // 
            this.passengerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPassengerToolStripMenuItem});
            this.passengerToolStripMenuItem.Name = "passengerToolStripMenuItem";
            this.passengerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.passengerToolStripMenuItem.Text = "Passenger";
            this.passengerToolStripMenuItem.Click += new System.EventHandler(this.passengerToolStripMenuItem_Click);
            // 
            // addPassengerToolStripMenuItem
            // 
            this.addPassengerToolStripMenuItem.Name = "addPassengerToolStripMenuItem";
            this.addPassengerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addPassengerToolStripMenuItem.Text = "Add Passenger";
            this.addPassengerToolStripMenuItem.Click += new System.EventHandler(this.addPassengerToolStripMenuItem_Click);
            // 
            // Resecpnist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 343);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Resecpnist";
            this.Text = "Resecpnist";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem planeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPassengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTicketToolStripMenuItem;
    }
}