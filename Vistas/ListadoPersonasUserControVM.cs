using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para ListadoPersonasUserControl.xaml
    /// </summary>
    public partial class ListadoPersonasUserControl : Page
    {
        internal class ListadoPersonasUserControlVM : ObservableObject
        {
            private readonly PersonasService servicioPersonas;
            private ObservableCollection<Persona> listaPersonas;
            private Persona personaSeleccionada;

            public ObservableCollection<Persona> ListaPersonas
            {
                get => this.listaPersonas;
                set
                {
                    this.SetProperty<ObservableCollection<Persona>>(ref this.listaPersonas, value, nameof(ListaPersonas));
                }
            }

            public Persona PersonaSeleccionada
            {
                get => this.personaSeleccionada;
                set
                {
                    this.SetProperty<Persona>(ref this.personaSeleccionada, value, nameof(PersonaSeleccionada));
                }
            }

            public ListadoPersonasUserControlVM()
            {
                this.servicioPersonas = new PersonasService();
                this.ListaPersonas = this.servicioPersonas.ObtenerPersonas();
                WeakReferenceMessenger.Default.Register<NuevaPersonaMessage>((object)this, (MessageHandler<object, NuevaPersonaMessage>)((r, m) => this.ListaPersonas.Add(m.Value)));
                WeakReferenceMessenger.Default.Register<ListadoPersonasUserControlVM, PersonaSeleccionadaMessage>(this, (MessageHandler<ListadoPersonasUserControlVM, PersonaSeleccionadaMessage>)((r, m) =>
                {
                    if (m.HasReceivedResponse)
                        return;
                    m.Reply(this.PersonaSeleccionada);
                }));
            }
        }
    }
}
