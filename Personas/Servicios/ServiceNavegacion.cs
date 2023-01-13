using Personas.Vistas.AñadirNacionalidad;
using Personas.Vistas.ListadoPersonas;
using Personas.Vistas.NuevaPersona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas.Servicios
{
    public class ServiceNavegacion
    {
        public UserControl CargaUCNuevaPersona()
        {
            return new UserControlNuevaPersona();
        }

        public UserControl CargarUCListadoPersonas()
        {
            return new UserControlListadoPersonas();
        }

        public bool? AbrirVentanaAñadirNacionalidad()
        {
            AñadirNacionalidad nueva = new AñadirNacionalidad();
            return nueva.ShowDialog();
        }

    }
}
