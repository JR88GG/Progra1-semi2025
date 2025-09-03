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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        //calculo de impuestos del ususario
        double[][] impuestos = new double[][] {
            new double[]{00.1,500,1.5,0},//banda 1
            new double[]{500.01,1000,1.5,3},//banda 2
            new double[]{1000.01,2000,3,3},//banda3
            new double[]{2000.01,3000,6,3},//banda 4
            new double[]{3000.01,6000,9,2},//banda 5
            new double[]{8000.01,18000,15,2},//banda 6
            new double[]{18000.01,30000,39,2},//banda 7
            new double[]{30000.01,60000,63,1},//banda 8
            new double[]{60000.01,100000,93,0.8},//banda 9
            new double[]{100000.01,200000,125,0.7},//banda 10
            new double[]{200000.01,300000,195,0.6},//banda 11
            new double[]{300000.01,400000,255,0.45},//banda 12
            new double[]{400000.01,500000,300,0.4},//banda 13
            new double[]{500000.01,1000000,340,0.30},//banda 14
            new double[]{1000000.01,99999999,490,0.18},//banda 15
        };

        private double Calcular(double monto)
        {
            for (int i = 0; i < impuestos.Length; i++)//se evalua en que rango entra el monto ingresado
            {
                if (monto >= impuestos[i][0] && monto <= impuestos[i][1])
                {
                    double desde = impuestos[i][0];
                    double precio = impuestos[i][2];//se asignan variables a los diferentes indices
                    double adicional = impuestos[i][3];

                    return monto = (monto - desde) / 1000 * adicional + precio; //se calcula el impuesto sobre el monto 
                }

            }
            return 0;//en caso que el monto no entre en ningun rango
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // se obtiene el valor del txtMonto y luego se convierte a tipo decimal y se el aplica la funcion calcular
                    double monto = Convert.ToDouble(txtMonto.Text);
                    double impuesto = Calcular(monto);

                    // Mostrar el resultado en el Label
                    lblMontoCalculado.Text = "Monto calculado: " + impuesto.ToString("C2");
                }
                catch
                {
                    MessageBox.Show("Ingrese un valor numérico válido.");
                    txtMonto.Text = string.Empty;//para limpiar algun dato invalido que no sea tipo entero o decimal
                }


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

  

