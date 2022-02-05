namespace HotelManagment
{
    partial class Rezervacije
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
            System.Windows.Forms.Label label3;
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnDodajGoste = new System.Windows.Forms.Button();
            this.lvGosti = new System.Windows.Forms.ListView();
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValidacioniDokument = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnZapamtiRezervaciju = new System.Windows.Forms.Button();
            this.btnIzracunajCenu = new System.Windows.Forms.Button();
            this.lblCena = new System.Windows.Forms.Label();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProstorija = new System.Windows.Forms.Label();
            this.cmbProstorija = new System.Windows.Forms.ComboBox();
            this.dgvProstorije = new System.Windows.Forms.DataGridView();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProstorije)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(76, 290);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 16);
            label3.TabIndex = 40;
            label3.Text = "Gosti:";
            // 
            // btnIzadji
            // 
            this.btnIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzadji.Location = new System.Drawing.Point(291, 540);
            this.btnIzadji.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(110, 50);
            this.btnIzadji.TabIndex = 48;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnDodajGoste
            // 
            this.btnDodajGoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajGoste.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodajGoste.Location = new System.Drawing.Point(121, 284);
            this.btnDodajGoste.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDodajGoste.Name = "btnDodajGoste";
            this.btnDodajGoste.Size = new System.Drawing.Size(280, 28);
            this.btnDodajGoste.TabIndex = 46;
            this.btnDodajGoste.Text = "Dodaj goste";
            this.btnDodajGoste.UseVisualStyleBackColor = true;
            this.btnDodajGoste.Click += new System.EventHandler(this.btnDodajGoste_Click);
            // 
            // lvGosti
            // 
            this.lvGosti.BackColor = System.Drawing.Color.White;
            this.lvGosti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ime,
            this.Prezime,
            this.ValidacioniDokument});
            this.lvGosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGosti.ForeColor = System.Drawing.Color.Black;
            this.lvGosti.FullRowSelect = true;
            this.lvGosti.GridLines = true;
            this.lvGosti.HideSelection = false;
            this.lvGosti.Location = new System.Drawing.Point(29, 318);
            this.lvGosti.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvGosti.Name = "lvGosti";
            this.lvGosti.Size = new System.Drawing.Size(372, 159);
            this.lvGosti.TabIndex = 45;
            this.lvGosti.UseCompatibleStateImageBehavior = false;
            this.lvGosti.View = System.Windows.Forms.View.Details;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 105;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 87;
            // 
            // ValidacioniDokument
            // 
            this.ValidacioniDokument.Text = "Validacioni dokument";
            this.ValidacioniDokument.Width = 187;
            // 
            // btnZapamtiRezervaciju
            // 
            this.btnZapamtiRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZapamtiRezervaciju.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZapamtiRezervaciju.Location = new System.Drawing.Point(29, 540);
            this.btnZapamtiRezervaciju.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnZapamtiRezervaciju.Name = "btnZapamtiRezervaciju";
            this.btnZapamtiRezervaciju.Size = new System.Drawing.Size(168, 50);
            this.btnZapamtiRezervaciju.TabIndex = 43;
            this.btnZapamtiRezervaciju.Text = "Zapamti rezervaciju";
            this.btnZapamtiRezervaciju.UseVisualStyleBackColor = true;
            this.btnZapamtiRezervaciju.Click += new System.EventHandler(this.btnZapamtiRezervaciju_Click);
            // 
            // btnIzracunajCenu
            // 
            this.btnIzracunajCenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzracunajCenu.Location = new System.Drawing.Point(29, 483);
            this.btnIzracunajCenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIzracunajCenu.Name = "btnIzracunajCenu";
            this.btnIzracunajCenu.Size = new System.Drawing.Size(110, 30);
            this.btnIzracunajCenu.TabIndex = 42;
            this.btnIzracunajCenu.Text = "Izracunaj cenu:";
            this.btnIzracunajCenu.UseVisualStyleBackColor = true;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(197, 530);
            this.lblCena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(0, 16);
            this.lblCena.TabIndex = 41;
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumDo.Location = new System.Drawing.Point(121, 49);
            this.dtpDatumDo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(253, 22);
            this.dtpDatumDo.TabIndex = 39;
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumOd.Location = new System.Drawing.Point(121, 21);
            this.dtpDatumOd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(253, 22);
            this.dtpDatumOd.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Datum do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Datum od:";
            // 
            // lblProstorija
            // 
            this.lblProstorija.AutoSize = true;
            this.lblProstorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProstorija.Location = new System.Drawing.Point(49, 80);
            this.lblProstorija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProstorija.Name = "lblProstorija";
            this.lblProstorija.Size = new System.Drawing.Size(169, 16);
            this.lblProstorija.TabIndex = 50;
            this.lblProstorija.Text = "Prikazi slobodne prostorije:";
            // 
            // cmbProstorija
            // 
            this.cmbProstorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProstorija.FormattingEnabled = true;
            this.cmbProstorija.Location = new System.Drawing.Point(234, 77);
            this.cmbProstorija.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbProstorija.Name = "cmbProstorija";
            this.cmbProstorija.Size = new System.Drawing.Size(140, 24);
            this.cmbProstorija.TabIndex = 49;
            this.cmbProstorija.SelectedIndexChanged += new System.EventHandler(this.cmbProstorija_SelectedIndexChanged);
            // 
            // dgvProstorije
            // 
            this.dgvProstorije.AllowUserToAddRows = false;
            this.dgvProstorije.AllowUserToDeleteRows = false;
            this.dgvProstorije.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProstorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProstorije.Location = new System.Drawing.Point(29, 107);
            this.dgvProstorije.Name = "dgvProstorije";
            this.dgvProstorije.ReadOnly = true;
            this.dgvProstorije.Size = new System.Drawing.Size(372, 171);
            this.dgvProstorije.TabIndex = 51;
            // 
            // Rezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(175)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(431, 616);
            this.Controls.Add(this.dgvProstorije);
            this.Controls.Add(this.lblProstorija);
            this.Controls.Add(this.cmbProstorija);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnDodajGoste);
            this.Controls.Add(this.lvGosti);
            this.Controls.Add(this.btnZapamtiRezervaciju);
            this.Controls.Add(this.btnIzracunajCenu);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(label3);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rezervacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacije";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProstorije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnDodajGoste;
        private System.Windows.Forms.ListView lvGosti;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader ValidacioniDokument;
        private System.Windows.Forms.Button btnZapamtiRezervaciju;
        private System.Windows.Forms.Button btnIzracunajCenu;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProstorija;
        private System.Windows.Forms.ComboBox cmbProstorija;
        private System.Windows.Forms.DataGridView dgvProstorije;
    }
}