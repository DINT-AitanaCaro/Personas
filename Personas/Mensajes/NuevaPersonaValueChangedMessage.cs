using CommunityToolkit.Mvvm.Messaging.Messages;
using Personas.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Mensajes
{
    public class NuevaPersonaValueChangedMessage : ValueChangedMessage<Persona>
    {
        public NuevaPersonaValueChangedMessage(Persona persona) : base(persona) { }
    }
}
