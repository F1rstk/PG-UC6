namespace Dados_jogo
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            nomeUsuario = new Label();
            label3 = new Label();
            label2 = new Label();
            pcbPC = new PictureBox();
            pcbVersus = new PictureBox();
            pcbUsario = new PictureBox();
            groupBox3 = new GroupBox();
            pcbDadosUsuario = new PictureBox();
            groupBox4 = new GroupBox();
            pcbDadosPc = new PictureBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbPC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbVersus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsario).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbDadosUsuario).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbDadosPc).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 302);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Play;
            button1.Location = new Point(77, 96);
            button1.Name = "button1";
            button1.Size = new Size(200, 200);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 50);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Usuarío:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nomeUsuario);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(pcbPC);
            groupBox2.Controls.Add(pcbVersus);
            groupBox2.Controls.Add(pcbUsario);
            groupBox2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(384, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(638, 296);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Placar";
            // 
            // nomeUsuario
            // 
            nomeUsuario.AutoSize = true;
            nomeUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nomeUsuario.Location = new Point(113, 19);
            nomeUsuario.Name = "nomeUsuario";
            nomeUsuario.Size = new Size(50, 20);
            nomeUsuario.TabIndex = 5;
            nomeUsuario.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(450, 239);
            label3.Name = "label3";
            label3.Size = new Size(23, 28);
            label3.TabIndex = 4;
            label3.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(89, 239);
            label2.Name = "label2";
            label2.Size = new Size(23, 28);
            label2.TabIndex = 3;
            label2.Text = "0";
            // 
            // pcbPC
            // 
            pcbPC.Image = (Image)resources.GetObject("pcbPC.Image");
            pcbPC.Location = new Point(390, 32);
            pcbPC.Name = "pcbPC";
            pcbPC.Size = new Size(193, 190);
            pcbPC.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbPC.TabIndex = 2;
            pcbPC.TabStop = false;
            // 
            // pcbVersus
            // 
            pcbVersus.Image = (Image)resources.GetObject("pcbVersus.Image");
            pcbVersus.Location = new Point(212, 32);
            pcbVersus.Name = "pcbVersus";
            pcbVersus.Size = new Size(155, 171);
            pcbVersus.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbVersus.TabIndex = 1;
            pcbVersus.TabStop = false;
            // 
            // pcbUsario
            // 
            pcbUsario.Image = (Image)resources.GetObject("pcbUsario.Image");
            pcbUsario.Location = new Point(13, 42);
            pcbUsario.Name = "pcbUsario";
            pcbUsario.Size = new Size(193, 188);
            pcbUsario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsario.TabIndex = 0;
            pcbUsario.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pcbDadosUsuario);
            groupBox3.Location = new Point(384, 301);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 257);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Usuarío";
            // 
            // pcbDadosUsuario
            // 
            pcbDadosUsuario.Image = Properties.Resources._6___Seis;
            pcbDadosUsuario.Location = new Point(13, 20);
            pcbDadosUsuario.Name = "pcbDadosUsuario";
            pcbDadosUsuario.Size = new Size(271, 217);
            pcbDadosUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbDadosUsuario.TabIndex = 0;
            pcbDadosUsuario.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(pcbDadosPc);
            groupBox4.Location = new Point(690, 306);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(296, 245);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Computador";
            // 
            // pcbDadosPc
            // 
            pcbDadosPc.Image = Properties.Resources._3___Três;
            pcbDadosPc.Location = new Point(6, 15);
            pcbDadosPc.Name = "pcbDadosPc";
            pcbDadosPc.Size = new Size(271, 224);
            pcbDadosPc.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbDadosPc.TabIndex = 1;
            pcbDadosPc.TabStop = false;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.Pare;
            button2.Location = new Point(35, 336);
            button2.Name = "button2";
            button2.Size = new Size(299, 222);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 570);
            Controls.Add(button2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbPC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbVersus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsario).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbDadosUsuario).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbDadosPc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button button1;
        private Button button2;
        private PictureBox pcbVersus;
        private PictureBox pcbDadosUsuario;
        private PictureBox pcbDadosPc;
        private Label label3;
        private Label label2;
        private PictureBox pcbPC;
        private PictureBox pcbUsario;
        private Label nomeUsuario;
    }
}