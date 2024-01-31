using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace UT6_Personas_DanielGomis_Vistas.Clases
{
    internal class MainWindowVM : ObservableObject
    {
        private readonly NavigationService navegacion;

        private UserControl contenidoVentana;

        public RelayCommand AbrirNuevaPersonaCommand { get; }

        public RelayCommand AbrirListadoPersonasCommand { get; }

        public RelayCommand AbrirConsultaPersonaCommand { get; }

        public UserControl ContenidoVentana
        {
            get
            {
                return contenidoVentana;
            }
            set
            {
                SetProperty(ref contenidoVentana, value, "ContenidoVentana");
            }
        }

        public MainWindowVM()
        {
            navegacion = new NavigationService();
            AbrirListadoPersonasCommand = new RelayCommand(AbrirListadoPersonas);
            AbrirNuevaPersonaCommand = new RelayCommand(AbrirNuevaPersona);
            AbrirConsultaPersonaCommand = new RelayCommand(AbrirConsultaPersona);
        }

        private void AbrirConsultaPersona()
        {
            ContenidoVentana = navegacion.ObtenerConsultaPersona();
        }

        private void AbrirNuevaPersona()
        {
            ContenidoVentana = navegacion.ObtenerNuevaPersona();
        }

        private void AbrirListadoPersonas()
        {
            ContenidoVentana = navegacion.ObtenerListadoPersonas();
        }
    }
}
