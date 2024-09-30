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
    /// Lógica de interacción para Crear.xaml
    /// </summary>
    public partial class Crear : Window
    {
        public Crear()
        {
            InitializeComponent();
        }

        private void btnCrearFichero(object sender, RoutedEventArgs e)
        {
            String contenido = this.txbContent.Text;
            String nombre = this.txbNombreFichero.Text;

            if (nombre.Length > 0)
            {
                if (contenido.Length > 0)
                {
                    if (File.Exists(nombre) == false)
                    {
                        using (FileStream fs = new FileStream(nombre, FileMode.Create, FileAccess.Write))
                        using (StreamWriter writer = new StreamWriter(fs))
                        {
                            writer.Write(contenido);
                            MessageBox.Show("Archivo creado correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                            txbContent.Text = "";
                            txbNombreFichero.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("El fichero ya existe.");
                    }
                }
                else
                {
                    MessageBox.Show("Debes introducir contenido dentro.", "Información", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }
            else
            {
                MessageBox.Show("Debes crear un archivo.", "Información", MessageBoxButton.OK, MessageBoxImage.Warning);
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
    }
}
