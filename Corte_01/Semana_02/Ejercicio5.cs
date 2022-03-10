using System;

namespace Ejercicio_5
{
    public partial class Form
    {
        int Fechaante,Fechaactu,Año,Mes,Dias;
        private object textBox5;
        private object textBox4;
        private object textBox3;
        private object textBox1;
        private object textBox2;

        public Form()
        {

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void botton1_Click(object sender, EventArgs e)
        {
            Fechaante = Convert.ToInt32(textBox1.Text);
            Fechaactu = Convert.ToInt32(textBox2.Text);

            Año = Fechaactu - Fechaante;
            textBox3.Text = Año.ToString();

            Mes = Año * 12;
            textBox4.Text = Mes.ToString();

            Dias = Año * 365;
            textBox5.Text = Dias.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}