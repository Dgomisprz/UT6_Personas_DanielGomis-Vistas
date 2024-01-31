using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using UT6_Personas_DanielGomis_Vistas.Vistas;

namespace UT6_Personas_DanielGomis_Vistas.Clases
{
    internal class NavigationService
    {
        private static UserControl listadoPersonas = new ListadoPersonasUserControl();

        public UserControl ObtenerNuevaPersona()
        {
            return new Vistas.NuevaPersonaUserControl();
        }

        public UserControl ObtenerListadoPersonas()
        {
            return listadoPersonas;
        }

        public bool? AbrirDialogoNacionalidad()
        {
            DialogoNacionalidad dialogoNacionalidad = new DialogoNacionalidad();
            return dialogoNacionalidad.ShowDialog();
        }

        internal UserControl ObtenerConsultaPersona()
        {
            return new ConsultaPersonaUserControl();
        }
    }
}
