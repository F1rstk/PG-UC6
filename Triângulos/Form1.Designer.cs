namespace Triângulos
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
            btnverificar = new Button();
            btnlimpar = new Button();
            lblLadoA = new Label();
            lblLadoB = new Label();
            lblLadoC = new Label();
            lbltitulo = new Label();
            txtLadoA = new TextBox();
            txtLadoB = new TextBox();
            txtLadoC = new TextBox();
            pictureBox1 = new PictureBox();
            lblResultado = new Label();
            pictureBox2 = new PictureBox();
            btnsair = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnverificar
            // 
            btnverificar.Image = (Image)resources.GetObject("btnverificar.Image");
            btnverificar.Location = new Point(139, 354);
            btnverificar.Name = "btnverificar";
            btnverificar.Size = new Size(106, 84);
            btnverificar.TabIndex = 0;
            btnverificar.Text = "Verificar";
            btnverificar.TextAlign = ContentAlignment.BottomCenter;
            btnverificar.UseVisualStyleBackColor = true;
            btnverificar.Click += btnverificar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Image = (Image)resources.GetObject("btnlimpar.Image");
            btnlimpar.Location = new Point(346, 354);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(106, 84);
            btnlimpar.TabIndex = 1;
            btnlimpar.Text = "Limpar";
            btnlimpar.TextAlign = ContentAlignment.BottomCenter;
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // lblLadoA
            // 
            lblLadoA.AutoSize = true;
            lblLadoA.Location = new Point(49, 195);
            lblLadoA.Name = "lblLadoA";
            lblLadoA.Size = new Size(81, 15);
            lblLadoA.TabIndex = 3;
            lblLadoA.Text = "Primeiro lado:";
            // 
            // lblLadoB
            // 
            lblLadoB.AutoSize = true;
            lblLadoB.Location = new Point(49, 235);
            lblLadoB.Name = "lblLadoB";
            lblLadoB.Size = new Size(83, 15);
            lblLadoB.TabIndex = 4;
            lblLadoB.Text = "Segundo lado:";
            // 
            // lblLadoC
            // 
            lblLadoC.AutoSize = true;
            lblLadoC.Location = new Point(49, 299);
            lblLadoC.Name = "lblLadoC";
            lblLadoC.Size = new Size(80, 15);
            lblLadoC.TabIndex = 5;
            lblLadoC.Text = "Terceiro Lado:";
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lbltitulo.Location = new Point(437, 10);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(195, 41);
            lbltitulo.TabIndex = 6;
            lbltitulo.Text = "TRIÂNGULOS";
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(139, 187);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(100, 23);
            txtLadoA.TabIndex = 10;
            // 
            // txtLadoB
            // 
            txtLadoB.Location = new Point(139, 235);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(100, 23);
            txtLadoB.TabIndex = 11;
            // 
            // txtLadoC
            // 
            txtLadoC.Location = new Point(139, 291);
            txtLadoC.Name = "txtLadoC";
            txtLadoC.Size = new Size(100, 23);
            txtLadoC.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(475, 317);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 16;
            lblResultado.Text = "Resultado";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_erro_48;
            pictureBox2.Location = new Point(290, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 236);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // btnsair
            // 
            btnsair.Image = (Image)resources.GetObject("btnsair.Image");
            btnsair.Location = new Point(553, 354);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(106, 84);
            btnsair.TabIndex = 19;
            btnsair.Text = "Sair";
            btnsair.TextAlign = ContentAlignment.BottomCenter;
            btnsair.UseVisualStyleBackColor = true;
            btnsair.Click += btnsair_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_erro_48;
            pictureBox3.Location = new Point(546, 54);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(250, 236);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // Form1
            // 
            AcceptButton = btnverificar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnsair;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(btnsair);
            Controls.Add(pictureBox2);
            Controls.Add(lblResultado);
            Controls.Add(pictureBox1);
            Controls.Add(txtLadoC);
            Controls.Add(txtLadoB);
            Controls.Add(txtLadoA);
            Controls.Add(lbltitulo);
            Controls.Add(lblLadoC);
            Controls.Add(lblLadoB);
            Controls.Add(lblLadoA);
            Controls.Add(btnlimpar);
            Controls.Add(btnverificar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnverificar;
        private Button btnlimpar;
        private Label lblLadoA;
        private Label lblLadoB;
        private Label lblLadoC;
        private Label lbltitulo;
        private TextBox txtLadoA;
        private TextBox txtLadoB;
        private TextBox txtLadoC;
        private PictureBox pictureBox1;
        private Label lblResultado;
        private PictureBox pictureBox2;
        private Button btnsair;
        private PictureBox pictureBox3;
    }
}