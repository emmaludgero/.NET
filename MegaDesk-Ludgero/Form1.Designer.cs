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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(30, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Quote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Location = new System.Drawing.Point(30, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Quotes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Location = new System.Drawing.Point(30, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Search Quotes";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Location = new System.Drawing.Point(30, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }

    partial class Desk
    {
        // Structure variables
        // Oi
        private double _width;
        private double _depth;
        private int _drawers;
        public double _surfaceArea;

        // Material variables
        public enum SurfaceMaterial
        {
            Laminate = 100,
            Oak = 200,
            Rosewood = 300,
            Veneer = 125,
            Pine = 50
        };
        private SurfaceMaterial _material;

        // Pricing variables
        private double _structurePrice;
        private double _surfaceMaterialPrice;
        private double _drawersPrice;

        public Desk(double width, double depth, int drawers, SurfaceMaterial chosenMaterial)
        {
            _width = width;
            _depth = depth;
            _drawers = drawers;
            _material = chosenMaterial;
        }


        public void CalculateStructure()
        {
            // Princing the surface area
            double baseDeskPrice = 200;
            double surfaceArea = GetSurfaceArea();
            double pricePerInch = 1;
            if (surfaceArea > 1000)
            {
                baseDeskPrice = surfaceArea * pricePerInch;
            }

            // Pricing the drawers
            if (_drawers > 0)
            {
                _drawersPrice = _drawers * 50;
            }

            // Princing the surface material
            /* 
            switch (_material)
            {
                case (SurfaceMaterial.Laminate):
                    _surfaceMaterialPrice = 100;
                    break;
                case (SurfaceMaterial.Oak):
                    _surfaceMaterialPrice = 200;
                    break;
                case (SurfaceMaterial.Pine):
                    _surfaceMaterialPrice = 50;
                    break;
                case (SurfaceMaterial.Rosewood):
                    _surfaceMaterialPrice = 300;
                    break;
                case (SurfaceMaterial.Veneer):
                    _surfaceMaterialPrice = 125;
                    break;
            } 
            */

            // Test of Surface Price
            double surfaceValue = (double)_material;

            // Total Structure Price
            if (_drawers == 0)
            {
                _structurePrice = baseDeskPrice + surfaceValue;
            }
            else
                _structurePrice = baseDeskPrice + surfaceValue + _drawersPrice;

        }

        public double GetSurfaceArea()
        {
            return _surfaceArea = _width * _depth;
        }
    }

    partial class DeskQuote
    {
        private string _name;
        public enum RushOrderOptions
        {
            Day3,
            Day5,
            Day7,
            Default14
        }
        private RushOrderOptions _chosenRushOrder = RushOrderOptions.Default14;

        
    }
}

