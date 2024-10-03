using System.Text;
using System.Windows;
using System;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ficheros
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void btnAbrirCrear_Click(object sender, RoutedEventArgs e)
        {
            Crear ventanaCrear = new Crear();
            ventanaCrear.Show();
        }

        private void btnAbrirComprobar_Click(object sender, RoutedEventArgs e)
        {
            Comprobar ventanaComprobar = new Comprobar();
            ventanaComprobar.Show();
        }

        private void btnCerrarPrograma_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que quieres cerrar el programa?", "Atención", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAbrirAñadirContenido_Click(object sender, RoutedEventArgs e)
        {
            AñadirContenido ventanaAñadirContenido = new AñadirContenido();
            ventanaAñadirContenido.Show();
        }

        private void btnAbrirEliminarContenido_Click(object sender, RoutedEventArgs e)
        {
            EliminarContenido ventanaEliminarContenido = new EliminarContenido();
            ventanaEliminarContenido.Show();
        }
    }
}