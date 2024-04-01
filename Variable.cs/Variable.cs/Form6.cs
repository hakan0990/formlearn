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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ad, soyad;
            int sayı1,sayı2,sonDeğer;
            double kdv;
            ad=textBox1.Text;
            soyad=textBox2.Text;
            sayı1=Convert.ToInt32(textBox3.Text);
            sayı2 = Convert.ToInt32(textBox4.Text);   
            kdv = (sayı1 * 0.8) + (sayı2 * 0.8);
           
            listBox1.Items.Add(ad+""+soyad+""+"Kdv Değeri"+kdv);


        }
    }
}
