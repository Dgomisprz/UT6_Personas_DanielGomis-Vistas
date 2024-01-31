using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT6_Personas_DanielGomis_Vistas.Clases
{
    public class Persona : ObservableObject
    {
        private string nombre;

        private int edad;

        private string nacionalidad;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                SetProperty(ref nombre, value, "Nombre");
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                SetProperty(ref edad, value, "Edad");
            }
        }

        public string Nacionalidad
        {
            get
            {
                return nacionalidad;
            }
            set
            {
                SetProperty(ref nacionalidad, value, "Nacionalidad");
            }
        }

        public Persona()
        {
        }

        public Persona(string nombre, int edad, string nacionalidad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nacionalidad = nacionalidad;
        }
    }
}
