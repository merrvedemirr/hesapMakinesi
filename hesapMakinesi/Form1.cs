namespace hesapMakinesi
{
    public partial class Form1 : Form
    {

        int sayi1, sayi2, sonuc;

       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 =Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 + sayi2;
            label4.Text = sonuc.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            sonuc = sayi1 - sayi2;
            label4.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 * sayi2;
            label4.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            if(sayi1 >= sayi2)
            {
                sonuc= sayi1 / sayi2;
            }
            else
            {
                sonuc = 0;
            }
            label4.Text= sonuc.ToString();
        }
    }
}