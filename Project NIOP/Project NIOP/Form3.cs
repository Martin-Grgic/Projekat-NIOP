using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_NIOP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void izracunajPotencEn_Click(object sender, EventArgs e)
        {

            //Pohranjivanje vrijednosti iz Textboxova u varijable
            double m = Convert.ToDouble(masa.Text);
            double h = Convert.ToDouble(visina.Text);
            double g = 9.81;

            double rez = m * g * h;

            //Zaokruzuzivanje rezultata na 4 decimale
            double roundRez = Math.Round(rez, 4);

            //Prikazivanje rezultat u labelu
            rezultatPotenc.Text =roundRez.ToString();
        }

        private void natragPotencEn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
