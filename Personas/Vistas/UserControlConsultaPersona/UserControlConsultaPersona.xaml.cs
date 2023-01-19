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

namespace Personas.Vistas.UserControlConsultaPersona
{
    /// <summary>
    /// Lógica de interacción para UserControlConsultaPersona.xaml
    /// </summary>
    public partial class UserControlConsultaPersona : UserControl
    {
        UserControlConsultaPersonaVM vm = new UserControlConsultaPersonaVM();
        public UserControlConsultaPersona()
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
