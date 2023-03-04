namespace Tiketv1._0
{
    partial class FrmTiket
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
            this.dgvGosti = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.cboIme = new System.Windows.Forms.ComboBox();
            this.txtPrikazGosta = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.txtPozicija = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnObrisi2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGosti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGosti
            // 
            this.dgvGosti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGosti.Location = new System.Drawing.Point(12, 12);
            this.dgvGosti.Name = "dgvGosti";
            this.dgvGosti.RowHeadersWidth = 51;
            this.dgvGosti.RowTemplate.Height = 24;
            this.dgvGosti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGosti.Size = new System.Drawing.Size(1008, 299);
            this.dgvGosti.TabIndex = 2;
            this.dgvGosti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGosti_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDodaj.Location = new System.Drawing.Point(685, 351);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(137, 30);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj gosta";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnObrisi.Location = new System.Drawing.Point(842, 375);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(168, 30);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obriši rezervaciju";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIzmjeni.Location = new System.Drawing.Point(685, 403);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(137, 30);
            this.btnIzmjeni.TabIndex = 6;
            this.btnIzmjeni.Text = "Izmjeni rezervaciju";
            this.btnIzmjeni.UseVisualStyleBackColor = false;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPretrazi.Location = new System.Drawing.Point(12, 335);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(92, 16);
            this.lblPretrazi.TabIndex = 8;
            this.lblPretrazi.Text = "Pretraži gosta:";
            // 
            // cboIme
            // 
            this.cboIme.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cboIme.FormattingEnabled = true;
            this.cboIme.Location = new System.Drawing.Point(110, 332);
            this.cboIme.Name = "cboIme";
            this.cboIme.Size = new System.Drawing.Size(121, 24);
            this.cboIme.TabIndex = 9;
            this.cboIme.SelectedIndexChanged += new System.EventHandler(this.cboIme_SelectedIndexChanged);
            // 
            // txtPrikazGosta
            // 
            this.txtPrikazGosta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPrikazGosta.Location = new System.Drawing.Point(351, 329);
            this.txtPrikazGosta.Name = "txtPrikazGosta";
            this.txtPrikazGosta.Size = new System.Drawing.Size(165, 22);
            this.txtPrikazGosta.TabIndex = 10;
            // 
            // txtOIB
            // 
            this.txtOIB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtOIB.Location = new System.Drawing.Point(351, 359);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(165, 22);
            this.txtOIB.TabIndex = 11;
            // 
            // txtVrsta
            // 
            this.txtVrsta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtVrsta.Location = new System.Drawing.Point(351, 391);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(165, 22);
            this.txtVrsta.TabIndex = 12;
            // 
            // txtPozicija
            // 
            this.txtPozicija.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPozicija.Location = new System.Drawing.Point(351, 419);
            this.txtPozicija.Name = "txtPozicija";
            this.txtPozicija.Size = new System.Drawing.Size(165, 22);
            this.txtPozicija.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(237, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ime i prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(237, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "OIB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(237, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Vrsta smještaja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(227, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Pozicija smještaja:";
            // 
            // btnObrisi2
            // 
            this.btnObrisi2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnObrisi2.Location = new System.Drawing.Point(533, 375);
            this.btnObrisi2.Name = "btnObrisi2";
            this.btnObrisi2.Size = new System.Drawing.Size(95, 30);
            this.btnObrisi2.TabIndex = 18;
            this.btnObrisi2.Text = "Obriši";
            this.btnObrisi2.UseVisualStyleBackColor = false;
            this.btnObrisi2.Click += new System.EventHandler(this.btnObrisi2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(740, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "ili";
            // 
            // FrmTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnObrisi2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPozicija);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.txtPrikazGosta);
            this.Controls.Add(this.cboIme);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvGosti);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTiket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTiket_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGosti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGosti;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.ComboBox cboIme;
        private System.Windows.Forms.TextBox txtPrikazGosta;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.TextBox txtPozicija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnObrisi2;
        private System.Windows.Forms.Label label5;
    }
}

