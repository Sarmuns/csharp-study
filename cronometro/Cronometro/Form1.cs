namespace Cronometro
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();

        }
        public double segundosDecorridos = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AtualizarTempoDecorrido()
        {
            TimeSpan tempoDecorrido = TimeSpan.FromSeconds(segundosDecorridos);
            label1.Text = tempoDecorrido.ToString(@"hh\:mm\:ss");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            segundosDecorridos++;
            AtualizarTempoDecorrido();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            segundosDecorridos = 0;
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            segundosDecorridos = 0;
            AtualizarTempoDecorrido();
            timer1.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                button3.Text = "Play";
            }
            else if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                button3.Text = "Pause";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}