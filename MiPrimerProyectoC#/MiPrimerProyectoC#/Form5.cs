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
        double media(int[] serie)
        {
           //sin LINQ
            //int n = serie.Length;
            //double suma = 0;

            //for (int i = 0; i < n; i++)
            //{
               // suma += int.Parse(serie[i]);
            //}
              //      return suma / n;
            //con LINQ
            return serie.Average();
        }
        double tipica(int[] serie,double m)
        {
            //sin LINQ
            // double tipica = 0;
            //int n = serie.Length;
            //for (int i = 0; i < n; i++)
            //{
            // int num = int.Parse(serie[i]);
            //tipica += Math.Pow(num - m, 2);
            //}
            //tipica = Math.Sqrt(tipica / n);
            //return tipica;
            //Con LINQ
            return Math.Sqrt(serie.Average(n=>Math.Pow(n -m,2)));
        }
        double armonica(int[] serie)
        {
            int n = serie.Length;
            //sin LINQ
            //double mediaArmonica = 0;
            //int n = serie.Length;
            //for (int i = 0; i < n; i++)
            //{
            //  mediaArmonica += 1 / double.Parse(serie[i]);
            //}
            //return n / mediaArmonica;
            return n / serie.Sum(num => 1.0 / num);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //int[] serie = txtSerie.Text.Split(',').Select(n=>int.Parse(n)). ToArray(); //5,8,1,9 => ["5", "8", "1", "9"]
            int[] serie = txtSerie.Text.Split(',').Select(n => int.Parse(n)).ToArray(); ;

            double mediaAritmetica = media(serie);
            double desviacionTipica = tipica(serie, mediaAritmetica);
            double mediaArmonica = armonica(serie);
            //Mostramos los valores en los labels
            lblMedia.Text = "Media: " + mediaAritmetica.ToString();
            lblTipica.Text = "Tipica: " + desviacionTipica.ToString();
            lblArmonica.Text = "Armonica: " + mediaArmonica.ToString();

        }
    }
    }

