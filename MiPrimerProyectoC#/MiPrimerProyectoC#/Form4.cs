using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyectoC_
{
    public partial class Form4 : Form
    {
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double[][] valores = new double[][]
        {
            new double[]{1, 0.0929, 0.6987, 0.8361, 437.5, 6988, 10000}, //Área
        };
        private double conversion(double cantidad,int tipo, int a)
        {
            // Normalizar la cantidad al valor base (índice 0 en la fila de "Área")
            double m = cantidad * valores[0][tipo];

            // Convertir de la base a la unidad deseada
            double resultado = m / valores[0][a];

            return resultado;

        }
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {   //obteniendo valores para realizar la conversion
                double cantidad = double.Parse(txtCantidadConversor.Text);
                int tipo = cboMedidaOrigen.SelectedIndex;
                int a = cboMedidaAObtener.SelectedIndex;

                double respuesta = conversion(cantidad, tipo, a);

                lblConversion.Text = "Conversion: " + respuesta.ToString("N2");
            }
            catch (Exception er)
            {
                lblConversion.Text = "Error: " + er.Message + " (solo valores válidos)";
            }
        }
    }
}