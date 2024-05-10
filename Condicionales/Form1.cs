using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcularInteres_Click(object sender, EventArgs e)
        {
            double valor = 0;
            double result = 0;

            valor = Convert.ToDouble(txtValor.Text );
            
            if (valor >= 10000)
            {
                result =  valor + (valor * 0.07);

                txtResultado.Text = Convert.ToString(result);

             }
            if (valor < 10000)
            {
                result = valor + (valor * 0.06);

                txtResultado.Text = Convert.ToString(result);
            }

        }

        private void btnClasificarCalificacion_Click(object sender, EventArgs e)
        {
            double valor = 0;
            String  result ;

            valor = Convert.ToDouble(txtValor.Text);

            if (valor >= 60)
            {

                result = "APROBADO";
                txtResultado.Text = Convert.ToString(result);

            }
            if (valor < 60)
            {

                result = "REPROBADO";
                txtResultado.Text = Convert.ToString(result);
            }
        }

        private void btnCalculoY_Click(object sender, EventArgs e)
        {
            double valor = 0;
            double result = 0;

            valor = Convert.ToDouble(txtValor.Text);

            if (valor >= 1)
            {
                result = Math.Pow (2, valor);

                txtResultado.Text = Convert.ToString(result);

            }
            if (valor < 0)
            {
                result = (valor + 5 );

                txtResultado.Text = Convert.ToString(result);
            }
        }

        private void btnElevar_Click(object sender, EventArgs e)
        {
            double valor = 0;
            double result = 0;

            valor = Convert.ToDouble(txtValor.Text);

            if (valor >= 1)
            {
                result = (valor * valor);

                txtResultado.Text = Convert.ToString(result);

            }
            if (valor < 0)
            {
                result = (valor * valor * valor * valor);

                txtResultado.Text = Convert.ToString(result);
            }
        }
    }
}
