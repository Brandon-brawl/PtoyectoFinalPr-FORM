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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularDensidad_Click(object sender, EventArgs e)
        {
            decimal resultado = calculomagnitudes.calDensidad(numMasa.Value, numVolumen.Value);
            lblResultadodensidad.Text = resultado + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Visible = true;
            Visible = false;
        }

        private void btncalcularvelocidad_Click(object sender, EventArgs e)
        {
            decimal resultado = calculomagnitudes.calVelocidad(numDistanciav.Value, numTiempov.Value);
            lblResultadovelocidad.Text = resultado + "";
        }

        private void btnCalcularaceleracion_Click(object sender, EventArgs e)
        {
            decimal resultado = calculomagnitudes.calAceleracion(numVelocidadfinal.Value, numVelocidadinicial.Value, numAtiempo.Value);
            label7lblResultadoAceleracion.Text = resultado + "";
        }

        private void btncaluclarfuerza_Click(object sender, EventArgs e)
        {
            decimal resultado = calculomagnitudes.calFuerza(numFaceleracion.Value, numFmasa.Value);
            lblresultadofuerza.Text = resultado + "";
        }

        private void btnCalcularPresion_Click(object sender, EventArgs e)
        {
            decimal resultado = calculomagnitudes.calPresion(numPfuerza.Value, numPaceleracion.Value);
            lblResultadoPresion.Text = resultado + "";
        }

        private void btnCalcularPotencia_Click(object sender, EventArgs e)
        {
            decimal resultado = calculomagnitudes.calPotencai(numPotrabajo.Value, numPotiempo.Value);
            lblResultadopotencia.Text = resultado + "";
        }

        private void btnCalcularAlturamaxima_Click(object sender, EventArgs e)
        {
            decimal resultado = calculomagnitudes.calAlturamaxima(numHvelocidadinicial.Value, numHseno.Value);
            lblResultadoalturamaxima.Text = resultado + "";
        }

        private void btnPcalpeso_Click(object sender, EventArgs e)
        {
            decimal resultado = calculomagnitudes.calPeso(numPmasa.Value, numPgravedad.Value);
            lblResultadoPeso.Text = resultado + "";
        }
    }
}
