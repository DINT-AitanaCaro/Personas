using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Personas.classes;
using Personas.Mensajes;
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
        private Persona _personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get { return _personaSeleccionada; }
            set { SetProperty(ref _personaSeleccionada, value); }
        }

        private ObservableCollection<Persona> _personas;

        public ObservableCollection<Persona> Personas
        {
            get { return _personas; }
            set { SetProperty(ref _personas, value); }
        }

        public UserControlListadoPersonasVM()
        {
            PersonaSeleccionada = new Persona();
            Personas = new ObservableCollection<Persona>() { new Persona("Pietro", 30, "Italiana"), new Persona("Julia", 25, "Española"), new Persona("Sophie", 35, "Francesa") };
            WeakReferenceMessenger.Default.Register<NuevaPersonaValueChangedMessage>(this, (r, m) =>
            {
                Personas.Add(m.Value);
            });

            WeakReferenceMessenger.Default.Register<UserControlListadoPersonasVM, PersonaSeleccionadaRequestMessage>(this, (r, m) =>
            {
                m.Reply(r.PersonaSeleccionada);
            });
        }
    }
}
