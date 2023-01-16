using CommunityToolkit.Mvvm.ComponentModel;
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
        
        private string _nuevaNacionalidad;

        public string NuevaNacionalidad
        {
            get { return _nuevaNacionalidad; }
            set { SetProperty(ref _nuevaNacionalidad, value); }
        }

        public WindowAñadirNacionalidadVM()
        {
            
        }

        public void AñadeNacionalidad()
        {
            //
        }
    }
}
