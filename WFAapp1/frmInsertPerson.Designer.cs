﻿namespace WFAapp1
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
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.lblPesel = new System.Windows.Forms.Label();
            this.txtUlicaNr = new System.Windows.Forms.TextBox();
            this.lblUlicaNr = new System.Windows.Forms.Label();
            this.txtKodMiasto = new System.Windows.Forms.TextBox();
            this.lblKodMiasto = new System.Windows.Forms.Label();
            this.txtImieNazwisko = new System.Windows.Forms.TextBox();
            this.lblImieNazwisko = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnZapiszPerson = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 63);
            this.panel1.TabIndex = 0;
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
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 442);
            this.panel2.TabIndex = 1;
            // 
            // txtPesel
            // 
            this.txtPesel.Location = new System.Drawing.Point(241, 278);
            this.txtPesel.Multiline = true;
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(440, 62);
            this.txtPesel.TabIndex = 7;
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPesel.Location = new System.Drawing.Point(53, 278);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(73, 22);
            this.lblPesel.TabIndex = 6;
            this.lblPesel.Text = "PESEL";
            // 
            // txtUlicaNr
            // 
            this.txtUlicaNr.Location = new System.Drawing.Point(241, 194);
            this.txtUlicaNr.Multiline = true;
            this.txtUlicaNr.Name = "txtUlicaNr";
            this.txtUlicaNr.Size = new System.Drawing.Size(440, 62);
            this.txtUlicaNr.TabIndex = 5;
            // 
            // lblUlicaNr
            // 
            this.lblUlicaNr.AutoSize = true;
            this.lblUlicaNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUlicaNr.Location = new System.Drawing.Point(51, 194);
            this.lblUlicaNr.Name = "lblUlicaNr";
            this.lblUlicaNr.Size = new System.Drawing.Size(101, 22);
            this.lblUlicaNr.TabIndex = 4;
            this.lblUlicaNr.Text = "ULICA NR";
            // 
            // txtKodMiasto
            // 
            this.txtKodMiasto.Location = new System.Drawing.Point(241, 114);
            this.txtKodMiasto.Multiline = true;
            this.txtKodMiasto.Name = "txtKodMiasto";
            this.txtKodMiasto.Size = new System.Drawing.Size(440, 62);
            this.txtKodMiasto.TabIndex = 3;
            // 
            // lblKodMiasto
            // 
            this.lblKodMiasto.AutoSize = true;
            this.lblKodMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKodMiasto.Location = new System.Drawing.Point(53, 114);
            this.lblKodMiasto.Name = "lblKodMiasto";
            this.lblKodMiasto.Size = new System.Drawing.Size(132, 22);
            this.lblKodMiasto.TabIndex = 2;
            this.lblKodMiasto.Text = "KOD MIASTO";
            // 
            // txtImieNazwisko
            // 
            this.txtImieNazwisko.Location = new System.Drawing.Point(242, 30);
            this.txtImieNazwisko.Multiline = true;
            this.txtImieNazwisko.Name = "txtImieNazwisko";
            this.txtImieNazwisko.Size = new System.Drawing.Size(440, 62);
            this.txtImieNazwisko.TabIndex = 1;
            // 
            // lblImieNazwisko
            // 
            this.lblImieNazwisko.AutoSize = true;
            this.lblImieNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImieNazwisko.Location = new System.Drawing.Point(53, 36);
            this.lblImieNazwisko.Name = "lblImieNazwisko";
            this.lblImieNazwisko.Size = new System.Drawing.Size(157, 22);
            this.lblImieNazwisko.TabIndex = 0;
            this.lblImieNazwisko.Text = "IMIE NAZWISKO";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Controls.Add(this.btnAnuluj);
            this.panel3.Controls.Add(this.btnZapiszPerson);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 428);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 77);
            this.panel3.TabIndex = 2;
            // 
            // btnZapiszPerson
            // 
            this.btnZapiszPerson.BackColor = System.Drawing.Color.CadetBlue;
            this.btnZapiszPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapiszPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZapiszPerson.Location = new System.Drawing.Point(43, 19);
            this.btnZapiszPerson.Name = "btnZapiszPerson";
            this.btnZapiszPerson.Size = new System.Drawing.Size(224, 46);
            this.btnZapiszPerson.TabIndex = 0;
            this.btnZapiszPerson.Text = "ZAPISZ";
            this.btnZapiszPerson.UseVisualStyleBackColor = false;
            this.btnZapiszPerson.Click += new System.EventHandler(this.btnZapiszPerson_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.BackColor = System.Drawing.Color.SlateGray;
            this.btnAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnuluj.Location = new System.Drawing.Point(442, 19);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(224, 46);
            this.btnAnuluj.TabIndex = 1;
            this.btnAnuluj.Text = "ANULUJ";
            this.btnAnuluj.UseVisualStyleBackColor = false;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "WPROWADŹ DANE NOWEJ OSOBY";
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