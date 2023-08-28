namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
            n3 = Convert.ToInt32(textBox3.Text);
            int mayor = n1;
            if (n2 > mayor)
            {
                mayor = n2;
            }
            if (n3 > mayor)
            {
                mayor = n3;
            }
            MessageBox.Show("el numero mayor es " + mayor);
        }
    }
}