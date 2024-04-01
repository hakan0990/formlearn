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
    public partial class intForm : Form
    {
        public intForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not1,not2,not3,ortalama;
            not1 = 10;
            not2 = 20;
            not3 = 30;
            ortalama=(not1+not2+not3)/3;

            label1.Text="Girilen Notlar Sırasıyla"+not1+not2+not3+ "Ortalaması : "+ortalama;

        }
    }
}
