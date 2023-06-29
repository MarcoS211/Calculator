using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long numero1 = 0;
        long numero2 = 0;
        String operacion = "";
        String Memory = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void boton1_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 1;
                txtResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 1;
                txtResultado.Text = numero2.ToString();
            }
        }

        private void boton2_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 2;
                txtResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 2;
                txtResultado.Text = numero2.ToString();
            }
        }

        private void boton3_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 3;
                txtResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 3;
                txtResultado.Text = numero2.ToString();
            }
        }

        private void boton4_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 4;
                txtResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 4;
                txtResultado.Text = numero2.ToString();
            }
        }

        private void boton5_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 5;
                txtResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 5;
                txtResultado.Text = numero2.ToString();
            }
        }

        private void boton6_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 6;
                txtResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 6;
                txtResultado.Text = numero2.ToString();
            }
        }

        private void boton7_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 7;
                txtResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 7;
                txtResultado.Text = numero2.ToString();
            }
        }

        private void boton8_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 8;
                txtResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 8;
                txtResultado.Text = numero2.ToString();
            }
        }

        private void boton9_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 9;
                txtResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 9;
                txtResultado.Text = numero2.ToString();
            }
        }

        private void boton0_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 0;
                txtResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 0;
                txtResultado.Text = numero2.ToString();
            }
        }

        private void botonSumar_Click(object sender, RoutedEventArgs e)
        {
            operacion = "+";
            txtResultado.Text = "+";
        }

        private void botonRestar_Click(object sender, RoutedEventArgs e)
        {
            operacion = "-";
            txtResultado.Text = "-";
        }

        private void botonMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            operacion = "*";
            txtResultado.Text = "*";
        }

        private void botonDividir_Click(object sender, RoutedEventArgs e)
        {
            operacion = "/";
            txtResultado.Text = "/";
        }

        private void botonResultado_Click(object sender, RoutedEventArgs e)
        {
            switch (operacion)
            {
                case "+":
                    txtResultado.Text = (numero1 + numero2).ToString();
                    break;
                case "-":
                    txtResultado.Text = (numero1 - numero2).ToString();
                    break;
                case "*":
                    txtResultado.Text = (numero1 * numero2).ToString();
                    break;
                case "/":
                    txtResultado.Text = (numero1 / numero2).ToString();
                    break;

            }
            Memory = txtResultado.Text;
            numero1 = 0;
            numero2 = 0;
            operacion = "";
        }

        private void botonPositivoNegativo_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = (-1 * int.Parse(txtResultado.Text)).ToString();
        }

        private void botonCE_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = 0;
            }
            else
            {
                numero2 = 0;
            }
            txtResultado.Text = "0";
            

        }

        private void botonC_Click(object sender, RoutedEventArgs e)
        {
                numero1 = 0;
                numero2 = 0;
                operacion = "";
                Memory = "";
                txtResultado.Text = "M Borrado";
     
        }

        private void botonRetroceder_Click(object sender, RoutedEventArgs e)
        {
            {
                if (operacion == "")
                {
                    numero1 = (numero1 / 10);
                    txtResultado.Text = numero1.ToString();
                }
                else
                {
                    numero2 = (numero2 / 10);
                    txtResultado.Text = numero2.ToString();
                }
            }
        }

        private void botonMemory_Click(object sender, RoutedEventArgs e)
        {
            if (Memory != "")
            {
                txtResultado.Text = Memory;
            }
            else
            {
                txtResultado.Text = " ";
            }     
                
        }
    }
}
