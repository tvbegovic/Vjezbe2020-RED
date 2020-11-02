using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista
{
    public partial class Glavna : Form
    {
        List<string> rijeci = new List<string>();

        public Glavna()
        {
            InitializeComponent();
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var rijec = txtJednarijec.Text;
            if(!string.IsNullOrEmpty(rijec))
            {
                rijeci.Add(rijec);
                txtJednarijec.Text = string.Empty;
                AzurirajListBox();
            }
            
        }

        private void AzurirajListBox()
        {
            lstPopis.DataSource = null;
            lstPopis.DataSource = rijeci;
        }

        private void btnDodajNaPos_Click(object sender, EventArgs e)
        {
            var pozicijaText = txtPozicija.Text;
            int pozicija;
            var ispravno = int.TryParse(pozicijaText, out pozicija);
            if(!ispravno)
            {
                MessageBox.Show("Broj nije u dobro formatu");
                return;
            }
            var rijec = txtJednarijec.Text;
            rijeci.Insert(pozicija - 1, rijec);
            txtJednarijec.Text = string.Empty;
            AzurirajListBox();
        }

        private void btnDodajVise_Click(object sender, EventArgs e)
        {
            var poljeRijeci = txtViseRijeci.Text.Split(' ');
            rijeci.AddRange(poljeRijeci);
            txtViseRijeci.Text = string.Empty;
            AzurirajListBox();
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            var index = lstPopis.SelectedIndex;
            if (index >= 0)
            {
                rijeci.RemoveAt(index);
                AzurirajListBox();
            }
                
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            rijeci.Clear();
            AzurirajListBox();
        }
    }
}
