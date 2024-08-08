namespace Cadastro_de_Alunos
{
    public partial class Form1 : Form
    {
        private bool isClearing=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbcursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // S� executa o c�digo se n�o estiver em processo de limpeza
            if (!isClearing)
            {
                if (cmbcursos.SelectedItem != null)
                {
                    string selectedItem = cmbcursos.SelectedItem.ToString();
                    lstmesinicio.Items.Clear();

                    switch (selectedItem)
                    {
                        case "T�cnico em Desenvolvimento de Sistemas":
                            lstmesinicio.Items.Add("Agosto");
                            lstmesinicio.Items.Add("Novembro");
                            rdbmanha.Visible = true;
                            rdbnoite.Visible = false;
                            rdbtarde.Visible = true;
                            break;

                        case "T�cnico em Inform�tica para Internet":
                            lstmesinicio.Items.Add("Setembro");
                            lstmesinicio.Items.Add("Outubro");
                            rdbmanha.Visible = false;
                            rdbnoite.Visible = true;
                            rdbtarde.Visible = true;
                            break;

                        case "T�cnico em Design Gr�fico":
                            lstmesinicio.Items.Add("Setembro");
                            lstmesinicio.Items.Add("Outubro");
                            lstmesinicio.Items.Add("Novembro");
                            rdbmanha.Visible = true;
                            rdbnoite.Visible = true;
                            rdbtarde.Visible = true;
                            break;

                        default:
                            MessageBox.Show("Curso n�o reconhecido: " + selectedItem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum curso selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (cmbcursos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um curso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se todos os campos de texto est�o preenchidos
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Preencha todos os campos de texto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se algum bot�o de r�dio para sexo est� selecionado
            if (!rdbMasculino.Checked && !rdbFeminino.Checked)
            {
                MessageBox.Show("Selecione o sexo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se pelo menos um hobby foi selecionado
            if (!ckb1.Checked && !ckb2.Checked && !ckb3.Checked && !ckb4.Checked && !ckb5.Checked)
            {
                MessageBox.Show("Selecione pelo menos um hobby.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se algum hor�rio foi selecionado
            if (!rdbmanha.Checked && !rdbtarde.Checked && !rdbnoite.Checked)
            {
                MessageBox.Show("Selecione um hor�rio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se todas as verifica��es passaram, mostra a mensagem de sucesso
            MessageBox.Show("Matr�cula Feita!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            isClearing = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            // Limpar o comboBox
            cmbcursos.SelectedIndex = -1;

            // Limpar o ListBox
            lstmesinicio.Items.Clear();

            // Definir o foco em textBox1
            textBox1.Focus();
            isClearing=false;


            //limpa a goup box de sexo
            rdbMasculino.Checked = false;
            rdbFeminino.Checked = false;


            //limpando hobbies
            ckb1.Checked = false;
            ckb2.Checked = false;
            ckb3.Checked = false;
            ckb4.Checked = false;
            ckb5.Checked = false;

            //limpando hor�rios
            rdbnoite.Checked = false;
            rdbtarde.Checked = false;
            rdbmanha.Checked = false;
        }
    }
}