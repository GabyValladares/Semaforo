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

namespace Semaforo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int bandera = 1;
        private void btnEncender_Click(object sender, RoutedEventArgs e)
        {
            
            if (bandera == 1)
            {
                elpsRojo.Fill = Brushes.Red;
                elpsAmarillo.Fill = Brushes.White;
                elpsVerde.Fill = Brushes.White;
                bandera++;
            }
            else if (bandera == 2)
            {
                elpsRojo.Fill = Brushes.White;
                elpsAmarillo.Fill = Brushes.Yellow;
                elpsVerde.Fill = Brushes.White;
                bandera++;
            }
            else if (bandera == 3)
            {
                elpsRojo.Fill = Brushes.White;
                elpsAmarillo.Fill = Brushes.White;
                elpsVerde.Fill = Brushes.Green;
                bandera = 1;

            }
        }
    }
}
