namespace WinFormsApp1
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
            fundocartao = new Panel();
            Deposito = new Button();
            Transferencia = new Button();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            fundocartao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // fundocartao
            // 
            fundocartao.BackColor = Color.White;
            fundocartao.BackgroundImage = (Image)resources.GetObject("fundocartao.BackgroundImage");
            fundocartao.BorderStyle = BorderStyle.FixedSingle;
            fundocartao.Controls.Add(Deposito);
            fundocartao.Controls.Add(Transferencia);
            fundocartao.Controls.Add(label1);
            fundocartao.Controls.Add(pictureBox4);
            fundocartao.Location = new Point(-45, 184);
            fundocartao.Name = "fundocartao";
            fundocartao.Size = new Size(806, 223);
            fundocartao.TabIndex = 0;
            fundocartao.Paint += fundocartao_Paint;
            // 
            // Deposito
            // 
            Deposito.BackColor = Color.FromArgb(255, 255, 128);
            Deposito.Location = new Point(168, 70);
            Deposito.Name = "Deposito";
            Deposito.Size = new Size(87, 30);
            Deposito.TabIndex = 3;
            Deposito.Text = "Deposito";
            Deposito.UseVisualStyleBackColor = false;
            // 
            // Transferencia
            // 
            Transferencia.BackColor = Color.FromArgb(255, 255, 128);
            Transferencia.Location = new Point(75, 70);
            Transferencia.Name = "Transferencia";
            Transferencia.Size = new Size(87, 30);
            Transferencia.TabIndex = 2;
            Transferencia.Text = "Transferencia";
            Transferencia.UseVisualStyleBackColor = false;
            Transferencia.Click += Transferencia_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(75, 33);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 1;
            label1.Text = "Selecione o que deseja:";
            label1.Click += label1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(533, 33);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(261, 155);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(627, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(303, 50);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 68);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(166, 110);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(761, 384);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(fundocartao);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Home";
            fundocartao.ResumeLayout(false);
            fundocartao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel fundocartao;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Button Transferencia;
        private Button Deposito;
    }
}