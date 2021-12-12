namespace Ukol2_pole_Csharp
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cisloN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vypispole = new System.Windows.Forms.ListBox();
            this.generovani = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vypis_prumeru = new System.Windows.Forms.Label();
            this.vypis_maxima = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cisloN
            // 
            this.cisloN.Location = new System.Drawing.Point(12, 38);
            this.cisloN.Name = "cisloN";
            this.cisloN.Size = new System.Drawing.Size(87, 20);
            this.cisloN.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kolik chceš\r\ngenerovat čísel ?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vypispole
            // 
            this.vypispole.FormattingEnabled = true;
            this.vypispole.Location = new System.Drawing.Point(105, 9);
            this.vypispole.Name = "vypispole";
            this.vypispole.Size = new System.Drawing.Size(120, 95);
            this.vypispole.TabIndex = 22;
            // 
            // generovani
            // 
            this.generovani.Location = new System.Drawing.Point(12, 64);
            this.generovani.Name = "generovani";
            this.generovani.Size = new System.Drawing.Size(87, 40);
            this.generovani.TabIndex = 23;
            this.generovani.Text = "Generuj";
            this.generovani.UseVisualStyleBackColor = true;
            this.generovani.Click += new System.EventHandler(this.generovani_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Průměr čísel v ListBoxu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Maximum z čísel menších\r\nnebo rovno průměru:";
            // 
            // vypis_prumeru
            // 
            this.vypis_prumeru.AutoSize = true;
            this.vypis_prumeru.Location = new System.Drawing.Point(174, 111);
            this.vypis_prumeru.Name = "vypis_prumeru";
            this.vypis_prumeru.Size = new System.Drawing.Size(0, 13);
            this.vypis_prumeru.TabIndex = 26;
            this.vypis_prumeru.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vypis_maxima
            // 
            this.vypis_maxima.AutoSize = true;
            this.vypis_maxima.Location = new System.Drawing.Point(174, 139);
            this.vypis_maxima.Name = "vypis_maxima";
            this.vypis_maxima.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vypis_maxima.Size = new System.Drawing.Size(0, 13);
            this.vypis_maxima.TabIndex = 27;
            this.vypis_maxima.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(237, 163);
            this.Controls.Add(this.vypis_maxima);
            this.Controls.Add(this.vypis_prumeru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generovani);
            this.Controls.Add(this.vypispole);
            this.Controls.Add(this.cisloN);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Úkol2 pole C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cisloN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox vypispole;
        private System.Windows.Forms.Button generovani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label vypis_prumeru;
        private System.Windows.Forms.Label vypis_maxima;
    }
}

