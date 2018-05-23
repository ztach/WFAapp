namespace WFAapp1
{
    partial class frmInsertPerson
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnZapiszPerson = new System.Windows.Forms.Button();
            this.lblImieNazwisko = new System.Windows.Forms.Label();
            this.txtImieNazwisko = new System.Windows.Forms.TextBox();
            this.txtKodMiasto = new System.Windows.Forms.TextBox();
            this.lblKodMiasto = new System.Windows.Forms.Label();
            this.txtUlicaNr = new System.Windows.Forms.TextBox();
            this.lblUlicaNr = new System.Windows.Forms.Label();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.lblPesel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 63);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPesel);
            this.panel2.Controls.Add(this.lblPesel);
            this.panel2.Controls.Add(this.txtUlicaNr);
            this.panel2.Controls.Add(this.lblUlicaNr);
            this.panel2.Controls.Add(this.txtKodMiasto);
            this.panel2.Controls.Add(this.lblKodMiasto);
            this.panel2.Controls.Add(this.txtImieNazwisko);
            this.panel2.Controls.Add(this.lblImieNazwisko);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 442);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnZapiszPerson);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 428);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 77);
            this.panel3.TabIndex = 2;
            // 
            // btnZapiszPerson
            // 
            this.btnZapiszPerson.Location = new System.Drawing.Point(180, 19);
            this.btnZapiszPerson.Name = "btnZapiszPerson";
            this.btnZapiszPerson.Size = new System.Drawing.Size(360, 46);
            this.btnZapiszPerson.TabIndex = 0;
            this.btnZapiszPerson.Text = "ZAPISZ";
            this.btnZapiszPerson.UseVisualStyleBackColor = true;
            this.btnZapiszPerson.Click += new System.EventHandler(this.btnZapiszPerson_Click);
            // 
            // lblImieNazwisko
            // 
            this.lblImieNazwisko.AutoSize = true;
            this.lblImieNazwisko.Location = new System.Drawing.Point(59, 36);
            this.lblImieNazwisko.Name = "lblImieNazwisko";
            this.lblImieNazwisko.Size = new System.Drawing.Size(132, 20);
            this.lblImieNazwisko.TabIndex = 0;
            this.lblImieNazwisko.Text = "IMIE NAZWISKO";
            // 
            // txtImieNazwisko
            // 
            this.txtImieNazwisko.Location = new System.Drawing.Point(208, 30);
            this.txtImieNazwisko.Multiline = true;
            this.txtImieNazwisko.Name = "txtImieNazwisko";
            this.txtImieNazwisko.Size = new System.Drawing.Size(440, 62);
            this.txtImieNazwisko.TabIndex = 1;
            // 
            // txtKodMiasto
            // 
            this.txtKodMiasto.Location = new System.Drawing.Point(207, 114);
            this.txtKodMiasto.Multiline = true;
            this.txtKodMiasto.Name = "txtKodMiasto";
            this.txtKodMiasto.Size = new System.Drawing.Size(440, 62);
            this.txtKodMiasto.TabIndex = 3;
            // 
            // lblKodMiasto
            // 
            this.lblKodMiasto.AutoSize = true;
            this.lblKodMiasto.Location = new System.Drawing.Point(59, 114);
            this.lblKodMiasto.Name = "lblKodMiasto";
            this.lblKodMiasto.Size = new System.Drawing.Size(108, 20);
            this.lblKodMiasto.TabIndex = 2;
            this.lblKodMiasto.Text = "KOD MIASTO";
            // 
            // txtUlicaNr
            // 
            this.txtUlicaNr.Location = new System.Drawing.Point(207, 194);
            this.txtUlicaNr.Multiline = true;
            this.txtUlicaNr.Name = "txtUlicaNr";
            this.txtUlicaNr.Size = new System.Drawing.Size(440, 62);
            this.txtUlicaNr.TabIndex = 5;
            // 
            // lblUlicaNr
            // 
            this.lblUlicaNr.AutoSize = true;
            this.lblUlicaNr.Location = new System.Drawing.Point(57, 194);
            this.lblUlicaNr.Name = "lblUlicaNr";
            this.lblUlicaNr.Size = new System.Drawing.Size(84, 20);
            this.lblUlicaNr.TabIndex = 4;
            this.lblUlicaNr.Text = "ULICA NR";
            // 
            // txtPesel
            // 
            this.txtPesel.Location = new System.Drawing.Point(207, 278);
            this.txtPesel.Multiline = true;
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(440, 62);
            this.txtPesel.TabIndex = 7;
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Location = new System.Drawing.Point(59, 278);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(61, 20);
            this.lblPesel.TabIndex = 6;
            this.lblPesel.Text = "PESEL";
            // 
            // frmInsertPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 505);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmInsertPerson";
            this.Text = "frmInsertPerson";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.TextBox txtUlicaNr;
        private System.Windows.Forms.Label lblUlicaNr;
        private System.Windows.Forms.TextBox txtKodMiasto;
        private System.Windows.Forms.Label lblKodMiasto;
        private System.Windows.Forms.TextBox txtImieNazwisko;
        private System.Windows.Forms.Label lblImieNazwisko;
        private System.Windows.Forms.Button btnZapiszPerson;
    }
}