namespace MegaDesk_Ludgero
{
    partial class AddQuote
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.RushOrder = new System.Windows.Forms.ComboBox();
            this.Width1 = new System.Windows.Forms.NumericUpDown();
            this.Depth = new System.Windows.Forms.NumericUpDown();
            this.Drawers = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Width1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drawers)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rush order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Desktop material:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number of drawers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Desk depth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Desk width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Customer full name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quote Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // SurfaceMaterial
            // 
            this.SurfaceMaterial.FormattingEnabled = true;
            this.SurfaceMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.SurfaceMaterial.Location = new System.Drawing.Point(118, 180);
            this.SurfaceMaterial.Name = "SurfaceMaterial";
            this.SurfaceMaterial.Size = new System.Drawing.Size(71, 21);
            this.SurfaceMaterial.Sorted = true;
            this.SurfaceMaterial.TabIndex = 16;
            // 
            // RushOrder
            // 
            this.RushOrder.FormattingEnabled = true;
            this.RushOrder.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days",
            "14 Days (free)"});
            this.RushOrder.Location = new System.Drawing.Point(317, 180);
            this.RushOrder.Name = "RushOrder";
            this.RushOrder.Size = new System.Drawing.Size(71, 21);
            this.RushOrder.TabIndex = 17;
            // 
            // Width
            // 
            this.Width1.Location = new System.Drawing.Point(315, 68);
            this.Width1.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.Width1.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.Width1.Name = "Width";
            this.Width1.Size = new System.Drawing.Size(73, 20);
            this.Width1.TabIndex = 18;
            this.Width1.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});

            // 
            // Depth
            // 
            this.Depth.Location = new System.Drawing.Point(315, 125);
            this.Depth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.Depth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(73, 20);
            this.Depth.TabIndex = 19;
            this.Depth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // Drawers
            // 
            this.Drawers.Location = new System.Drawing.Point(118, 125);
            this.Drawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Drawers.Name = "Drawers";
            this.Drawers.Size = new System.Drawing.Size(71, 20);
            this.Drawers.TabIndex = 20;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.Drawers);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.Width1);
            this.Controls.Add(this.RushOrder);
            this.Controls.Add(this.SurfaceMaterial);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.Width1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SurfaceMaterial;
        private System.Windows.Forms.ComboBox RushOrder;
        private System.Windows.Forms.NumericUpDown Width1;
        private System.Windows.Forms.NumericUpDown Depth;
        private System.Windows.Forms.NumericUpDown Drawers;
    }
}