using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ficheros
{
    public partial class EliminarContenido : Window
    {
        public EliminarContenido()
        {
            InitializeComponent();
        }

        private void EliminarLinea_Click(object sender, RoutedEventArgs e)
        {
            string nombreArchivo = this.txbNombreArchivo.Text;

            if (!string.IsNullOrWhiteSpace(nombreArchivo))
            {
                if (File.Exists(nombreArchivo))
                {
                    string[] lineas = File.ReadAllLines(nombreArchivo);

                    if (lineas.Length > 0)
                    {
                        string[] nuevasLineas = lineas.Take(lineas.Length - 1).ToArray();

                        File.WriteAllLines(nombreArchivo, nuevasLineas);

                        MessageBox.Show("Última línea eliminada con éxito.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("El archivo está vacío, no hay líneas para eliminar.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
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
            var result = MessageBox.Show("¿Seguro que quieres cerrar el programa?", "Atención", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBorrarContenido_Click(object sender, RoutedEventArgs e)
        {
            txbNombreArchivo.Text = "";
        }
    }
}
