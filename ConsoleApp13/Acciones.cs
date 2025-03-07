using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Acciones
    {
        public List<Autos> listaautomoviles = new  List<Autos>();
        Autos a = new Autos();

        public void AgregarAuto()
        {
            Console.WriteLine("Marca: ");
            a.Marca = Console.ReadLine();
            Console.WriteLine("Modelo: ");
            a.Modelo = Console.ReadLine();
            Console.WriteLine("Anio: ");
            a.Anio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero de puertas: ");
            a.NoPuertas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("color: ");
            a.Color  = Console.ReadLine();



            listaautomoviles.Add(new Autos(a.Marca,a.Modelo,a.Anio,a.NoPuertas,a.Color));
        }
        public void MostrarAutos()
        {
            foreach (var e in listaautomoviles)
            {
                Console.WriteLine($"La marca  es: {e.Marca} ");
                Console.WriteLine($"La modelo  es: {e.Modelo} ");
                Console.WriteLine($"El anio  es: {e.Anio} ");
                Console.WriteLine($"La Numero de puertas es: {e.NoPuertas} ");
                Console.WriteLine($"La color  es: {e.Color} ");

            }
        }
        public int ContarAutomoviles()
        {
            return listaautomoviles.Count;
        }
        public void EliminarAutomovil(string nombremarca)
        {
            var automovil = listaautomoviles.Find(y => y.Marca == nombremarca);
            if (automovil != null)
                listaautomoviles.Remove(automovil);
            else
                Console.WriteLine("no se encontro tu automovil.");
        }
        public void ActualizarDatosAutomovil()
        {
            // Pedir la marca actual (la que se quiere cambiar)
            Console.Write("Introduce la marca actual del automóvil que deseas actualizar: ");
            string marcaAntigua = Console.ReadLine();

            // Buscar el automóvil con la marca antigua
            var automovil = listaautomoviles.Find(y => y.Marca == marcaAntigua);

            // Si se encuentra el automóvil, solicitar los nuevos datos
            if (automovil != null)
            {
                // Solicitar nuevos datos para actualizar
                Console.Write("Introduce la nueva marca del automóvil: ");
                string nuevaMarca = Console.ReadLine();

                Console.Write("Introduce el nuevo modelo del automóvil: ");
                string nuevoModelo = Console.ReadLine();

                Console.Write("Introduce el nuevo año del automóvil: ");
                int nuevoAño = Convert.ToInt32(Console.ReadLine());

                Console.Write("Introduce el nuevo número de puertas: ");
                int nuevoNumeroPuertas = Convert.ToInt32(Console.ReadLine());

                Console.Write("Introduce el nuevo color del automóvil: ");
                string nuevoColor = Console.ReadLine();

                // Actualizar los datos del automóvil
                automovil.Marca = nuevaMarca;
                automovil.Modelo = nuevoModelo;
                automovil.Anio = nuevoAño;
                automovil.NoPuertas = nuevoNumeroPuertas;
                automovil.Color = nuevoColor;

                Console.WriteLine("Los datos del automóvil han sido actualizados correctamente.");
            }
            else
            {
                Console.WriteLine("No se encontró un automóvil con esa marca.");
            }
        }
    }

    
}
