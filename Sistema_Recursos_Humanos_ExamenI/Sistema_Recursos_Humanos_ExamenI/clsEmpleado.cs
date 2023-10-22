using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Recursos_Humanos_ExamenI
{
    internal class clsEmpleado
    {
        public String Cedula { get; set; }
        public String Nombre { get; set;}
        public String Direccion { get; set; }
        public String Telefono { get; set;}
        public double Salario { get;}

        public clsEmpleado(string cedula, string nombre, string direccion, string telefono, double salario)
        {
            Cedula = cedula;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Salario = salario;
        }

    }
}
