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

namespace PracxticaInterfazUsuario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            porcentaje.Text =
                Math.Round(slider.Value).ToString() + "%";

            float total = float.Parse(caja.Text);
            float porcentajePropina = (float)Math.Round(slider.Value);
            float propina = total * (porcentajePropina / 100);
            float totalPropina = total + propina;

            cajaPropina.Text = "$" + totalPropina.ToString();


            
        }
    }
}
