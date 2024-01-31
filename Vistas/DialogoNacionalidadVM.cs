using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using UT6_Personas_DanielGomis_Vistas.Clases;

namespace UT6_Personas_DanielGomis_Vistas.Vistas
{
    /// <summary>
    /// Lógica de interacción para DialogoNacionalidad.xaml
    /// </summary>
    internal class DialogoNacionalidadVM : ObservableObject
    {
        private string nacionalidad;

        public string Nacionalidad
        {
            get => this.nacionalidad;
            set => this.SetProperty<string>(ref this.nacionalidad, value, nameof(Nacionalidad));
        }

        public void Aceptar()
        {
            WeakReferenceMessenger.Default.Send<NuevaNacionalidadMessage>(new NuevaNacionalidadMessage(this.Nacionalidad));
        }
    }
}
