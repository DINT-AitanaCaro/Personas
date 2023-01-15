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
    class AñadirNacionalidadVM :ObservableObject
    {
        private string _nuevaNacionalidad;

        public string NuevaNacionalidad
        {
            get { return _nuevaNacionalidad; }
            set { SetProperty(ref _nuevaNacionalidad, value); }
        }

        private ObservableCollection<string> _nacionalidades;

        public ObservableCollection<string> Nacionalidades
        {
            get { return _nacionalidades; }
            set { SetProperty(ref _nacionalidades,value); }
        }

        private ServiceNacionalidad serviceNacionalidad;
        public AñadirNacionalidadVM()
        {
            serviceNacionalidad = new ServiceNacionalidad();
            Nacionalidades = serviceNacionalidad.GetNacionalidades();
        }

        public void AñadeNacionalidad()
        {
            serviceNacionalidad.GetNacionalidades().Add(NuevaNacionalidad);
        }
    }
}
