using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace Ficheros
{
    /// <summary>
    /// Lógica de interacción para Comprobar.xaml
    /// </summary>
    public partial class Comprobar : Window
    {
        public Comprobar()
        {
            InitializeComponent();
        }

        private void VisionadoArchivo1(object sender, RoutedEventArgs e)
        {
            string nombreArchivo = this.txbNombreArchivo.Text;
            txbContenidoVisionado.Text = "";

            if (nombreArchivo.Length > 0)
            {
                if (File.Exists(nombreArchivo) == true)
                {
                    using (StreamReader reader = new StreamReader(nombreArchivo))
                    {
                        string linea;
                        while ((linea = reader.ReadLine()) != null)
                        {
                            txbContenidoVisionado.AppendText(linea);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ese archivo no existe o no es encontrado.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Necesitas introducir un nombre de archivo.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }




        }

        private void VisionadoArchivo2(object sender, RoutedEventArgs e)
        {
            string nombreArchivo = this.txbNombreArchivo.Text;
            txbContenidoVisionado.Text = "";

            if (nombreArchivo.Length > 0)
            {
                if (File.Exists(nombreArchivo) == true)
                {
                    string contenido = File.ReadAllText(nombreArchivo);
                    txbContenidoVisionado.Text = "Contenido: \n";
                    txbContenidoVisionado.AppendText(contenido);
                }
                else
                {
                    MessageBox.Show("Ese archivo no existe o no es encontrado.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Necesitas introducir un nombre de archivo.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void VisionadoArchivo3(object sender, RoutedEventArgs e)
        {
            string nombreArchivo = this.txbNombreArchivo.Text;
            txbContenidoVisionado.Text = "";

            if (nombreArchivo.Length > 0)
            {
                if (File.Exists(nombreArchivo) == true)
                {
                    string[] lineas = File.ReadAllLines(nombreArchivo);
                    foreach (string linea in lineas)
                    {
                        txbContenidoVisionado.AppendText(linea);
                    }
                }
                else
                {
                    MessageBox.Show("Ese archivo no existe o no es encontrado.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Necesitas introducir un nombre de archivo.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void VisionadoArchivo4(object sender, RoutedEventArgs e)
        {
            string nombreArchivo = this.txbNombreArchivo.Text;
            txbContenidoVisionado.Text = "";

            if (nombreArchivo.Length > 0)
            {
                if (File.Exists(nombreArchivo) == true)
                {
                    foreach (string linea in File.ReadLines(nombreArchivo))
                    {
                        txbContenidoVisionado.AppendText(linea);
                    }
                }
                else
                {
                    MessageBox.Show("Ese archivo no existe o no es encontrado.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Necesitas introducir un nombre de archivo.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnCerrarPrograma(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que quieres cerrar el programa?", "Atención", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBorrarContenido_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que quieres borrar el contenido?", "Atención", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                txbNombreArchivo.Text = "";
                txbContenidoVisionado.Text = "";
            }
        }
    }
}

