namespace foto_movimento
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bola = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bola)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bola
            // 
            this.bola.Image = global::foto_movimento.Properties.Resources._7fad371a_9d12_4ca1_bd4c_2a36fa3c1021;
            this.bola.Location = new System.Drawing.Point(28, 25);
            this.bola.Margin = new System.Windows.Forms.Padding(2);
            this.bola.Name = "bola";
            this.bola.Size = new System.Drawing.Size(142, 151);
            this.bola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bola.TabIndex = 0;
            this.bola.TabStop = false;
            this.bola.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.bola);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bola;
        private System.Windows.Forms.Timer timer1;
    }
}

