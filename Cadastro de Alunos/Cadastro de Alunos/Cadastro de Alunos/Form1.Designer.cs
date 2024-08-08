namespace Cadastro_de_Alunos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            grb1 = new GroupBox();
            lblemail = new Label();
            lblnome = new Label();
            lblmatricula = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            grb3 = new GroupBox();
            ckb5 = new CheckBox();
            ckb4 = new CheckBox();
            ckb3 = new CheckBox();
            ckb2 = new CheckBox();
            ckb1 = new CheckBox();
            grb2 = new GroupBox();
            rdbFeminino = new RadioButton();
            rdbMasculino = new RadioButton();
            pictureBox1 = new PictureBox();
            lbltitulo = new Label();
            grbcurso = new GroupBox();
            lstmesinicio = new ListBox();
            grbperiodo = new GroupBox();
            rdbnoite = new RadioButton();
            rdbtarde = new RadioButton();
            rdbmanha = new RadioButton();
            lblmes = new Label();
            cmbcursos = new ComboBox();
            btnsalvar = new Button();
            btnlimpar = new Button();
            btnsair = new Button();
            grb1.SuspendLayout();
            grb3.SuspendLayout();
            grb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grbcurso.SuspendLayout();
            grbperiodo.SuspendLayout();
            SuspendLayout();
            // 
            // grb1
            // 
            grb1.Controls.Add(lblemail);
            grb1.Controls.Add(lblnome);
            grb1.Controls.Add(lblmatricula);
            grb1.Controls.Add(textBox3);
            grb1.Controls.Add(textBox2);
            grb1.Controls.Add(textBox1);
            grb1.Controls.Add(grb3);
            grb1.Controls.Add(grb2);
            grb1.Location = new Point(24, 138);
            grb1.Name = "grb1";
            grb1.Size = new Size(764, 321);
            grb1.TabIndex = 0;
            grb1.TabStop = false;
            grb1.Text = "Dados Pessoais:";
            grb1.Enter += groupBox1_Enter;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(38, 158);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(44, 15);
            lblemail.TabIndex = 7;
            lblemail.Text = "E-mail:";
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(38, 104);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(41, 15);
            lblnome.TabIndex = 6;
            lblnome.Text = "Nome:";
            // 
            // lblmatricula
            // 
            lblmatricula.AutoSize = true;
            lblmatricula.Location = new Point(38, 59);
            lblmatricula.Name = "lblmatricula";
            lblmatricula.Size = new Size(60, 15);
            lblmatricula.TabIndex = 5;
            lblmatricula.Text = "Matricula:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 155);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(581, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(581, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 2;
            // 
            // grb3
            // 
            grb3.Controls.Add(ckb5);
            grb3.Controls.Add(ckb4);
            grb3.Controls.Add(ckb3);
            grb3.Controls.Add(ckb2);
            grb3.Controls.Add(ckb1);
            grb3.Location = new Point(253, 207);
            grb3.Name = "grb3";
            grb3.Size = new Size(464, 109);
            grb3.TabIndex = 1;
            grb3.TabStop = false;
            grb3.Text = "Hobbies:";
            // 
            // ckb5
            // 
            ckb5.AutoSize = true;
            ckb5.Location = new Point(307, 22);
            ckb5.Name = "ckb5";
            ckb5.Size = new Size(52, 19);
            ckb5.TabIndex = 4;
            ckb5.Text = "Vôlei";
            ckb5.UseVisualStyleBackColor = true;
            // 
            // ckb4
            // 
            ckb4.AutoSize = true;
            ckb4.Location = new Point(170, 65);
            ckb4.Name = "ckb4";
            ckb4.Size = new Size(119, 19);
            ckb4.TabIndex = 3;
            ckb4.Text = "Programar em C#";
            ckb4.UseVisualStyleBackColor = true;
            // 
            // ckb3
            // 
            ckb3.AutoSize = true;
            ckb3.Location = new Point(170, 22);
            ckb3.Name = "ckb3";
            ckb3.Size = new Size(62, 19);
            ckb3.TabIndex = 2;
            ckb3.Text = "Xadrez";
            ckb3.UseVisualStyleBackColor = true;
            // 
            // ckb2
            // 
            ckb2.AutoSize = true;
            ckb2.Location = new Point(26, 65);
            ckb2.Name = "ckb2";
            ckb2.Size = new Size(56, 19);
            ckb2.TabIndex = 1;
            ckb2.Text = "Séries";
            ckb2.UseVisualStyleBackColor = true;
            // 
            // ckb1
            // 
            ckb1.AutoSize = true;
            ckb1.Location = new Point(26, 22);
            ckb1.Name = "ckb1";
            ckb1.Size = new Size(65, 19);
            ckb1.TabIndex = 0;
            ckb1.Text = "Futebol";
            ckb1.UseVisualStyleBackColor = true;
            // 
            // grb2
            // 
            grb2.Controls.Add(rdbFeminino);
            grb2.Controls.Add(rdbMasculino);
            grb2.Location = new Point(38, 207);
            grb2.Name = "grb2";
            grb2.Size = new Size(162, 102);
            grb2.TabIndex = 0;
            grb2.TabStop = false;
            grb2.Text = "Sexo:";
            // 
            // rdbFeminino
            // 
            rdbFeminino.AutoSize = true;
            rdbFeminino.Location = new Point(30, 64);
            rdbFeminino.Name = "rdbFeminino";
            rdbFeminino.Size = new Size(73, 19);
            rdbFeminino.TabIndex = 1;
            rdbFeminino.TabStop = true;
            rdbFeminino.Text = "Feminino";
            rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(30, 22);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(78, 19);
            rdbMasculino.TabIndex = 0;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbltitulo.ForeColor = Color.Red;
            lbltitulo.Location = new Point(373, 45);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(331, 34);
            lbltitulo.TabIndex = 2;
            lbltitulo.Text = "Cadastro dos Alunos";
            // 
            // grbcurso
            // 
            grbcurso.Controls.Add(lstmesinicio);
            grbcurso.Controls.Add(grbperiodo);
            grbcurso.Controls.Add(lblmes);
            grbcurso.Controls.Add(cmbcursos);
            grbcurso.Location = new Point(24, 465);
            grbcurso.Name = "grbcurso";
            grbcurso.Size = new Size(764, 235);
            grbcurso.TabIndex = 3;
            grbcurso.TabStop = false;
            grbcurso.Text = "Curso:";
            // 
            // lstmesinicio
            // 
            lstmesinicio.FormattingEnabled = true;
            lstmesinicio.ItemHeight = 15;
            lstmesinicio.Location = new Point(459, 38);
            lstmesinicio.Name = "lstmesinicio";
            lstmesinicio.Size = new Size(120, 49);
            lstmesinicio.TabIndex = 4;
            // 
            // grbperiodo
            // 
            grbperiodo.Controls.Add(rdbnoite);
            grbperiodo.Controls.Add(rdbtarde);
            grbperiodo.Controls.Add(rdbmanha);
            grbperiodo.Location = new Point(38, 106);
            grbperiodo.Name = "grbperiodo";
            grbperiodo.Size = new Size(200, 100);
            grbperiodo.TabIndex = 3;
            grbperiodo.TabStop = false;
            grbperiodo.Text = "Período:";
            // 
            // rdbnoite
            // 
            rdbnoite.AutoSize = true;
            rdbnoite.Location = new Point(15, 72);
            rdbnoite.Name = "rdbnoite";
            rdbnoite.Size = new Size(53, 19);
            rdbnoite.TabIndex = 2;
            rdbnoite.TabStop = true;
            rdbnoite.Text = "Noite";
            rdbnoite.UseVisualStyleBackColor = true;
            rdbnoite.Visible = false;
            // 
            // rdbtarde
            // 
            rdbtarde.AutoSize = true;
            rdbtarde.Location = new Point(15, 47);
            rdbtarde.Name = "rdbtarde";
            rdbtarde.Size = new Size(55, 19);
            rdbtarde.TabIndex = 1;
            rdbtarde.TabStop = true;
            rdbtarde.Text = "Tarde";
            rdbtarde.UseVisualStyleBackColor = true;
            rdbtarde.Visible = false;
            // 
            // rdbmanha
            // 
            rdbmanha.AutoSize = true;
            rdbmanha.Location = new Point(15, 22);
            rdbmanha.Name = "rdbmanha";
            rdbmanha.Size = new Size(63, 19);
            rdbmanha.TabIndex = 0;
            rdbmanha.TabStop = true;
            rdbmanha.Text = "Manhã";
            rdbmanha.UseVisualStyleBackColor = true;
            rdbmanha.Visible = false;
            // 
            // lblmes
            // 
            lblmes.AutoSize = true;
            lblmes.Location = new Point(376, 38);
            lblmes.Name = "lblmes";
            lblmes.Size = new Size(77, 15);
            lblmes.TabIndex = 2;
            lblmes.Text = "Mês do início:";
            // 
            // cmbcursos
            // 
            cmbcursos.FormattingEnabled = true;
            cmbcursos.Items.AddRange(new object[] { "Técnico em Desenvolvimento de Sistemas", "Técnico em Informática para internet", "Técnico em Design Gráfico" });
            cmbcursos.Location = new Point(38, 38);
            cmbcursos.Name = "cmbcursos";
            cmbcursos.Size = new Size(180, 23);
            cmbcursos.TabIndex = 1;
            cmbcursos.SelectedIndexChanged += cmbcursos_SelectedIndexChanged;
            // 
            // btnsalvar
            // 
            btnsalvar.Image = (Image)resources.GetObject("btnsalvar.Image");
            btnsalvar.Location = new Point(62, 721);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(125, 97);
            btnsalvar.TabIndex = 4;
            btnsalvar.Text = "&Salvar";
            btnsalvar.TextAlign = ContentAlignment.BottomCenter;
            btnsalvar.UseVisualStyleBackColor = true;
            btnsalvar.Click += btnsalvar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Image = (Image)resources.GetObject("btnlimpar.Image");
            btnlimpar.Location = new Point(303, 721);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(128, 97);
            btnlimpar.TabIndex = 5;
            btnlimpar.Text = "Limpar";
            btnlimpar.TextAlign = ContentAlignment.BottomCenter;
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnsair
            // 
            btnsair.Image = (Image)resources.GetObject("btnsair.Image");
            btnsair.Location = new Point(554, 721);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(130, 97);
            btnsair.TabIndex = 6;
            btnsair.Text = "&Sair";
            btnsair.TextAlign = ContentAlignment.BottomCenter;
            btnsair.UseVisualStyleBackColor = true;
            btnsair.Click += btnsair_Click;
            // 
            // Form1
            // 
            AcceptButton = btnsalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnsair;
            ClientSize = new Size(800, 841);
            Controls.Add(btnsair);
            Controls.Add(btnlimpar);
            Controls.Add(btnsalvar);
            Controls.Add(grbcurso);
            Controls.Add(lbltitulo);
            Controls.Add(pictureBox1);
            Controls.Add(grb1);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            grb1.ResumeLayout(false);
            grb1.PerformLayout();
            grb3.ResumeLayout(false);
            grb3.PerformLayout();
            grb2.ResumeLayout(false);
            grb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grbcurso.ResumeLayout(false);
            grbcurso.PerformLayout();
            grbperiodo.ResumeLayout(false);
            grbperiodo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grb1;
        private Label lblemail;
        private Label lblnome;
        private Label lblmatricula;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox grb3;
        private CheckBox ckb5;
        private CheckBox ckb4;
        private CheckBox ckb3;
        private CheckBox ckb2;
        private CheckBox ckb1;
        private GroupBox grb2;
        private RadioButton rdbFeminino;
        private RadioButton rdbMasculino;
        private PictureBox pictureBox1;
        private Label lbltitulo;
        private GroupBox grbcurso;
        private GroupBox grbperiodo;
        private RadioButton rdbnoite;
        private RadioButton rdbtarde;
        private RadioButton rdbmanha;
        private Label lblmes;
        private ComboBox cmbcursos;
        private Button btnsalvar;
        private Button btnlimpar;
        private Button btnsair;
        private ListBox lstmesinicio;
    }
}