using CommunityToolkit.Mvvm.ComponentModel;
using Personas.classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Vistas.ListadoPersonas
{
    class UserControlListadoPersonasVM: ObservableObject
    {
        private ObservableCollection<Persona> _personas;

        public ObservableCollection<Persona> Personas
        {
            get { return _personas; }
            set { SetProperty(ref _personas, value); }
        }

        public UserControlListadoPersonasVM()
        {
            Personas = new ObservableCollection<Persona>() { new Persona("Pietro", 30, "Italiana"), new Persona("Julia", 25, "Española"), new Persona("Sophie", 35, "Francesa") };
        }
    }
}
