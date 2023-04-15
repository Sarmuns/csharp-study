namespace WinFormsApp1
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

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(textBox1.Text);
            double valor2 = Convert.ToDouble(textBox2.Text);
            double resultado = valor1 * valor2;
            textBox3.Text = resultado.ToString();
        }
    }
}