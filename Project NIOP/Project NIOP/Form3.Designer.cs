namespace Project_NIOP
{
    partial class Form3
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
            this.potencEnNaslov = new System.Windows.Forms.Label();
            this.masaLabel = new System.Windows.Forms.Label();
            this.visinaLabel = new System.Windows.Forms.Label();
            this.rezultatPotencLabel = new System.Windows.Forms.Label();
            this.izracunajPotencEn = new System.Windows.Forms.Button();
            this.natragPotencEn = new System.Windows.Forms.Button();
            this.masa = new System.Windows.Forms.TextBox();
            this.visina = new System.Windows.Forms.TextBox();
            this.rezultatPotenc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // potencEnNaslov
            // 
            this.potencEnNaslov.AutoSize = true;
            this.potencEnNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potencEnNaslov.Location = new System.Drawing.Point(12, 50);
            this.potencEnNaslov.Name = "potencEnNaslov";
            this.potencEnNaslov.Size = new System.Drawing.Size(215, 25);
            this.potencEnNaslov.TabIndex = 0;
            this.potencEnNaslov.Text = "Potencijalna Energija";
            // 
            // masaLabel
            // 
            this.masaLabel.AutoSize = true;
            this.masaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masaLabel.Location = new System.Drawing.Point(29, 131);
            this.masaLabel.Name = "masaLabel";
            this.masaLabel.Size = new System.Drawing.Size(44, 16);
            this.masaLabel.TabIndex = 1;
            this.masaLabel.Text = "Masa:";
            // 
            // visinaLabel
            // 
            this.visinaLabel.AutoSize = true;
            this.visinaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visinaLabel.Location = new System.Drawing.Point(29, 187);
            this.visinaLabel.Name = "visinaLabel";
            this.visinaLabel.Size = new System.Drawing.Size(47, 16);
            this.visinaLabel.TabIndex = 2;
            this.visinaLabel.Text = "Visina:";
            // 
            // rezultatPotencLabel
            // 
            this.rezultatPotencLabel.AutoSize = true;
            this.rezultatPotencLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezultatPotencLabel.Location = new System.Drawing.Point(280, 158);
            this.rezultatPotencLabel.Name = "rezultatPotencLabel";
            this.rezultatPotencLabel.Size = new System.Drawing.Size(66, 18);
            this.rezultatPotencLabel.TabIndex = 3;
            this.rezultatPotencLabel.Text = "Rezultat:";
            // 
            // izracunajPotencEn
            // 
            this.izracunajPotencEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izracunajPotencEn.Location = new System.Drawing.Point(80, 250);
            this.izracunajPotencEn.Name = "izracunajPotencEn";
            this.izracunajPotencEn.Size = new System.Drawing.Size(100, 50);
            this.izracunajPotencEn.TabIndex = 4;
            this.izracunajPotencEn.Text = "Izračunaj";
            this.izracunajPotencEn.UseVisualStyleBackColor = true;
            this.izracunajPotencEn.Click += new System.EventHandler(this.izracunajPotencEn_Click);
            // 
            // natragPotencEn
            // 
            this.natragPotencEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natragPotencEn.Location = new System.Drawing.Point(653, 44);
            this.natragPotencEn.Name = "natragPotencEn";
            this.natragPotencEn.Size = new System.Drawing.Size(100, 40);
            this.natragPotencEn.TabIndex = 5;
            this.natragPotencEn.Text = "Natrag";
            this.natragPotencEn.UseVisualStyleBackColor = true;
            this.natragPotencEn.Click += new System.EventHandler(this.natragPotencEn_Click);
            // 
            // masa
            // 
            this.masa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.masa.Location = new System.Drawing.Point(80, 131);
            this.masa.Name = "masa";
            this.masa.Size = new System.Drawing.Size(100, 20);
            this.masa.TabIndex = 6;
            // 
            // visina
            // 
            this.visina.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.visina.Location = new System.Drawing.Point(80, 187);
            this.visina.Name = "visina";
            this.visina.Size = new System.Drawing.Size(100, 20);
            this.visina.TabIndex = 7;
            // 
            // rezultatPotenc
            // 
            this.rezultatPotenc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rezultatPotenc.Location = new System.Drawing.Point(352, 159);
            this.rezultatPotenc.Name = "rezultatPotenc";
            this.rezultatPotenc.Size = new System.Drawing.Size(113, 20);
            this.rezultatPotenc.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rezultatPotenc);
            this.Controls.Add(this.visina);
            this.Controls.Add(this.masa);
            this.Controls.Add(this.natragPotencEn);
            this.Controls.Add(this.izracunajPotencEn);
            this.Controls.Add(this.rezultatPotencLabel);
            this.Controls.Add(this.visinaLabel);
            this.Controls.Add(this.masaLabel);
            this.Controls.Add(this.potencEnNaslov);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label potencEnNaslov;
        private System.Windows.Forms.Label masaLabel;
        private System.Windows.Forms.Label visinaLabel;
        private System.Windows.Forms.Label rezultatPotencLabel;
        private System.Windows.Forms.Button izracunajPotencEn;
        private System.Windows.Forms.Button natragPotencEn;
        private System.Windows.Forms.TextBox masa;
        private System.Windows.Forms.TextBox visina;
        private System.Windows.Forms.TextBox rezultatPotenc;
    }
}