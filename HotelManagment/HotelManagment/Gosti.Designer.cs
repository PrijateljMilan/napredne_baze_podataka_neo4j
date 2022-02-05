namespace HotelManagment
{
    partial class Gosti
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
            this.btnIzadji = new System.Windows.Forms.Button();
            this.pregledGostijuListView = new System.Windows.Forms.ListView();
            this.idKolona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imeKolona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezimeKolona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sobaKolona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brojTelefonaKolona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailKolona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dokumentKolona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIzadji
            // 
            this.btnIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.Location = new System.Drawing.Point(626, 505);
            this.btnIzadji.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(140, 40);
            this.btnIzadji.TabIndex = 12;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // pregledGostijuListView
            // 
            this.pregledGostijuListView.AutoArrange = false;
            this.pregledGostijuListView.BackColor = System.Drawing.Color.White;
            this.pregledGostijuListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idKolona,
            this.imeKolona,
            this.prezimeKolona,
            this.sobaKolona,
            this.brojTelefonaKolona,
            this.emailKolona,
            this.dokumentKolona});
            this.pregledGostijuListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregledGostijuListView.ForeColor = System.Drawing.Color.White;
            this.pregledGostijuListView.FullRowSelect = true;
            this.pregledGostijuListView.GridLines = true;
            this.pregledGostijuListView.HideSelection = false;
            this.pregledGostijuListView.Location = new System.Drawing.Point(12, 13);
            this.pregledGostijuListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pregledGostijuListView.Name = "pregledGostijuListView";
            this.pregledGostijuListView.Size = new System.Drawing.Size(744, 484);
            this.pregledGostijuListView.TabIndex = 10;
            this.pregledGostijuListView.UseCompatibleStateImageBehavior = false;
            this.pregledGostijuListView.View = System.Windows.Forms.View.Details;
            // 
            // idKolona
            // 
            this.idKolona.Text = "Id";
            this.idKolona.Width = 0;
            // 
            // imeKolona
            // 
            this.imeKolona.Text = "Ime";
            this.imeKolona.Width = 115;
            // 
            // prezimeKolona
            // 
            this.prezimeKolona.Text = "Prezime";
            this.prezimeKolona.Width = 117;
            // 
            // sobaKolona
            // 
            this.sobaKolona.Text = "Soba";
            this.sobaKolona.Width = 83;
            // 
            // brojTelefonaKolona
            // 
            this.brojTelefonaKolona.Text = "Broj telefona";
            this.brojTelefonaKolona.Width = 103;
            // 
            // emailKolona
            // 
            this.emailKolona.Text = "E-mail";
            this.emailKolona.Width = 155;
            // 
            // dokumentKolona
            // 
            this.dokumentKolona.Text = "Dokument";
            this.dokumentKolona.Width = 166;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisi.Location = new System.Drawing.Point(158, 505);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(140, 40);
            this.btnIzbrisi.TabIndex = 9;
            this.btnIzbrisi.Text = "Izbrisi";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(12, 505);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(140, 40);
            this.btnAzuriraj.TabIndex = 8;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // Gosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(175)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(778, 558);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.pregledGostijuListView);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gosti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gosti";
            this.Load += new System.EventHandler(this.Gosti_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.ListView pregledGostijuListView;
        private System.Windows.Forms.ColumnHeader idKolona;
        private System.Windows.Forms.ColumnHeader imeKolona;
        private System.Windows.Forms.ColumnHeader prezimeKolona;
        private System.Windows.Forms.ColumnHeader sobaKolona;
        private System.Windows.Forms.ColumnHeader brojTelefonaKolona;
        private System.Windows.Forms.ColumnHeader emailKolona;
        private System.Windows.Forms.ColumnHeader dokumentKolona;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnAzuriraj;
    }
}