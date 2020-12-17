using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_FORM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Resolver()
        {
            if (TextTemperatura1.Text != "" && TextTemperatura1.Text != "-")

            {
                double dato = Convert.ToDouble(TextTemperatura1.Text);
                int datoInicial = cboEntrada.SelectedIndex;
                int datoFinal = cboSalida.SelectedIndex;

                switch (datoInicial)
                {
                    case 0:
                        if (datoFinal == 0)
                        {
                            cboEntrada.SelectedIndex = 1;
                        }
                        if (datoFinal == 1)
                        {
                            TextTemperaturaResultado.Text = (dato * 1.8 + 32).ToString();
                        }
                        if (datoFinal == 2)
                        {
                            TextTemperaturaResultado.Text = (dato + 273.15).ToString();
                        }
                        break;
                    case 1:
                        if (datoFinal == 0)
                        {
                            TextTemperaturaResultado.Text = ((dato - 32) / 1.8).ToString();
                        }
                        if (datoFinal == 1)
                        {
                            cboEntrada.SelectedIndex = 2;
                        }
                        if (datoFinal == 2)
                        {
                            TextTemperaturaResultado.Text = (((dato - 32) / 1.8) + 173.15).ToString();
                        }
                        break;
                    case 2:
                        if (datoFinal == 0)
                        {
                            TextTemperaturaResultado.Text = (dato - 273.15).ToString();
                        }
                        if (datoFinal == 1)
                        {
                            TextTemperaturaResultado.Text = ((dato - 273.15) * 1.8 + 32).ToString();
                        }
                        if (datoFinal == 2)
                        {
                            cboEntrada.SelectedIndex = 0;
                        }
                        break;


                }



            }
            else
            {
                TextTemperatura1.Clear();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
           Resolver();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            TextTemperatura1.Clear();
            TextTemperaturaResultado.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Visible = true;
            Visible = false;
        }
    }
}
