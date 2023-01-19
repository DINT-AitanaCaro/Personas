using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Personas.Mensajes;
using Personas.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Vistas.AñadirNacionalidad
{
    class WindowAñadirNacionalidadVM : ObservableObject
    {
        //public RelayCommand CommandNuevaNacionalidad { get; }
        private string _nuevaNacionalidad;

        public string NuevaNacionalidad
        {
            get { return _nuevaNacionalidad; }
            set { SetProperty(ref _nuevaNacionalidad, value); }
        }

        public WindowAñadirNacionalidadVM()
        {
            //CommandNuevaNacionalidad = new RelayCommand(AñadeNacionalidad);
        }

        public void AñadeNacionalidad()
        {
            WeakReferenceMessenger.Default.Send(new NuevaNacionalidadValueChangedMessage(NuevaNacionalidad));
        }
    }
}
