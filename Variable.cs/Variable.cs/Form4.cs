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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2, toplam, çarpım, fark,bolum;
            sayı1=Convert.ToInt16(textBox1.Text);
            sayı2 = Convert.ToInt16(textBox2.Text);
            toplam = sayı1 + sayı2;
            çarpım = sayı1 * sayı2;
            fark = sayı1 - sayı2;
            bolum = sayı1 / sayı2;
            MessageBox.Show("Toplam:" + toplam +"\n"+ "Çarpım:" + çarpım +"\n"+"Fark:" + fark + "\n"+"Bolüm:" + bolum);
        } 
    }
}
