using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        public enum Menu
        {
            Agregar = 1, Mostrar, Contar, Eliminar,Actualizar
        }
        static void Main(string[] args)
        {
            Acciones Auto = new Acciones();

            while (true) 
            {
                switch(menu())
                {
                    case Menu.Agregar:
                        Auto.AgregarAuto();
                        break; 
                    case Menu.Mostrar:
                        Auto.MostrarAutos();
                        break;
                    case Menu.Contar:
                        Console.WriteLine($"el resultado es:{Auto.ContarAutomoviles()}");
                        break;
                    case Menu.Eliminar:
                        Console.WriteLine("Que auto quieres eliminar:");
                        string marca = Console.ReadLine();
                        Auto.EliminarAutomovil(marca);
                        break;
                    case Menu.Actualizar:
                        
                        Auto.ActualizarDatosAutomovil();
                        break;
                    default:
                        break;

                }

            }
        }
        static Menu menu()
        {
            Console.WriteLine("1) Agregar");
            Console.WriteLine("2) Mostrar");
            Console.WriteLine("3) Contar");
            Console.WriteLine("4) Eliminar");
            Console.WriteLine("5) Actualizar");
            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;

        }
    }
}
