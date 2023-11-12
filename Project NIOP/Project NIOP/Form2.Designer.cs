namespace Project_NIOP
{
    partial class Form2
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
            this.silaElPoljaNaslov = new System.Windows.Forms.Label();
            this.naboj1 = new System.Windows.Forms.TextBox();
            this.naboj2 = new System.Windows.Forms.TextBox();
            this.udaljenost = new System.Windows.Forms.TextBox();
            this.naboj1Label = new System.Windows.Forms.Label();
            this.naboj2Label = new System.Windows.Forms.Label();
            this.udaljenostLabel = new System.Windows.Forms.Label();
            this.izracunajElPolje = new System.Windows.Forms.Button();
            this.natragElPolje = new System.Windows.Forms.Button();
            this.rezultatElPoljeLabel = new System.Windows.Forms.Label();
            this.rezultatElPolje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // silaElPoljaNaslov
            // 
            this.silaElPoljaNaslov.AutoSize = true;
            this.silaElPoljaNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silaElPoljaNaslov.Location = new System.Drawing.Point(11, 45);
            this.silaElPoljaNaslov.Name = "silaElPoljaNaslov";
            this.silaElPoljaNaslov.Size = new System.Drawing.Size(215, 25);
            this.silaElPoljaNaslov.TabIndex = 0;
            this.silaElPoljaNaslov.Text = "Sila Električnog Polja";
            // 
            // naboj1
            // 
            this.naboj1.AcceptsReturn = true;
            this.naboj1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.naboj1.Location = new System.Drawing.Point(90, 133);
            this.naboj1.Name = "naboj1";
            this.naboj1.Size = new System.Drawing.Size(100, 20);
            this.naboj1.TabIndex = 1;
            // 
            // naboj2
            // 
            this.naboj2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.naboj2.Location = new System.Drawing.Point(90, 186);
            this.naboj2.Name = "naboj2";
            this.naboj2.Size = new System.Drawing.Size(100, 20);
            this.naboj2.TabIndex = 2;
            // 
            // udaljenost
            // 
            this.udaljenost.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.udaljenost.Location = new System.Drawing.Point(90, 242);
            this.udaljenost.Name = "udaljenost";
            this.udaljenost.Size = new System.Drawing.Size(100, 20);
            this.udaljenost.TabIndex = 3;
            // 
            // naboj1Label
            // 
            this.naboj1Label.AutoSize = true;
            this.naboj1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naboj1Label.Location = new System.Drawing.Point(34, 133);
            this.naboj1Label.Name = "naboj1Label";
            this.naboj1Label.Size = new System.Drawing.Size(50, 15);
            this.naboj1Label.TabIndex = 4;
            this.naboj1Label.Text = "Naboj1:";
            // 
            // naboj2Label
            // 
            this.naboj2Label.AutoSize = true;
            this.naboj2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naboj2Label.Location = new System.Drawing.Point(34, 186);
            this.naboj2Label.Name = "naboj2Label";
            this.naboj2Label.Size = new System.Drawing.Size(50, 15);
            this.naboj2Label.TabIndex = 5;
            this.naboj2Label.Text = "Naboj2:";
            // 
            // udaljenostLabel
            // 
            this.udaljenostLabel.AutoSize = true;
            this.udaljenostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udaljenostLabel.Location = new System.Drawing.Point(15, 242);
            this.udaljenostLabel.Name = "udaljenostLabel";
            this.udaljenostLabel.Size = new System.Drawing.Size(69, 15);
            this.udaljenostLabel.TabIndex = 6;
            this.udaljenostLabel.Text = "Udaljenost:";
            // 
            // izracunajElPolje
            // 
            this.izracunajElPolje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izracunajElPolje.Location = new System.Drawing.Point(90, 304);
            this.izracunajElPolje.Name = "izracunajElPolje";
            this.izracunajElPolje.Size = new System.Drawing.Size(100, 50);
            this.izracunajElPolje.TabIndex = 7;
            this.izracunajElPolje.Text = "Izračunaj";
            this.izracunajElPolje.UseVisualStyleBackColor = true;
            this.izracunajElPolje.Click += new System.EventHandler(this.IzracunajElPolje_Click);
            // 
            // natragElPolje
            // 
            this.natragElPolje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natragElPolje.Location = new System.Drawing.Point(664, 30);
            this.natragElPolje.Name = "natragElPolje";
            this.natragElPolje.Size = new System.Drawing.Size(100, 40);
            this.natragElPolje.TabIndex = 8;
            this.natragElPolje.Text = "Natrag";
            this.natragElPolje.UseVisualStyleBackColor = true;
            this.natragElPolje.Click += new System.EventHandler(this.NatragElPolje_Click);
            // 
            // rezultatElPoljeLabel
            // 
            this.rezultatElPoljeLabel.AutoSize = true;
            this.rezultatElPoljeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezultatElPoljeLabel.Location = new System.Drawing.Point(296, 190);
            this.rezultatElPoljeLabel.Name = "rezultatElPoljeLabel";
            this.rezultatElPoljeLabel.Size = new System.Drawing.Size(58, 16);
            this.rezultatElPoljeLabel.TabIndex = 9;
            this.rezultatElPoljeLabel.Text = "Rezultat:";
            // 
            // rezultatElPolje
            // 
            this.rezultatElPolje.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rezultatElPolje.Location = new System.Drawing.Point(361, 190);
            this.rezultatElPolje.Name = "rezultatElPolje";
            this.rezultatElPolje.Size = new System.Drawing.Size(138, 20);
            this.rezultatElPolje.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rezultatElPolje);
            this.Controls.Add(this.rezultatElPoljeLabel);
            this.Controls.Add(this.natragElPolje);
            this.Controls.Add(this.izracunajElPolje);
            this.Controls.Add(this.udaljenostLabel);
            this.Controls.Add(this.naboj2Label);
            this.Controls.Add(this.naboj1Label);
            this.Controls.Add(this.udaljenost);
            this.Controls.Add(this.naboj2);
            this.Controls.Add(this.naboj1);
            this.Controls.Add(this.silaElPoljaNaslov);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label silaElPoljaNaslov;
        private System.Windows.Forms.TextBox naboj1;
        private System.Windows.Forms.TextBox naboj2;
        private System.Windows.Forms.TextBox udaljenost;
        private System.Windows.Forms.Label naboj1Label;
        private System.Windows.Forms.Label naboj2Label;
        private System.Windows.Forms.Label udaljenostLabel;
        private System.Windows.Forms.Button izracunajElPolje;
        private System.Windows.Forms.Button natragElPolje;
        private System.Windows.Forms.Label rezultatElPoljeLabel;
        private System.Windows.Forms.TextBox rezultatElPolje;
    }
}