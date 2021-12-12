using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol2_pole_Csharp
{
    public partial class Form1 : Form
    {
        public int[] pole;
        public Form1()
        {
            InitializeComponent();
        }

        private void generovani_Click(object sender, EventArgs e)
        {
            vypispole.Items.Clear();

            try
            {
                int n1 = Convert.ToInt32(cisloN.Text);
                int n2 = 0;
                int max = (-1001);
                double pocet = 0, soucet = 0, prumer = 0;
                Random rnd = new Random();

                pole = new int[n1];

                while (n2 < n1)
                {
                    pole[n2] = rnd.Next(-1000, 1001);
                    vypispole.Items.Add(Convert.ToString(pole[n2]));
                    soucet += pole[n2];
                    pocet++;
                    n2++;
                }

                prumer = soucet / pocet;

                foreach (int cislo in pole)
                {
                    if (cislo <= prumer && cislo > max)
                    {
                        max = cislo;
                    }
                }

                double prumer2 = Math.Round(prumer, 2);

                vypis_prumeru.Text = Convert.ToString(prumer2);
                vypis_maxima.Text = Convert.ToString(max);
            }
            catch
            {
                MessageBox.Show("Zadej kolik chceš generovat čísel!", "Error");
            }
        }
    }
}
