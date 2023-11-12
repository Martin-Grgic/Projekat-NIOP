namespace Project_NIOP
{
    partial class Form1
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
            this.elPolje = new System.Windows.Forms.Button();
            this.potencEn = new System.Windows.Forms.Button();
            this.pozdrav = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // elPolje
            // 
            this.elPolje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elPolje.Location = new System.Drawing.Point(157, 238);
            this.elPolje.Name = "elPolje";
            this.elPolje.Size = new System.Drawing.Size(150, 75);
            this.elPolje.TabIndex = 0;
            this.elPolje.Text = "Sila Električnog Polja";
            this.elPolje.UseVisualStyleBackColor = true;
            this.elPolje.Click += new System.EventHandler(this.ElPolje_Click);
            // 
            // potencEn
            // 
            this.potencEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potencEn.Location = new System.Drawing.Point(466, 238);
            this.potencEn.Name = "potencEn";
            this.potencEn.Size = new System.Drawing.Size(150, 75);
            this.potencEn.TabIndex = 1;
            this.potencEn.Text = "Potencijalna Energija";
            this.potencEn.UseVisualStyleBackColor = true;
            this.potencEn.Click += new System.EventHandler(this.PotencEn_Click);
            // 
            // pozdrav
            // 
            this.pozdrav.AutoSize = true;
            this.pozdrav.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pozdrav.Location = new System.Drawing.Point(297, 113);
            this.pozdrav.Name = "pozdrav";
            this.pozdrav.Size = new System.Drawing.Size(183, 39);
            this.pozdrav.TabIndex = 2;
            this.pozdrav.Text = "Dobrodošli";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pozdrav);
            this.Controls.Add(this.potencEn);
            this.Controls.Add(this.elPolje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button elPolje;
        private System.Windows.Forms.Button potencEn;
        private System.Windows.Forms.Label pozdrav;
    }
}

