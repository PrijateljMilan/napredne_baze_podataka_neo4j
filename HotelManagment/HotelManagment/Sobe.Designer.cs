namespace HotelManagment
{
    partial class Sobe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvSobe = new System.Windows.Forms.DataGridView();
            this.broj_prostorije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brok_kreveta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSobe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzadji
            // 
            this.btnIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.Location = new System.Drawing.Point(489, 308);
            this.btnIzadji.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(121, 51);
            this.btnIzadji.TabIndex = 31;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(139, 308);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(121, 51);
            this.btnObrisi.TabIndex = 19;
            this.btnObrisi.Text = "Obrisi ";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(12, 309);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(121, 51);
            this.btnDodaj.TabIndex = 18;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvSobe
            // 
            this.dgvSobe.AllowUserToAddRows = false;
            this.dgvSobe.AllowUserToDeleteRows = false;
            this.dgvSobe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSobe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSobe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.broj_prostorije,
            this.sprat,
            this.brok_kreveta,
            this.cena,
            this.klima,
            this.terasa});
            this.dgvSobe.Location = new System.Drawing.Point(12, 12);
            this.dgvSobe.MultiSelect = false;
            this.dgvSobe.Name = "dgvSobe";
            this.dgvSobe.ReadOnly = true;
            this.dgvSobe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSobe.Size = new System.Drawing.Size(598, 288);
            this.dgvSobe.TabIndex = 32;
            // 
            // broj_prostorije
            // 
            this.broj_prostorije.HeaderText = "Broj prostorije";
            this.broj_prostorije.Name = "broj_prostorije";
            this.broj_prostorije.ReadOnly = true;
            this.broj_prostorije.Width = 120;
            // 
            // sprat
            // 
            this.sprat.HeaderText = "Sprat";
            this.sprat.Name = "sprat";
            this.sprat.ReadOnly = true;
            this.sprat.Width = 50;
            // 
            // brok_kreveta
            // 
            this.brok_kreveta.HeaderText = "Broj kreveta";
            this.brok_kreveta.Name = "brok_kreveta";
            this.brok_kreveta.ReadOnly = true;
            this.brok_kreveta.Width = 120;
            // 
            // cena
            // 
            this.cena.HeaderText = "Cena";
            this.cena.Name = "cena";
            this.cena.ReadOnly = true;
            // 
            // klima
            // 
            this.klima.HeaderText = "Klima";
            this.klima.Name = "klima";
            this.klima.ReadOnly = true;
            this.klima.Width = 80;
            // 
            // terasa
            // 
            this.terasa.HeaderText = "Terasa";
            this.terasa.Name = "terasa";
            this.terasa.ReadOnly = true;
            this.terasa.Width = 80;
            // 
            // Sobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(175)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(624, 373);
            this.Controls.Add(this.dgvSobe);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sobe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobe";
            this.Load += new System.EventHandler(this.Sobe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSobe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvSobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn broj_prostorije;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprat;
        private System.Windows.Forms.DataGridViewTextBoxColumn brok_kreveta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn klima;
        private System.Windows.Forms.DataGridViewTextBoxColumn terasa;
    }
}