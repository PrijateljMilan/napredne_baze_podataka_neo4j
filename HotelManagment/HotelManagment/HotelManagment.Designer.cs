namespace HotelManagment
{
    partial class HotelManagment
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
            this.btnRezervacija = new System.Windows.Forms.Button();
            this.btnSobe = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnGosti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRezervacija
            // 
            this.btnRezervacija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(168)))), ((int)(((byte)(59)))));
            this.btnRezervacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervacija.Location = new System.Drawing.Point(12, 366);
            this.btnRezervacija.Name = "btnRezervacija";
            this.btnRezervacija.Size = new System.Drawing.Size(176, 68);
            this.btnRezervacija.TabIndex = 0;
            this.btnRezervacija.Text = "Rezervacija";
            this.btnRezervacija.UseVisualStyleBackColor = false;
            this.btnRezervacija.Click += new System.EventHandler(this.btnRezervacija_Click);
            // 
            // btnSobe
            // 
            this.btnSobe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(168)))), ((int)(((byte)(59)))));
            this.btnSobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobe.Location = new System.Drawing.Point(12, 440);
            this.btnSobe.Name = "btnSobe";
            this.btnSobe.Size = new System.Drawing.Size(176, 68);
            this.btnSobe.TabIndex = 1;
            this.btnSobe.Text = "Sobe";
            this.btnSobe.UseVisualStyleBackColor = false;
            this.btnSobe.Click += new System.EventHandler(this.btnSobe_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(175)))), ((int)(((byte)(141)))));
            this.btnIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIzadji.Location = new System.Drawing.Point(661, 440);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(176, 68);
            this.btnIzadji.TabIndex = 2;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnGosti
            // 
            this.btnGosti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(168)))), ((int)(((byte)(59)))));
            this.btnGosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGosti.Location = new System.Drawing.Point(194, 440);
            this.btnGosti.Name = "btnGosti";
            this.btnGosti.Size = new System.Drawing.Size(176, 68);
            this.btnGosti.TabIndex = 3;
            this.btnGosti.Text = "Gosti";
            this.btnGosti.UseVisualStyleBackColor = false;
            this.btnGosti.Click += new System.EventHandler(this.btnGosti_Click);
            // 
            // HotelManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagment.Properties.Resources.hotel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 520);
            this.Controls.Add(this.btnGosti);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnSobe);
            this.Controls.Add(this.btnRezervacija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HotelManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotelManagment";
            this.Load += new System.EventHandler(this.HotelManagment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRezervacija;
        private System.Windows.Forms.Button btnSobe;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnGosti;
    }
}

