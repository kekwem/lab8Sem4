using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int szukaj(int a, int b)
        {
            int liczba_pierw = 0;
            for (int i = a; i <= b; i++)
            {
                bool pierwsza = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        pierwsza = false;
                        break;
                    }
                }
                if (pierwsza && i > 1)
                {
                    liczba_pierw++;
                }
            }
            return liczba_pierw;
        }

        public bool czyPierwsz(int liczba)
        {
            bool pierwsza = true;
            if (liczba > 1)
            {
                for (int i = 2; i < liczba; i++)
                {
                    if (liczba % i == 0)
                    {
                        pierwsza = false;
                        break;
                    }
                }
            }
            else
            {
                pierwsza = false;
            }
            return pierwsza;
        }

        public int szukaj_2_0(int a, int b)
        {
            int liczba_pierw = 0;
            for (int i = a; i <= b; i++)
            {
                var t = Task.Factory.StartNew(() => czyPierwsz(i), TaskCreationOptions.AttachedToParent);
                if (t.Result)
                {
                    liczba_pierw++;
                }
            }
            return liczba_pierw;
        }

        private async void szukajPierwszeButton_Click(object sender, EventArgs e)
        {
            labelinfo.Text = $"Task zaczal pracowac!";

            int a = await Task.Run(() => szukaj_2_0(Convert.ToInt32(firstTextBox.Text),
                Convert.ToInt32(secondTextBox.Text)));
            labelinfo.Text = $"Task skonczyl pracowac!";
            await Task.Delay(1000);
            labelinfo.Text = $"Znalieziono {a} liczb pierwszych!";
        }

        private async void szukajPierwButton_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Value = 0;
            int liczba_pierw = 0;
            int liczba_krokow = 0;
            int odLiczb = Convert.ToInt32(firstTextBox.Text);
            int doLiczb = Convert.ToInt32(secondTextBox.Text);
            int liczba = Convert.ToInt32(zakresTextBox.Text);
            int krok = (doLiczb - odLiczb) / liczba;
            for (int i = 0; i < liczba; i++)
            {
                var t = await Task.Run(() => szukaj(odLiczb, odLiczb + krok));               
                liczba_pierw += t;
                labelinfo2.Text = $"Znalieziono {liczba_pierw} liczb pierwszych!";
                odLiczb += krok + 1;                
                liczba_krokow++;
                progressBar.Value = (int)(((double)liczba_krokow / liczba) * 100);
            }
        }
    }
}
