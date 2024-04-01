namespace Variable.cs
{
    public partial class @string : Form
    {
        public @string()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad,yaþ,cinsiyet;
            
            ad = textBox1.Text;
            soyad = textBox2.Text;
            yaþ = textBox3.Text;
            cinsiyet = textBox4.Text;
            label1.Text = ad;
            label2.Text = soyad;
            label3.Text=yaþ;
            label4.Text = cinsiyet;
            listBox1.Items.Add(label1.Text);
            listBox1.Items.Add(label2.Text);
            listBox1.Items.Add(label3.Text);
            listBox1.Items.Add(label4.Text);
            

        }

       
    }
}
