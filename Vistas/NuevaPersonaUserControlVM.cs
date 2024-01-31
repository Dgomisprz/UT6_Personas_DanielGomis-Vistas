using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UT6_Personas_DanielGomis_Vistas.Clases;

namespace UT6_Personas_DanielGomis_Vistas.Vistas
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    internal class NuevaPersonaUserControlVM : ObservableObject
    {
        private readonly NavigationService navegacion;

        private Persona nuevaPersona;

        private ObservableCollection<string> listaNacionalidades;

        public Persona NuevaPersona
        {
            get
            {
                return nuevaPersona;
            }
            set
            {
                SetProperty(ref nuevaPersona, value, "NuevaPersona");
            }
        }

        public ObservableCollection<string> ListaNacionalidades
        {
            get
            {
                return listaNacionalidades;
            }
            set
            {
                SetProperty(ref listaNacionalidades, value, "ListaNacionalidades");
            }
        }

        public RelayCommand AceptarNuevaPersonaCommand { get; }

        public RelayCommand NuevaNacionalidadCommand { get; }

        public NuevaPersonaUserControlVM()
        {
            navegacion = new NavigationService();
            NuevaPersona = new Persona();
            ListaNacionalidades = new ObservableCollection<string> { "Italiana", "Española", "Francesa" };
            AceptarNuevaPersonaCommand = new RelayCommand(AñadirPersona);
            NuevaNacionalidadCommand = new RelayCommand(AñadirNacionalidad);
            WeakReferenceMessenger.Default.Register(this, delegate (object r, NuevaNacionalidadMessage m)
            {
                ListaNacionalidades.Add(m.Value);
            });
        }

        private void AñadirNacionalidad()
        {
            navegacion.AbrirDialogoNacionalidad();
        }

        private void AñadirPersona()
        {
            WeakReferenceMessenger.Default.Send(new NuevaPersonaMessage(NuevaPersona));
        }
    }
}
