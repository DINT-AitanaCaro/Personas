using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.classes
{
    public class Persona : ObservableObject
    {

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { SetProperty(ref _nombre, value); }
        }

        private int? _edad;

        public int? Edad
        {
            get { return _edad; }
            set { SetProperty(ref _edad, value); }
        }

        
        private string _nacionalidad;

        public Persona()
        {
            Edad = null;
        }

        public Persona(string nombre, int edad, string nacionalidades)
        {
            _nombre = nombre;
            _edad = edad;
            _nacionalidad = nacionalidades;
        }

        public string Nacionalidad
        {
            get { return _nacionalidad; }
            set { SetProperty(ref _nacionalidad, value); }
        }
    }
}
