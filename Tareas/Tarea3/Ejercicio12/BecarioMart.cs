using System;
using System.Collections.Generic;

/**
 * Tarea 3.
 * Autor: Alexis Brayan López Matías.
 */

namespace Ejercicio12
{
    static class BecarioMart
    {
        /// <summary>Lista de nombres de productos.</summary>
        private static readonly List<string> productos = new List<string>();

        /// <summary>Lista de precios de productos.</summary>
        private static readonly List<double> precios = new List<double>();

        /// <summary>Total a pagar.</summary>
        private static double total = 0;

        /// <summary>Dinero disponible</summary>
        private const double DINERO = 500.0;

        /// <summary>
        /// Agrega un producto a las listas.
        /// </summary>
        /// <param name="nombre">Nombre del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        private static void AgregarProducto(string nombre, double precio)
        {
            productos.Add(nombre);
            precios.Add(precio);
            total += precio;
            Console.WriteLine("Producto agregado al carrito.");
        }

        /// <summary>
        /// Elimina un producto en la posición <paramref name="index"/>.
        /// </summary>
        /// <param name="index"></param>
        private static void EliminarProducto(ushort index)
        {
            if (index < productos.Count)
            {
                total -= precios[index];
                productos.RemoveAt(index);
                precios.RemoveAt(index);
                Console.WriteLine("Producto descartado.");
            }
            else
                Console.WriteLine("Producto inválido.");
        }

        /// <summary>
        /// Trata de realizar la compra y en caso de que el dinero sea
        /// insuficiente, se ejecuta la opción de dejar productos.
        /// </summary>
        private static void Comprar()
        {
            if (total <= DINERO)
                Console.WriteLine("\nGracias por su compra!");
            else
            {
                Console.WriteLine("\nDinero insuficiente.");
                DejarProductos();
            }

        }

        /// <summary>
        /// Imprime el menú para dejar un producto y ejecuta la acción
        /// correspondiente.
        /// </summary>
        private static void DejarProductos()
        {
            ushort index;
            string opcion;
            PrintProductos();
            do
            {
                index = (ushort)(GetUShortFromSTDIN("\nSeleccione un " +
                    "producto a descartar: ") - 1);
                EliminarProducto(index);
                Console.Write("\n¿Desea eliminar otro producto? [S/N]: ");
                opcion = Console.ReadLine();
            } while (opcion.ToUpper().Equals("S"));
            PrintMenu();
        }

        /// <summary>
        /// Imprime la lista de productos así como el total a pagar.
        /// </summary>
        private static void PrintProductos()
        {
            for (int i = 0; i < productos.Count; i++)
                Console.Write($"\n{i + 1}. {productos[i]}: {precios[i],0:C2}.");
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine($"Total: {total,0:C2}");
        }

        /// <summary>
        /// Imprime el menú de comprar o dejar productos y ejecuta las
        /// opciones correspondientes.
        /// </summary>
        private static void PrintMenu()
        {
            string opcion;  // Opción seleccionada

            PrintProductos(); // Imprimimos lista de productos.
            do // Comprar o dejar productos
            {
                Console.Write("\nSeleccione una de las siguientes opciones:" +
                "\n1] Comprar.\n2] Dejar productos.\n---------------------\n" +
                "Opción: ");
                opcion = Console.ReadLine();
            } while (!opcion.Equals("1") && !opcion.Equals("2"));

            if (opcion.Equals("1")) // Comprar productos
                Comprar();
            else // Dejar productos
                DejarProductos();
        }

        /// <summary>
        /// Imprime <paramref name="msg"/> a la salida estándar y obtiene la
        /// entrada del usuario.
        /// </summary>
        /// <param name="msg">Mensaje a imprimir.</param>
        /// <returns>Entrada del usuario.</returns>
        private static string GetStringFromSTDIN(string msg)
        {
            string str = ""; // Entrada del usuario

            // Obtener entrada del usuario
            while (str.Equals(""))
            {
                Console.Write(msg);
                str = Console.ReadLine();
            }

            return str;
        }

        /// <summary>
        /// Imprime <paramref name="msg"/> a la salida estándar y obtiene la
        /// entrada del usuario.
        /// </summary>
        /// <param name="msg">Mensaje a imprimir.</param>
        /// <returns>Entrada del usuario.</returns>
        private static double GetDoubleFromSTDIN(string msg)
        {
            double dbl = 0; // Salida

            // Obtener entrada del usuario
            while (dbl <= 0)
            {
                Console.Write(msg);
                dbl = double.TryParse(Console.ReadLine(), out dbl) ? dbl : 0;
            }

            return dbl;
        }

        /// <summary>
        /// Imprime <paramref name="msg"/> a la salida estándar y obtiene la
        /// entrada del usuario.
        /// </summary>
        /// <param name="msg">Mensaje a imprimir.</param>
        /// <returns>Entrada del usuario.</returns>
        private static ushort GetUShortFromSTDIN(string msg)
        {
            ushort ushrt = 0; // Salida

            // Obtener entrada del usuario
            while (ushrt == 0)
            {
                Console.Write(msg);
                ushrt = ushort.TryParse(Console.ReadLine(), out ushrt) ? ushrt
                    : (ushort)0;
            }

            return ushrt;
        }

        public static void Run()
        {
            string opcion = "S";    // Opción seleccionada
            string producto;        // Nombre del producto
            double precio;          // Precio del producto

            // Agregar productos
            Console.WriteLine("Ingrese los productos a comprar: ");
            while (opcion.ToUpper().Equals("S"))
            {
                producto = GetStringFromSTDIN("Nombre del producto: ");
                precio = GetDoubleFromSTDIN("Precio del producto: ");
                AgregarProducto(producto, precio);
                Console.Write("\n¿Desea agregar otro producto? [S/N]: ");
                opcion = Console.ReadLine();
            }

            PrintMenu(); // Comprar o dejar productos
        }
    }
}
