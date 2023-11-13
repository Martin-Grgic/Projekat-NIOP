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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void IzracunajElPolje_Click(object sender, EventArgs e)
        {
            //Pohranjivanje vrijednosti iz Textboxova u varijable
            double q1 = Convert.ToDouble(naboj1.Text);
            double q2 = Convert.ToDouble(naboj2.Text);
            double r = Convert.ToDouble(udaljenost.Text);
            double k = 9 * Math.Pow(10, 9);

            double rez =k * ((q1 * q2) / Math.Pow(r, 2));

            //Prikazivanje rezultat u labelu
            rezultatElPolje.Text = rez.ToString();
        }

        private void NatragElPolje_Click(object sender, EventArgs e)
        {
            //Zatvaranje forme
            Close();
        }
    }
}
