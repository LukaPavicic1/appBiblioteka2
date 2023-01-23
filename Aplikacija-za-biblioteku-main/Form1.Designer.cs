namespace aplikacijaZaBiblioteku
{
    partial class Form1
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
            this.buttonKorisnik = new System.Windows.Forms.Button();
            this.buttonKnjiga = new System.Windows.Forms.Button();
            this.buttonPregledPodataka = new System.Windows.Forms.Button();
            this.buttonPosudzivanjeVracanje = new System.Windows.Forms.Button();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonKorisnik
            // 
            this.buttonKorisnik.Location = new System.Drawing.Point(34, 178);
            this.buttonKorisnik.Name = "buttonKorisnik";
            this.buttonKorisnik.Size = new System.Drawing.Size(266, 62);
            this.buttonKorisnik.TabIndex = 0;
            this.buttonKorisnik.Text = "Unesi korisnika";
            this.buttonKorisnik.UseVisualStyleBackColor = true;
            this.buttonKorisnik.Click += new System.EventHandler(this.buttonKorisnik_Click);
            // 
            // buttonKnjiga
            // 
            this.buttonKnjiga.Location = new System.Drawing.Point(34, 285);
            this.buttonKnjiga.Name = "buttonKnjiga";
            this.buttonKnjiga.Size = new System.Drawing.Size(266, 62);
            this.buttonKnjiga.TabIndex = 1;
            this.buttonKnjiga.Text = "Unesi knjigu";
            this.buttonKnjiga.UseVisualStyleBackColor = true;
            this.buttonKnjiga.Click += new System.EventHandler(this.buttonKnjiga_Click);
            // 
            // buttonPregledPodataka
            // 
            this.buttonPregledPodataka.Location = new System.Drawing.Point(399, 178);
            this.buttonPregledPodataka.Name = "buttonPregledPodataka";
            this.buttonPregledPodataka.Size = new System.Drawing.Size(266, 62);
            this.buttonPregledPodataka.TabIndex = 2;
            this.buttonPregledPodataka.Text = "Pregled podataka";
            this.buttonPregledPodataka.UseVisualStyleBackColor = true;
            // 
            // buttonPosudzivanjeVracanje
            // 
            this.buttonPosudzivanjeVracanje.Location = new System.Drawing.Point(399, 285);
            this.buttonPosudzivanjeVracanje.Name = "buttonPosudzivanjeVracanje";
            this.buttonPosudzivanjeVracanje.Size = new System.Drawing.Size(266, 62);
            this.buttonPosudzivanjeVracanje.TabIndex = 3;
            this.buttonPosudzivanjeVracanje.Text = "Posuđivanje/Vraćanje knjiga";
            this.buttonPosudzivanjeVracanje.UseVisualStyleBackColor = true;
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaslov.Location = new System.Drawing.Point(25, 50);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(405, 83);
            this.labelNaslov.TabIndex = 4;
            this.labelNaslov.Text = "Knjižnica \"Laganini\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 395);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.buttonPosudzivanjeVracanje);
            this.Controls.Add(this.buttonPregledPodataka);
            this.Controls.Add(this.buttonKnjiga);
            this.Controls.Add(this.buttonKorisnik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKorisnik;
        private System.Windows.Forms.Button buttonKnjiga;
        private System.Windows.Forms.Button buttonPregledPodataka;
        private System.Windows.Forms.Button buttonPosudzivanjeVracanje;
        private System.Windows.Forms.Label labelNaslov;
    }
}

