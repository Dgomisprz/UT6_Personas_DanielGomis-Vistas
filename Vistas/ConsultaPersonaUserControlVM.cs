using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging.Messages;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UT6_Personas_DanielGomis_Vistas.Clases;

namespace UT6_Personas_DanielGomis_Vistas.Vistas
{
    /// <summary>
    /// Lógica de interacción para ConsultaPersonaUserControl.xaml
    /// </summary>
    internal class ConsultaPersonaUserControlVM : ObservableRecipient
    {
        private Persona personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get => this.personaSeleccionada;
            set
            {
                this.SetProperty<Persona>(ref this.personaSeleccionada, value, nameof(PersonaSeleccionada));
            }
        }

        public ConsultaPersonaUserControlVM()
        {
            this.PersonaSeleccionada = (Persona)(RequestMessage<Persona>)WeakReferenceMessenger.Default.Send<PersonaSeleccionadaMessage>();
        }
    }
}
