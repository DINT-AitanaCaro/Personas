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
using System.Windows.Shapes;

namespace Personas.Vistas.AñadirNacionalidad
{
    /// <summary>
    /// Lógica de interacción para AñadirNacionalidad.xaml
    /// </summary>
    public partial class AñadirNacionalidad : Window
    {
        WindowAñadirNacionalidadVM vm = new WindowAñadirNacionalidadVM();
        public AñadirNacionalidad()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            vm.AñadeNacionalidad();
            DialogResult = true;
        }
    }
}
