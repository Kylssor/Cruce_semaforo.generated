using cruce_semaforo.Properties;

namespace cruce_semaforo;

partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>s
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
        components = new System.ComponentModel.Container();
        textrojo1 = new TextBox();
        textamarillo1 = new TextBox();
        textverde1 = new TextBox();
        textrojo2 = new TextBox();
        textamarillo2 = new TextBox();
        textverde2 = new TextBox();
        label1 = new Label();
        pictureBox1 = new PictureBox();
        pictureBox2 = new PictureBox();
        btniniciar = new Button();
        timer1 = new System.Windows.Forms.Timer(components);
        timer2 = new System.Windows.Forms.Timer(components);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // textrojo1
        // 
        textrojo1.BackColor = Color.Red;
        textrojo1.Location = new Point(421, 35);
        textrojo1.Multiline = true;
        textrojo1.Name = "textrojo1";
        textrojo1.Size = new Size(32, 30);
        textrojo1.TabIndex = 0;
        // 
        // textamarillo1
        // 
        textamarillo1.BackColor = Color.Black;
        textamarillo1.Location = new Point(421, 64);
        textamarillo1.Multiline = true;
        textamarillo1.Name = "textamarillo1";
        textamarillo1.Size = new Size(32, 30);
        textamarillo1.TabIndex = 1;
        // 
        // textverde1
        // 
        textverde1.BackColor = Color.Black;
        textverde1.Location = new Point(421, 92);
        textverde1.Multiline = true;
        textverde1.Name = "textverde1";
        textverde1.Size = new Size(32, 30);
        textverde1.TabIndex = 2;
        // 
        // textrojo2
        // 
        textrojo2.BackColor = Color.Red;
        textrojo2.Location = new Point(106, 92);
        textrojo2.Multiline = true;
        textrojo2.Name = "textrojo2";
        textrojo2.Size = new Size(32, 30);
        textrojo2.TabIndex = 3;
        // 
        // textamarillo2
        // 
        textamarillo2.BackColor = Color.Black;
        textamarillo2.Location = new Point(137, 92);
        textamarillo2.Multiline = true;
        textamarillo2.Name = "textamarillo2";
        textamarillo2.Size = new Size(32, 30);
        textamarillo2.TabIndex = 4;
        // 
        // textverde2
        // 
        textverde2.BackColor = Color.Black;
        textverde2.Location = new Point(168, 92);
        textverde2.Multiline = true;
        textverde2.Name = "textverde2";
        textverde2.Size = new Size(32, 30);
        textverde2.TabIndex = 5;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial", 12F);
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(0, 18);
        label1.TabIndex = 9;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Resources.carro_2;
        pictureBox1.Location = new Point(275, 312);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(44, 93);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 10;
        pictureBox1.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = Color.LightGray;
        pictureBox2.Image = Resources.carro_3;
        pictureBox2.Location = new Point(421, 164);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(93, 44);
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 11;
        pictureBox2.TabStop = false;
        // 
        // btniniciar
        // 
        btniniciar.BackColor = Color.Transparent;
        btniniciar.Font = new Font("Arial", 12F);
        btniniciar.Location = new Point(2, 3);
        btniniciar.Name = "btniniciar";
        btniniciar.Size = new Size(189, 30);
        btniniciar.TabIndex = 13;
        btniniciar.Text = "INICIAR";
        btniniciar.UseVisualStyleBackColor = false;
        btniniciar.Click += btniniciar_Click;
        // 
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Resources.CRUCE;
        ClientSize = new Size(593, 391);
        Controls.Add(btniniciar);
        Controls.Add(pictureBox2);
        Controls.Add(pictureBox1);
        Controls.Add(label1);
        Controls.Add(textverde2);
        Controls.Add(textamarillo2);
        Controls.Add(textrojo2);
        Controls.Add(textverde1);
        Controls.Add(textamarillo1);
        Controls.Add(textrojo1);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox textrojo1;
        private TextBox textamarillo1;
        private TextBox textverde1;
        private TextBox textrojo2;
        private TextBox textamarillo2;
        private TextBox textverde2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btniniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;

    public object Properties { get; private set; }
}