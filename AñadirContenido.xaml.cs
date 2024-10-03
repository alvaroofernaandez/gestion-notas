using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
    public partial class AñadirContenido : Window
    {
        public AñadirContenido()
        {
            InitializeComponent();
        }

        private void AgregarLinea_Click(object sender, RoutedEventArgs e)
        {
            string nombreArchivo = this.txbNombreArchivo.Text;
            string nuevaLinea = this.txbLineaNueva.Text;

            if (nombreArchivo.Length > 0)
            {
                if (File.Exists(nombreArchivo))
                {
                    if (!string.IsNullOrWhiteSpace(nuevaLinea))
                    {
                        string contenido = File.ReadAllText(nombreArchivo);

                        if (!contenido.EndsWith(Environment.NewLine))
                        {
                            contenido += Environment.NewLine;
                        }

                        contenido += nuevaLinea + Environment.NewLine;

 
                        File.WriteAllText(nombreArchivo, contenido);

                        MessageBox.Show("Línea agregada con éxito.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                        txbLineaNueva.Clear();
                    }
                    else
                    {
                        MessageBox.Show("La línea nueva no puede estar vacía.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ese archivo no existe o no fue encontrado.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Necesitas introducir un nombre de archivo.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnCerrarPrograma_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que quieres cerrar el programa?", "Aviso", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBorrarContenido_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que quieres borrar el contenido?", "Aviso", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                txbNombreArchivo.Text = "";
                txbLineaNueva.Text = "";
            }
        }
    }
}
