namespace cara_coroa
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
            this.rbCara = new System.Windows.Forms.RadioButton();
            this.rbCoroa = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbCara
            // 
            this.rbCara.AutoSize = true;
            this.rbCara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCara.Location = new System.Drawing.Point(144, 50);
            this.rbCara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCara.Name = "rbCara";
            this.rbCara.Size = new System.Drawing.Size(61, 24);
            this.rbCara.TabIndex = 0;
            this.rbCara.TabStop = true;
            this.rbCara.Text = "Cara";
            this.rbCara.UseVisualStyleBackColor = true;
            // 
            // rbCoroa
            // 
            this.rbCoroa.AutoSize = true;
            this.rbCoroa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCoroa.Location = new System.Drawing.Point(362, 50);
            this.rbCoroa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCoroa.Name = "rbCoroa";
            this.rbCoroa.Size = new System.Drawing.Size(70, 24);
            this.rbCoroa.TabIndex = 1;
            this.rbCoroa.TabStop = true;
            this.rbCoroa.Text = "Coroa";
            this.rbCoroa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(206, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "JOGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pct
            // 
            this.pct.Location = new System.Drawing.Point(206, 89);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(150, 140);
            this.pct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct.TabIndex = 3;
            this.pct.TabStop = false;
            this.pct.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbCoroa);
            this.Controls.Add(this.rbCara);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rbCara;
        private System.Windows.Forms.RadioButton rbCoroa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pct;
    }
}

