using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        public RelayCommand CommandNuevaNacionalidad { get; }
        public RelayCommand CommandNuevaPersona { get; }
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
            CommandNuevaNacionalidad = new RelayCommand(AbreVentanaAñadirNacionalidad);
            CommandNuevaPersona = new RelayCommand(CrearNuevaPersona);
        }

        public void AbreVentanaAñadirNacionalidad()
        {
            bool? resultado = sn.AbrirVentanaAñadirNacionalidad();
        }

        public void CrearNuevaPersona()
        {

        }
    }
}
