using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT6_Personas_DanielGomis_Vistas.Clases
{
    public class NuevaPersonaMessage : ValueChangedMessage<Persona>
    {
        public NuevaPersonaMessage(Persona nuevaPersona)
          : base(nuevaPersona)
        {
        }
    }
}
