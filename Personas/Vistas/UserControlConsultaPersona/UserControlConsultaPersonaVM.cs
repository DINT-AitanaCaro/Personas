using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Personas.classes;
using Personas.Mensajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Vistas.UserControlConsultaPersona
{
    class UserControlConsultaPersonaVM : ObservableObject
    {
        private Persona _persona;

        public Persona PersonaSeleccionada
        {
            get { return _persona; }
            set { SetProperty(ref _persona, value); }
        }

        public UserControlConsultaPersonaVM()
        {
            //Persona p = WeakReferenceMessenger.Default.Send<PersonaSeleccionadaRequestMessage>();
            PersonaSeleccionada = WeakReferenceMessenger.Default.Send<PersonaSeleccionadaRequestMessage>();
        }
    }
}
