using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variable.cs
{
    public partial class lastProje : Form
    {
        public lastProje()
        {
            InitializeComponent();
        }
        int kasaTutar = 0;




        private void btnHesap_Click(object sender, EventArgs e)
        {
            int çay, kahve, limonata, churchil, toplam;

            çay = Convert.ToInt16(txtçay.Text);
            kahve = Convert.ToInt16(txtkahve.Text);
            limonata = Convert.ToInt16(txtlimonata.Text);
            churchil = Convert.ToInt16(txtchurchil.Text);

            toplam = çay * 5 + limonata * 15 + churchil * 20 + kahve * 10;

            lblKasa.Text = toplam.ToString();

            kasaTutar = toplam + kasaTutar;

            lblHasılat.Text = kasaTutar.ToString();






        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtçay.Text = "";
            txtkahve.Text = "";
            txtlimonata.Text = "";
            txtchurchil.Text = "";
            txtçay.Focus();
            lblKasa.Text = "0TL";
            lblHasılat.Text = "0TL";
        }

       
    }
}
