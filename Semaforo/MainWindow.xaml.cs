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
                elps1.Fill = Brushes.White;
                elps2.Fill = Brushes.Black;
                elps3.Fill = Brushes.Black;
                elps4.Fill = Brushes.Black;
                elps5.Fill = Brushes.Black;
                elps6.Fill = Brushes.Black;
                bandera++;
            }
            else if (bandera == 2)
            {
                
                elps1.Fill = Brushes.Black;
                elps2.Fill = Brushes.Gainsboro;
                elps3.Fill = Brushes.Black;
                elps4.Fill = Brushes.Black;
                elps5.Fill = Brushes.Black;
                elps6.Fill = Brushes.Black;
                bandera++;
            }
            else if (bandera == 3)
            {
                elps1.Fill = Brushes.Black;
                elps2.Fill = Brushes.Black;
                elps3.Fill = Brushes.LightGray;
                elps4.Fill = Brushes.Black;
                elps5.Fill = Brushes.Black;
                elps6.Fill = Brushes.Black;
                bandera++;

            }
            else if (bandera == 4)
            {
                elps1.Fill = Brushes.Black;
                elps2.Fill = Brushes.Black;
                elps3.Fill = Brushes.Black;
                elps4.Fill = Brushes.Silver;
                elps5.Fill = Brushes.Black;
                elps6.Fill = Brushes.Black;
                bandera++;

            }
            else if (bandera == 5)
            {
                elps1.Fill = Brushes.Black;
                elps2.Fill = Brushes.Black;
                elps3.Fill = Brushes.Black;
                elps4.Fill = Brushes.Black;
                elps5.Fill = Brushes.DarkGray;
                elps6.Fill = Brushes.Black;
                bandera++;

            }
            else if (bandera == 6)
            {
                elps1.Fill = Brushes.Black;
                elps2.Fill = Brushes.Black;
                elps3.Fill = Brushes.Black;
                elps4.Fill = Brushes.Black;
                elps5.Fill = Brushes.Black;
                elps6.Fill = Brushes.Gray;
                bandera=1;

            }
        }
    }
}
