namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double consu, descu, descu1;
            consu = Convert.ToDouble(textBox1.Text);
            if (consu < 100)
            {
                descu = consu - (consu * 0.10);
                descu1 = descu + (descu * 0.18);
                MessageBox.Show("el monto final es de :" + descu1);
            }
            if (consu >= 100)
            {
                descu = consu - (consu * 0.10);
                descu1 = descu + (descu * 0.18);
                MessageBox.Show("el monto final es de :" + descu1);
            }
        }
    }
}