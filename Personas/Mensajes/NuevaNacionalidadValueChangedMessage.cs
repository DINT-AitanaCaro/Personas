using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Mensajes
{
    public class NuevaNacionalidadValueChangedMessage : ValueChangedMessage<string>
    {
        public NuevaNacionalidadValueChangedMessage(string nacionalidad) : base(nacionalidad) { }
    }
}
