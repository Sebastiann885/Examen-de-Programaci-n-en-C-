using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Recursos_Humanos_ExamenI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsMenu menu = new clsMenu();
            int opcion;

            do
            {
                menu.MostrarMenu();
                Console.WriteLine("Elija una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        menu.AgregarEmpleadoNuevo();
                        break;

                    case 2:
                        menu.ConsultarEmpleado();
                        break;

                    case 3:
                        menu.ModificarEmpleado();
                        break;

                    case 4:
                        menu.BorrarEmpleado();
                        break;

                    case 5:
                        menu.InicializarArreglos();
                        break;

                    case 6:
                        menu.Reportes();
                        break;

                    case 7:
                        Console.WriteLine("Saliendo del sistema, Gracias por Visitarnos");
                        break;
                    default:
                        Console.WriteLine("Opcion Invalida");
                        break;
                }
            } while (opcion != 7);
        }
    }
}
