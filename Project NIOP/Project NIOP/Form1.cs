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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ElPolje_Click(object sender, EventArgs e)
        {   
            //Inicijaliziramo i prikazujemo novu formu za Silu elektricnog polja
            Form2 SilaElPolja = new Form2();
            SilaElPolja.Show();

        }

        private void PotencEn_Click(object sender, EventArgs e)
        {

            //Inicijaliziramo i prikazujemo novu formu za Potencijalnu energiju
            Form3 PotencijalnaEnergija = new Form3();
            PotencijalnaEnergija.Show();
        }
    }
}
