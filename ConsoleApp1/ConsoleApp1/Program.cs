using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaGasolina.Clases;

namespace VentaGasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ciclo = true;
            Cliente cliente = new Cliente("", 0, "", new List<Gasolina>());
            Console.WriteLine("Ingrese los nombres del cliente: ");
            cliente.Nombres = Console.ReadLine();
            Console.WriteLine("Ingrese el Numero de cedula del cliente:");
            cliente.Cedula = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la direccion del cliente");
            cliente.Direccion = Console.ReadLine();

            do
            {
                Gasolina gasolina1 = new Gasolina("EXTRA", 0);
                Console.WriteLine("Ingrese el Tipo de Gasolina \n \t EXTRA\t SUPER");
                gasolina1.Tipo = Console.ReadLine();
                Console.WriteLine("Digite la cantidad de galones");
                gasolina1.Galones = int.Parse(Console.ReadLine());

                gasolina1.Cliente = cliente;
                cliente.Gasolina.Add(gasolina1);

                Console.WriteLine("\n\n******************FACTURA********************\t\t");
                Console.WriteLine(cliente.ToString());
                Console.WriteLine(gasolina1.ToString());
                Console.ReadKey();

                bool a = true;
                do 
                {
                Console.Clear();
                Console.WriteLine("¿Que desea hacer?\n\n1.-Nueva Factura\n2.-Imprimir facturas\n3.-Salir");
                string op = Console.ReadLine();
                    switch (op)
                    {
                        case "1":
                            Console.Clear();
                            a = false;
                            break;
                        case "2":
                            Console.Clear();
                            foreach (Gasolina item in cliente.Gasolina)
                            {
                                Console.WriteLine("\n\n******************FACTURA********************\t\t");
                                Console.WriteLine(cliente.ToString());
                                Console.WriteLine(item.ToString());
                            }
                            Console.ReadKey();
                            break;
                        case "3":
                            a = false;
                            ciclo = false;
                            break;
                        default:
                            Console.WriteLine("No se escogio una opcion");
                            break;
                    }

                } while (a);

            } while (ciclo);
        }
    }
}

