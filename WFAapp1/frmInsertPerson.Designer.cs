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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.lblPesel = new System.Windows.Forms.Label();
            this.txtUlicaNr = new System.Windows.Forms.TextBox();
            this.lblUlicaNr = new System.Windows.Forms.Label();
            this.txtKodMiasto = new System.Windows.Forms.TextBox();
            this.lblKodMiasto = new System.Windows.Forms.Label();
            this.txtImieNazwisko = new System.Windows.Forms.TextBox();
            this.lblImieNazwisko = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZapiszPerson = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(130, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "WPROWADŹ DANE NOWEJ OSOBY";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtPesel);
            this.panel2.Controls.Add(this.lblPesel);
            this.panel2.Controls.Add(this.txtUlicaNr);
            this.panel2.Controls.Add(this.lblUlicaNr);
            this.panel2.Controls.Add(this.txtKodMiasto);
            this.panel2.Controls.Add(this.lblKodMiasto);
            this.panel2.Controls.Add(this.txtImieNazwisko);
            this.panel2.Controls.Add(this.lblImieNazwisko);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 354);
            this.panel2.TabIndex = 1;
            // 
            // txtPesel
            // 
            this.txtPesel.Location = new System.Drawing.Point(214, 222);
            this.txtPesel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesel.Multiline = true;
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(392, 50);
            this.txtPesel.TabIndex = 7;
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPesel.Location = new System.Drawing.Point(47, 222);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(61, 18);
            this.lblPesel.TabIndex = 6;
            this.lblPesel.Text = "PESEL";
            // 
            // txtUlicaNr
            // 
            this.txtUlicaNr.Location = new System.Drawing.Point(214, 155);
            this.txtUlicaNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUlicaNr.Multiline = true;
            this.txtUlicaNr.Name = "txtUlicaNr";
            this.txtUlicaNr.Size = new System.Drawing.Size(392, 50);
            this.txtUlicaNr.TabIndex = 5;
            // 
            // lblUlicaNr
            // 
            this.lblUlicaNr.AutoSize = true;
            this.lblUlicaNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUlicaNr.Location = new System.Drawing.Point(45, 155);
            this.lblUlicaNr.Name = "lblUlicaNr";
            this.lblUlicaNr.Size = new System.Drawing.Size(84, 18);
            this.lblUlicaNr.TabIndex = 4;
            this.lblUlicaNr.Text = "ULICA NR";
            // 
            // txtKodMiasto
            // 
            this.txtKodMiasto.Location = new System.Drawing.Point(214, 91);
            this.txtKodMiasto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodMiasto.Multiline = true;
            this.txtKodMiasto.Name = "txtKodMiasto";
            this.txtKodMiasto.Size = new System.Drawing.Size(392, 50);
            this.txtKodMiasto.TabIndex = 3;
            // 
            // lblKodMiasto
            // 
            this.lblKodMiasto.AutoSize = true;
            this.lblKodMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKodMiasto.Location = new System.Drawing.Point(47, 91);
            this.lblKodMiasto.Name = "lblKodMiasto";
            this.lblKodMiasto.Size = new System.Drawing.Size(111, 18);
            this.lblKodMiasto.TabIndex = 2;
            this.lblKodMiasto.Text = "KOD MIASTO";
            // 
            // txtImieNazwisko
            // 
            this.txtImieNazwisko.Location = new System.Drawing.Point(215, 24);
            this.txtImieNazwisko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImieNazwisko.Multiline = true;
            this.txtImieNazwisko.Name = "txtImieNazwisko";
            this.txtImieNazwisko.Size = new System.Drawing.Size(392, 50);
            this.txtImieNazwisko.TabIndex = 1;
            // 
            // lblImieNazwisko
            // 
            this.lblImieNazwisko.AutoSize = true;
            this.lblImieNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImieNazwisko.Location = new System.Drawing.Point(47, 29);
            this.lblImieNazwisko.Name = "lblImieNazwisko";
            this.lblImieNazwisko.Size = new System.Drawing.Size(133, 18);
            this.lblImieNazwisko.TabIndex = 0;
            this.lblImieNazwisko.Text = "IMIE NAZWISKO";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Controls.Add(this.btnAnuluj);
            this.panel3.Controls.Add(this.btnZapiszPerson);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 342);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 62);
            this.panel3.TabIndex = 2;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.BackColor = System.Drawing.Color.SlateGray;
            this.btnAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnuluj.Location = new System.Drawing.Point(393, 15);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(199, 37);
            this.btnAnuluj.TabIndex = 1;
            this.btnAnuluj.Text = "ANULUJ";
            this.btnAnuluj.UseVisualStyleBackColor = false;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZapiszPerson
            // 
            this.btnZapiszPerson.BackColor = System.Drawing.Color.CadetBlue;
            this.btnZapiszPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapiszPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZapiszPerson.Location = new System.Drawing.Point(38, 15);
            this.btnZapiszPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZapiszPerson.Name = "btnZapiszPerson";
            this.btnZapiszPerson.Size = new System.Drawing.Size(199, 37);
            this.btnZapiszPerson.TabIndex = 0;
            this.btnZapiszPerson.Text = "ZAPISZ";
            this.btnZapiszPerson.UseVisualStyleBackColor = false;
            this.btnZapiszPerson.Click += new System.EventHandler(this.btnZapiszPerson_Click);
            // 
            // frmInsertPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 404);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInsertPerson";
            this.Text = "frmInsertPerson";
            this.Load += new System.EventHandler(this.frmInsertPerson_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Label label1;
    }
}