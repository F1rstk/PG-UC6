namespace Dados_jogo
{
    public partial class Form1 : Form
    {
        private int placarUsuario = 0;
        private int placarMaquina = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nomeUsuario.Text = textBox1.Text;
            Random obj = new Random();
            int num = obj.Next(1, 7);

            if (num == 1)
            {
                pcbDadosUsuario.Image = Properties.Resources.Um;

            }
            else if (num == 2)
            {
                pcbDadosUsuario.Image = Properties.Resources._2___Dois;
            }
            else if (num == 3)
            {
                pcbDadosUsuario.Image = Properties.Resources._3___Três;
            }
            else if (num == 4)
            {
                pcbDadosUsuario.Image = Properties.Resources._4___Quatro;
            }
            else if (num == 5)
            {
                pcbDadosUsuario.Image = Properties.Resources._5___Cinco;
            }
            else if (num == 6)
            {
                pcbDadosUsuario.Image = Properties.Resources._6___Seis;
            }
            Random obj2 = new Random();
            int numero = obj2.Next(1, 7);
            if (numero == 1)
            {
                pcbDadosPc.Image = Properties.Resources.Um;
            }
            else if (numero == 2)
            {
                pcbDadosPc.Image = Properties.Resources._2___Dois;
            }
            else if (numero == 3)
            {
                pcbDadosPc.Image = Properties.Resources._3___Três;
            }
            else if (numero == 4)
            {
                pcbDadosPc.Image = Properties.Resources._4___Quatro;
            }
            else if (numero == 5)
            {
                pcbDadosPc.Image = Properties.Resources._5___Cinco;
            }
            else if (numero == 6)
            {
                pcbDadosPc.Image = Properties.Resources._6___Seis;
            }
            if (num != numero)
            {
                int resultadoUsuario = num;
                int resultadoMaquina = numero;


                label2.Text = "Seu Resultado: " + resultadoUsuario;
                label2.Font = new Font("Segoe UI", 10);


                label3.Text = "Resultado da Máquina: " + resultadoMaquina;
                label3.Font = new Font("Segoe UI", 10);


                if (resultadoUsuario > resultadoMaquina)
                {
                    MessageBox.Show("VC GANHOU");
                    placarUsuario++;

                }
                else if (resultadoUsuario < resultadoMaquina)
                {
                    MessageBox.Show("O BOT GANHOU");
                    placarMaquina++;
                    
                    

                }
                else if (resultadoUsuario==resultadoMaquina)
                {
                    MessageBox.Show("Empate!");
                }


                label2.Text = placarUsuario.ToString();
                label3.Text = placarMaquina.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}