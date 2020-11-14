namespace Macchinine
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.FotoMacchina2 = new System.Windows.Forms.PictureBox();
            this.FotoMacchina1 = new System.Windows.Forms.PictureBox();
            this.FotoStrada = new System.Windows.Forms.PictureBox();
            this.btnAvvio = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnRivincita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FotoMacchina2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoMacchina1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoStrada)).BeginInit();
            this.SuspendLayout();
            // 
            // FotoMacchina2
            // 
            this.FotoMacchina2.BackColor = System.Drawing.Color.Transparent;
            this.FotoMacchina2.Image = global::Macchinine.Properties.Resources.macchina2;
            this.FotoMacchina2.Location = new System.Drawing.Point(12, 265);
            this.FotoMacchina2.Name = "FotoMacchina2";
            this.FotoMacchina2.Size = new System.Drawing.Size(147, 127);
            this.FotoMacchina2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoMacchina2.TabIndex = 2;
            this.FotoMacchina2.TabStop = false;
            // 
            // FotoMacchina1
            // 
            this.FotoMacchina1.BackColor = System.Drawing.Color.Transparent;
            this.FotoMacchina1.Image = global::Macchinine.Properties.Resources.macchina1;
            this.FotoMacchina1.Location = new System.Drawing.Point(12, 92);
            this.FotoMacchina1.Name = "FotoMacchina1";
            this.FotoMacchina1.Size = new System.Drawing.Size(147, 127);
            this.FotoMacchina1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoMacchina1.TabIndex = 1;
            this.FotoMacchina1.TabStop = false;
            // 
            // FotoStrada
            // 
            this.FotoStrada.Image = global::Macchinine.Properties.Resources.SfondoMacchine;
            this.FotoStrada.Location = new System.Drawing.Point(12, 12);
            this.FotoStrada.Name = "FotoStrada";
            this.FotoStrada.Size = new System.Drawing.Size(776, 354);
            this.FotoStrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoStrada.TabIndex = 0;
            this.FotoStrada.TabStop = false;
            // 
            // btnAvvio
            // 
            this.btnAvvio.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAvvio.Font = new System.Drawing.Font("Onyx", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvvio.Location = new System.Drawing.Point(12, 372);
            this.btnAvvio.Name = "btnAvvio";
            this.btnAvvio.Size = new System.Drawing.Size(247, 57);
            this.btnAvvio.TabIndex = 3;
            this.btnAvvio.Text = "VIA";
            this.btnAvvio.UseVisualStyleBackColor = false;
            this.btnAvvio.Click += new System.EventHandler(this.BtnAvvio_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.DarkOrchid;
            this.BtnStop.Font = new System.Drawing.Font("Onyx", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.Location = new System.Drawing.Point(265, 372);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(268, 57);
            this.BtnStop.TabIndex = 4;
            this.BtnStop.Text = "STOP";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnRivincita
            // 
            this.BtnRivincita.BackColor = System.Drawing.Color.DarkOrchid;
            this.BtnRivincita.Font = new System.Drawing.Font("Onyx", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRivincita.Location = new System.Drawing.Point(539, 372);
            this.BtnRivincita.Name = "BtnRivincita";
            this.BtnRivincita.Size = new System.Drawing.Size(249, 57);
            this.BtnRivincita.TabIndex = 5;
            this.BtnRivincita.Text = "RIVINCITA";
            this.BtnRivincita.UseVisualStyleBackColor = false;
            this.BtnRivincita.Click += new System.EventHandler(this.BtnRivincita_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRivincita);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.btnAvvio);
            this.Controls.Add(this.FotoMacchina2);
            this.Controls.Add(this.FotoMacchina1);
            this.Controls.Add(this.FotoStrada);
            this.Name = "Form1";
            this.Text = "Macchinine";
            ((System.ComponentModel.ISupportInitialize)(this.FotoMacchina2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoMacchina1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoStrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FotoStrada;
        private System.Windows.Forms.PictureBox FotoMacchina1;
        private System.Windows.Forms.PictureBox FotoMacchina2;
        private System.Windows.Forms.Button btnAvvio;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnRivincita;
    }
}

