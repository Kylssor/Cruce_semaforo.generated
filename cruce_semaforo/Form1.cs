namespace cruce_semaforo;


using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private Thread semaforo1Thread;
    private Thread semaforo2Thread;
    private bool running;

    public Form1()
    {
        InitializeComponent();
        running = false;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        label1.Text = "Hola Bienvenido";
        MessageBox.Show("\\tCRUCE \\n\\n 1. Rojo: Los carros se encuentran quietos esperando el semaforo \\n\\n 2.Amarillo: Los carros comienzan a arrancar \\n\\n 3. Verde: Los carros cruzan la calle \\n\\n \\t Preciona INICIAR");
    }

    private void btniniciar_Click(object sender, EventArgs e)
    {
        if (!running)
        {
            running = true;
            semaforo1Thread = new Thread(CambiarSemaforo1);
            semaforo2Thread = new Thread(CambiarSemaforo2);
            semaforo1Thread.Start();
            semaforo2Thread.Start();
        }
    }

    private void CambiarSemaforo1()
    {
        while (running)
        {
            CambiarColorSemaforo(textrojo1, textamarillo1, textverde1, Color.Red, Color.Yellow, new Point(280, 330));
            Thread.Sleep(4000);

            CambiarColorSemaforo(textamarillo1, textverde1, textrojo1, Color.Yellow, Color.Green, new Point(280, 150));
            Thread.Sleep(4000);

            CambiarColorSemaforo(textverde1, textrojo1, textamarillo1, Color.Green, Color.Red, new Point(280, 0));
            Thread.Sleep(4000);
        }
    }

    private void CambiarSemaforo2()
    {
        while (running)
        {
            CambiarColorSemaforo(textrojo2, textamarillo2, textverde2, Color.Red, Color.Yellow, new Point(430, 170));
            Thread.Sleep(4000);

            CambiarColorSemaforo(textamarillo2, textverde2, textrojo2, Color.Yellow, Color.Green, new Point(430, 50));
            Thread.Sleep(4000);

            CambiarColorSemaforo(textverde2, textrojo2, textamarillo2, Color.Green, Color.Red, new Point(430, 0));
            Thread.Sleep(4000);
        }
    }

    private void CambiarColorSemaforo(TextBox rojo, TextBox amarillo, TextBox verde, Color colorActual, Color colorSiguiente, Point nuevaPosicion)
    {
        if (rojo.BackColor == colorActual)
        {
            rojo.BackColor = Color.Black;
            amarillo.BackColor = colorSiguiente;
            verde.BackColor = Color.Black;
            Invoke(new Action(() =>
            {
                pictureBox1.Location = nuevaPosicion;
            }));
        }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        running = false;
        if (semaforo1Thread != null && semaforo1Thread.IsAlive)
            semaforo1Thread.Join();
        if (semaforo2Thread != null && semaforo2Thread.IsAlive)
            semaforo2Thread.Join();
    }
}

