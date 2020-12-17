using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_FORM
{
    class calculomagnitudes :fisica
    {
        public calculomagnitudes(decimal g, decimal an, decimal de, decimal ar, decimal vf, decimal vo, decimal v, decimal ma, decimal d, decimal vd, decimal a, decimal f, decimal p, decimal t, decimal po, decimal di, decimal te)
        {
            Volumen = v;
            Masa = ma;
            Densidad = d;
            Velocidad = vd;
            Aceleracion = a;
            Fuerza = f;
            Presion = p;
            Trabajo = t;
            Potencia = po;
            Distancia = di;
            Tiempo = te;
            VelocidadFinal = vf;
            VelocidadInicial = vo;
            Area = ar;
            Desplazamiento = de;
            Angulo = an;
            Gravedad = g;
        }

        public static decimal calDensidad(decimal ma, decimal v)
        {
            return ma / v;
        }
        public static decimal calVelocidad(decimal di, decimal te)
        {
            return di / te;
        }
        public static decimal calAceleracion(decimal vf, decimal vo, decimal t)
        {
            return (vf - vo) / t;
        }
        public static decimal calFuerza(decimal ma, decimal a)
        {
            return ma * a;
        }
        public static decimal calPresion(decimal f, decimal a)
        {
            return f / a;
        }
        public static decimal calTrabajo(decimal f, decimal de)
        {
            return f * de;
        }
        public static decimal calPotencai(decimal t, decimal te)
        {
            return t / te;
        }
        public static decimal calAlturamaxima(decimal vo, decimal an)
        {
            double AM = (Math.Exp((double)(vo)) * Math.Sin((double)vo)) / 2 * 9.8;
            double resultado = AM;
            double resultado1 = (double)resultado;
            return (decimal)resultado1;
            //return num = double.Parse(.Text);
            //resultado = Math.Exp(valor1);
            //LBLNumeros.Text = resultado + "";
        }
        public static decimal calPeso(decimal ma, decimal g)
        {
            decimal gravedad = g;
            const double ga = 9.8;
            g = (decimal)ga;
            return ma * g;
        }
    }
}
