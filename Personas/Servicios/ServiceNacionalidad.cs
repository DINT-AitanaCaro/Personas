using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Servicios
{
    class ServiceNacionalidad
    {
        private ObservableCollection<string>  _nacionalidades = new ObservableCollection<string> { "Italiana", "Española", "Francesa" };
        public ObservableCollection<string> GetNacionalidades()
        {
            return _nacionalidades;
        }

        public void AñadirNacionalidad()
        {

        }
}
}
