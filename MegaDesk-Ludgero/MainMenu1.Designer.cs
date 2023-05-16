namespace MegaDesk_Ludgero
{
    partial class MainMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.AddQuote = new System.Windows.Forms.Button();
            this.ViewQuote = new System.Windows.Forms.Button();
            this.SearchQuotes = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddQuote
            // 
            this.AddQuote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddQuote.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddQuote.Location = new System.Drawing.Point(30, 41);
            this.AddQuote.Name = "AddQuote";
            this.AddQuote.Size = new System.Drawing.Size(154, 47);
            this.AddQuote.TabIndex = 0;
            this.AddQuote.Text = "Add Quote";
            this.AddQuote.UseVisualStyleBackColor = true;
            this.AddQuote.Click += AddQuote_Click;
            // 
            // ViewQuote
            // 
            this.ViewQuote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ViewQuote.Cursor = System.Windows.Forms.Cursors.Default;
            this.ViewQuote.Location = new System.Drawing.Point(30, 104);
            this.ViewQuote.Name = "ViewQuote";
            this.ViewQuote.Size = new System.Drawing.Size(154, 47);
            this.ViewQuote.TabIndex = 1;
            this.ViewQuote.Text = "View Quotes";
            this.ViewQuote.UseVisualStyleBackColor = true;
            this.ViewQuote.Click += ViewQuotes_Click;
            // 
            // SearchQuotes
            // 
            this.SearchQuotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SearchQuotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.SearchQuotes.Location = new System.Drawing.Point(30, 168);
            this.SearchQuotes.Name = "SearchQuotes";
            this.SearchQuotes.Size = new System.Drawing.Size(154, 47);
            this.SearchQuotes.TabIndex = 2;
            this.SearchQuotes.Text = "Search Quotes";
            this.SearchQuotes.UseVisualStyleBackColor = true;
            this.SearchQuotes.Click += SearchQuotes_Click;
            // 
            // Exit
            // 
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Default;
            this.Exit.Location = new System.Drawing.Point(30, 231);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(154, 47);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += Exit_Click;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(198, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SearchQuotes);
            this.Controls.Add(this.ViewQuote);
            this.Controls.Add(this.AddQuote);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddQuote;
        private System.Windows.Forms.Button ViewQuote;
        private System.Windows.Forms.Button SearchQuotes;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

