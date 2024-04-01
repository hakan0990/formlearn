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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Yazdır_Click(object sender, EventArgs e)
        {
            int sayı,sonuc;
            sayı=Convert.ToInt32(textBox1.Text);
            sonuc = sayı * sayı * sayı;
            label2.Text=sonuc.ToString();
        }
    }
}
