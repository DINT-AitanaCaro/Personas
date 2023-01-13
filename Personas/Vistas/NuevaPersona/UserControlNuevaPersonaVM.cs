using CommunityToolkit.Mvvm.ComponentModel;
using Personas.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Vistas.NuevaPersona
{
    class UserControlNuevaPersonaVM : ObservableObject
    {
        private ServiceNavegacion sn;
        private ObservableCollection<string> _nacionalidades;

        public ObservableCollection<string> Nacionalidades
        {
            get { return _nacionalidades; }
            set { SetProperty(ref _nacionalidades, value); }
        }

        public UserControlNuevaPersonaVM()
        {
            sn = new ServiceNavegacion();
            Nacionalidades = new ObservableCollection<string> { "Italiana", "Española", "Francesa" };
        }

        public void AbreVentanaAñadirNacionalidad()
        {
            if(sn.AbrirVentanaAñadirNacionalidad() == true)
            {

            } else
            {

            }
        }
    }
}
