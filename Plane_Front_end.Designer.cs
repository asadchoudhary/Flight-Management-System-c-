namespace OOP_Front_End
{
    partial class Plane_Front_end
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
            this.textBoxplanename = new System.Windows.Forms.TextBox();
            this.labelplancename = new System.Windows.Forms.Label();
            this.textBoxplancecode = new System.Windows.Forms.TextBox();
            this.labelplanecode = new System.Windows.Forms.Label();
            this.textBoxplancecapacity = new System.Windows.Forms.TextBox();
            this.labelplanecapacity = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxplanename
            // 
            this.textBoxplanename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxplanename.Location = new System.Drawing.Point(282, 61);
            this.textBoxplanename.Name = "textBoxplanename";
            this.textBoxplanename.Size = new System.Drawing.Size(100, 23);
            this.textBoxplanename.TabIndex = 19;
            this.textBoxplanename.TextChanged += new System.EventHandler(this.textBoxplanename_TextChanged);
            // 
            // labelplancename
            // 
            this.labelplancename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelplancename.Location = new System.Drawing.Point(71, 61);
            this.labelplancename.Name = "labelplancename";
            this.labelplancename.Size = new System.Drawing.Size(145, 34);
            this.labelplancename.TabIndex = 18;
            this.labelplancename.Text = "Plane Name";
            // 
            // textBoxplancecode
            // 
            this.textBoxplancecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxplancecode.Location = new System.Drawing.Point(282, 119);
            this.textBoxplancecode.Name = "textBoxplancecode";
            this.textBoxplancecode.Size = new System.Drawing.Size(100, 23);
            this.textBoxplancecode.TabIndex = 21;
            // 
            // labelplanecode
            // 
            this.labelplanecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelplanecode.Location = new System.Drawing.Point(71, 108);
            this.labelplanecode.Name = "labelplanecode";
            this.labelplanecode.Size = new System.Drawing.Size(145, 34);
            this.labelplanecode.TabIndex = 20;
            this.labelplanecode.Text = "Plane Code";
            // 
            // textBoxplancecapacity
            // 
            this.textBoxplancecapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxplancecapacity.Location = new System.Drawing.Point(282, 171);
            this.textBoxplancecapacity.Name = "textBoxplancecapacity";
            this.textBoxplancecapacity.Size = new System.Drawing.Size(100, 23);
            this.textBoxplancecapacity.TabIndex = 23;
            // 
            // labelplanecapacity
            // 
            this.labelplanecapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelplanecapacity.Location = new System.Drawing.Point(71, 160);
            this.labelplanecapacity.Name = "labelplanecapacity";
            this.labelplanecapacity.Size = new System.Drawing.Size(145, 34);
            this.labelplanecapacity.TabIndex = 22;
            this.labelplanecapacity.Text = "Plane Capacity";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(364, 255);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 29);
            this.Delete.TabIndex = 25;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Plane_Front_end
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 348);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxplancecapacity);
            this.Controls.Add(this.labelplanecapacity);
            this.Controls.Add(this.textBoxplancecode);
            this.Controls.Add(this.labelplanecode);
            this.Controls.Add(this.textBoxplanename);
            this.Controls.Add(this.labelplancename);
            this.Name = "Plane_Front_end";
            this.Text = "Plane_Front_end";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxplanename;
        private System.Windows.Forms.Label labelplancename;
        private System.Windows.Forms.TextBox textBoxplancecode;
        private System.Windows.Forms.Label labelplanecode;
        private System.Windows.Forms.TextBox textBoxplancecapacity;
        private System.Windows.Forms.Label labelplanecapacity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delete;
    }
}