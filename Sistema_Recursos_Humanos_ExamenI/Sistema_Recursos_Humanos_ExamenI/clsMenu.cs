using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Recursos_Humanos_ExamenI
{
    internal class clsMenu
    {
        private List<clsEmpleado> empleados = new List<clsEmpleado>();

        // Primer metodo para mostrar el menu principal

        public void MostrarMenu()
        {
            Console.WriteLine("*************** Examen de Programacion en C#: Sistema de Recursos Humanos *************** ");
            Console.WriteLine("1. Agregar Nuevo Empleado");
            Console.WriteLine("2. Consultar Empleado");
            Console.WriteLine("3. Modificar Empleado");
            Console.WriteLine("4. Borrar Empleado");
            Console.WriteLine("5. Inicializar Arreglos");
            Console.WriteLine("6. Reportes");
            Console.WriteLine("7. Salir");
        }

        public void AgregarEmpleadoNuevo()
        {
            // metodo para agregar un nuevo empleado
            Console.WriteLine("Ingrese los datos del empleado:");
            Console.WriteLine("Cedula: ");
            string cedula = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Direccion: ");
            string direccion = Console.ReadLine();
            Console.WriteLine("Telefono: ");
            string telefono = Console.ReadLine();
            Console.WriteLine("Salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            clsEmpleado empleado = new clsEmpleado(cedula, nombre, direccion, telefono, salario);
            empleados.Add(empleado);
            Console.WriteLine("Empleado Agregado Correctamente!");

        }

        public void ConsultarEmpleado()
        {
            // Metodo para consultar empleados
            Console.WriteLine("********** Lista de Empleados **********");
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"Cedula: {empleado.Cedula}| Nombre: {empleado.Nombre}| Direccion: {empleado.Direccion}| Telefono: {empleado.Telefono}| Salario: {empleado.Salario}");
            }
        }

        public void ModificarEmpleado()
        {
            //Metodo para modificar un empleado
            Console.WriteLine("Ingrese la ceduda del empleado a modificar: ");
            string cedula = Console.ReadLine();
            clsEmpleado empleado = empleados.Find(e => e.Cedula == cedula);

            if (empleado != null)
            {
                Console.WriteLine("Ingrese los nuevos datos del empleado");
                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Direccion: ");
                string direccion = Console.ReadLine();
                Console.WriteLine("Telefono: ");
                string telefono = Console.ReadLine();
                Console.WriteLine("Salario: ");
                double salario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Empleado modificado correctamente");
            }
            else
            {
                Console.WriteLine("Empleado no Encontrado");
            }
        }

        public void BorrarEmpleado()
        {
            // Metodo para borar un empelado
            Console.WriteLine("Ingrese la ceduda del empleado a borrar: ");
            string cedula = Console.ReadLine();
            clsEmpleado empleado = empleados.Find(e => e.Cedula == cedula);

            if (empleado != null)
            {
                empleados.Remove(empleado);
                Console.WriteLine("Empleado Eliminado Correctamente");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado");
            }
        }

        public void InicializarArreglos()
        {
            // Metodo para inicializar arreglos
            empleados.Clear();
            Console.WriteLine("Arreglos de empleados Inicializados");
        }

        public void Reportes()
        {
            // Metodo para gestionar los reportes
            int opcion;

            do
            {
                Console.WriteLine("*************** Menu de Reportes ***************");
                Console.WriteLine("1. Consultar empleados por Numero de Cedula");
                Console.WriteLine("2. Lista de empleados Ordenados por nombre");
                Console.WriteLine("3. Calcular y mostrar el promedio de salarios");
                Console.WriteLine("4. Calcular y mostrar el salario mas alto y el mas bajo");
                Console.WriteLine("5. Regresar el menu Principal");
                Console.WriteLine("*** Por favor Selecciona una opcion ***");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ConsultarEmpleadosPorCedula();
                        break;

                    case 2:
                        ListaEmpleadosOrdenadosPorNombre();
                        break;

                    case 3:
                        CalcularPromedioDeSalario();
                        break;

                    case 4:
                        CalcularSalarioMasAltoYMasBajo();
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Opcion Invalida");
                        break;
                }

            } while (opcion != 5);
        }

        private void ConsultarEmpleadosPorCedula()
        {
            // Metodo privado para consultar empleado POR CEDULA

            Console.WriteLine("Ingrese el numero de cedula a consultar: ");
            string cedula = Console.ReadLine();
            clsEmpleado empleado = empleados.Find(e => e.Cedula == cedula);

            if (empleado != null)
            {
                Console.WriteLine($"Cedula: {empleado.Cedula}, Nombre: {empleado.Nombre}, Direccion: {empleado.Direccion}. Telefono: {empleado.Telefono}, Salario: {empleado.Salario}");
            }
            else
            {
                Console.WriteLine("Empleado no Encontrado");
            }
        }

        private void ListaEmpleadosOrdenadosPorNombre()
        {
            List<clsEmpleado> empleadosOrdenados = empleados.OrderBy(e  => e.Cedula).ToList();
            Console.WriteLine("*************** Empleados Ordenados por Nombre ***************");
            foreach (var empleado in empleadosOrdenados)
            {
                Console.WriteLine($"Cedula: {empleado.Cedula}, Nombre: {empleado.Nombre}, Direccion: {empleado.Direccion}. Telefono: {empleado.Telefono}, Salario: {empleado.Salario}");
            }
        }

        private void CalcularPromedioDeSalario()
        {
            // Metodo para calcular el promedio de salario 

            if (empleados.Count > 0)
            {
                double promedio = empleados.Average(e => e.Salario);
                Console.WriteLine($"Promedio de Salarios: {promedio}");
            }
            else
            {
                Console.WriteLine("No hay empleados registrados");
            }
            
        }

        private void CalcularSalarioMasAltoYMasBajo()
        {
            // metodo para calcular y mostrar el salario mas algo y el mas alto
            if (empleados.Count > 0)
            {
                double salarioMasAlto = empleados.Max(e => e.Salario);
                double salarioMasBajo = empleados.Min(e => e.Salario);
                Console.WriteLine($"El salario mas alto es: {salarioMasAlto}");
                Console.WriteLine($"El Salario mas Bajo es: {salarioMasBajo}");
            }
            else
            {
                Console.WriteLine("No hay empleados registradps");
            }
        }








    }
}
