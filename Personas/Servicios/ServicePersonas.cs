using Personas.classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Servicios
{
    class ServicePersonas
    {
        private ObservableCollection<Persona> _personas = new ObservableCollection<Persona>() { new Persona("Pietro", 30, "Italiana"), new Persona("Julia", 25, "Española"), new Persona("Sophie", 35, "Francesa") };
        public ObservableCollection<Persona> GetPersonas()
        {
            return _personas;
        }

    }
}
