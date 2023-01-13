using CommunityToolkit.Mvvm.ComponentModel;
using Personas.classes;
using Personas.Servicios;
using Personas.Vistas.ListadoPersonas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas.Vistas.MainWindow
{
    class MainWindowVM : ObservableObject
    {
        /*
        private ObservableCollection<Persona> _personas;

        public ObservableCollection<Persona> Personas
        {
            get { return _personas; }
            set { SetProperty(ref _personas, value); }
        }
        */
        private ServiceNavegacion sn;
        private UserControlListadoPersonas ucnuevapersona;
        private UserControl contenidoMostrar;

        public UserControl ContenidoMostrar
        {
            get { return contenidoMostrar; }
            set { SetProperty(ref contenidoMostrar, value); }
        }
        public MainWindowVM()
        {
            sn = new ServiceNavegacion();
            ucnuevapersona = new UserControlListadoPersonas();
            //Personas = new ObservableCollection<Persona>() { new Persona("Pietro", 30, "Italiana") };
        }

        public void CargarUCNuevaPersona()
        {
            ContenidoMostrar = sn.CargaUCNuevaPersona();
        }

        public void CargarUCListadoPersonas()
        {
            ContenidoMostrar = ucnuevapersona;
        }
    }
}
