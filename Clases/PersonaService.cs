using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT6_Personas_DanielGomis_Vistas.Clases
{
    nternal class PersonasService
    {
        public ObservableCollection<Persona> ObtenerPersonas()
        {
            ObservableCollection<Persona> observableCollection = new ObservableCollection<Persona>();
            observableCollection.Add(new Persona("Pietro", 30, "Italiana"));
            observableCollection.Add(new Persona("Julia", 25, "Española"));
            observableCollection.Add(new Persona("Sophie", 35, "Francesa"));
            return observableCollection;
        }
    }
}
