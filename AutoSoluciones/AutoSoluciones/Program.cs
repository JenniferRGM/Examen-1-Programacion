using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSoluciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente[] clientes = new Cliente[100];
            int clienteCuenta = 0;
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Gestión Clientes ===");
                Console.WriteLine("1. Agregar Clientes");
                Console.WriteLine("2. Modificar Clientes");
                Console.WriteLine("3. Eliminar Clientes");
                Console.WriteLine("4. Mostrar Clientes");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Elija una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (clienteCuenta < 100)
                        {
                            clientes[clienteCuenta] = AgregarCliente();
                            clienteCuenta++;
                        }
                        else
                        {
                            Console.WriteLine("No se puede agregar más clientes.");

                        }
                        break;
                    case 2:
                        ModificarCliente(clientes, clienteCuenta);
                        break;
                    case 3:
                        EliminarCliente(clientes, ref clienteCuenta);
                        break;
                    case 4:
                        MostrarClientes(clientes, clienteCuenta);
                        break;
                    case 5:
                        Console.WriteLine("Estamos saliendo del sistema...!!!");
                        break;
                    default:
                        Console.WriteLine("Opción invalida. Intenta de nuevo...");
                        break;
                }
                } while (opcion != 5);

            }
        static Cliente AgregarCliente()
        {
            Cliente nuevoCliente = new Cliente();
            Console.Write("Ingrese el nombre: ");
            nuevoCliente.Nombre = Console.ReadLine();
            Console.Write(" Ingrese la direccion: ");
            nuevoCliente.Direccion = Console.ReadLine();
            Console.Write("Ingrese el telefono: ");
            nuevoCliente.Telefono = Console.ReadLine();
            Console.Write("Ingrese el correo electronico: ");
            nuevoCliente.Email = Console.ReadLine();
            Console.WriteLine("Cliente agregado exitosamente!!!");
            return nuevoCliente;
        }
        static void ModificarCliente(Cliente[] clientes, int clienteCuenta)
        {
            Console.Write("Ingrese el ID del cliente a modificar: ");
            int id = int.Parse(Console.ReadLine());

            if (id >= 0 && id < clienteCuenta)
            {
                Console.Write("Ingrese el nombre: ");
                clientes[id].Nombre = Console.ReadLine();
                Console.Write(" Ingrese la direccion: ");
                clientes[id].Direccion = Console.ReadLine();
                Console.Write("Ingrese el telefono: ");
                clientes[id].Telefono = Console.ReadLine();
                Console.Write("Ingrese el correo electronico: ");
                clientes[id].Email = Console.ReadLine();
                Console.WriteLine("Se modifica el cliente con exito!!!");
            }
            else
            {
                Console.WriteLine("ID no es valido. Favor intenta nuevamente!");
            }
        }
        static void EliminarCliente(Cliente[] clientes, ref int clienteCuenta)
        {
            Console.Write("Ingrese el ID del cliente a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            if (id >= 0 && id < clienteCuenta)
            {
                for (int i = id; i < clienteCuenta -1; i++)
                {
                    clientes[i] = clientes[i + 1];
                }
                clienteCuenta--;
                Console.WriteLine("Cliente ha sido eliminado con exito!!!");
            }
            else
            {
                Console.WriteLine("ID no es valido. Intenta de nuevo");
            }
        }
        static void MostrarClientes(Cliente[] clientes, int clienteCuenta)
        {
            Console.WriteLine("=== Lista de Clientes ===");
            for (int i = 0; i < clienteCuenta; i++)
            {
                Console.WriteLine($"ID: {i}");
                Console.WriteLine($"Nombre: {clientes[i].Nombre}");
                Console.WriteLine($"Direccion: {clientes[i].Direccion}");
                Console.WriteLine($"Telefono: {clientes[i].Telefono}");
                Console.WriteLine($"Correo electronico: {clientes[i].Email}");
                Console.WriteLine("--------------------------------");
            }
        }
        }
    class Cliente
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
