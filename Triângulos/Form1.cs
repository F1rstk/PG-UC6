namespace Triângulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC;

            if (double.TryParse(txtLadoA.Text, out ladoA) &&
                double.TryParse(txtLadoB.Text, out ladoB) &&
                double.TryParse(txtLadoC.Text, out ladoC))
            {
                if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
                {
                    if (ladoA == ladoB && ladoB == ladoC)
                    {
                        lblResultado.Text = "O triângulo é Equilátero e acuntagulo.";
                        pictureBox2.Image = Properties.Resources.equilatero;
                        pictureBox3.Image = Properties.Resources.acutangulo_svg;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        txtLadoA.Focus();
                    }
                    else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
                    {
                        lblResultado.Text = "O triângulo é Isósceles e acutangulo.";
                        pictureBox2.Image = Properties.Resources.isósceles;
                        pictureBox3.Image = Properties.Resources.acutangulo_svg;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        txtLadoA.Focus();
                    }
                    else
                    {
                        lblResultado.Text = "O triângulo é Escaleno e Obtusangulo.";
                        pictureBox2.Image = Properties.Resources.escaleno;
                        pictureBox3.Image = Properties.Resources.obtusangulo;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        txtLadoA.Focus();
                    }
                }
                else
                {
                    lblResultado.Text = "Os valores informados não formam um triângulo.";
                    pictureBox2.Image = Properties.Resources.icons8_erro_48;
                    txtLadoA.Focus();
                }
            }
            else
            {
                lblResultado.Text = "Por favor, insira valores válidos.";
                pictureBox2.Image = Properties.Resources.icons8_erro_48;
                txtLadoA.Focus();

            }



        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            lblResultado.Text = "";
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            txtLadoA.Focus();
        }
    }

}
