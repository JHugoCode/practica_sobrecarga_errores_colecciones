using System;

namespace practica_de_campo3
{
    internal class Program
    {
        // Sobrecarga de métodos
        public static void Saludar(string nombre)
        {
            Console.WriteLine("Hola, " + nombre);
        }

        public static void Saludar(string nombre, string apellido)
        {
            Console.WriteLine("Hola, " + nombre + " " + apellido);
        }

        public static void Saludar(int edad)
        {
            Console.WriteLine("Hola, tienes " + edad + " años.");
        }

        // Manejo de errores
        public static void Dividir(int a, int b)
        {
            try
            {
                // Intento de realizar la división
                int resultado = a / b;
                Console.WriteLine("El resultado de la división es: " + resultado);
            }
            catch (DivideByZeroException ex)
            {
                // Si ocurre una excepción de división por cero, se maneja aquí
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }
            catch (Exception ex)
            {
                // Maneja cualquier otra excepción general
                Console.WriteLine("Se produjo un error: " + ex.Message);
            }
            finally
            {
                // Este bloque se ejecuta siempre, independientemente de si ocurre una excepción o no
                Console.WriteLine("El bloque 'finally' siempre se ejecuta.");
            }
        }

        static void Main(string[] args)
        {
            // Ejemplos de sobrecarga de métodos
            Saludar("Juan");
            Saludar("Juan", "Pérez");
            Saludar(30);

            // Ejemplo de manejo de errores
            Console.WriteLine("Intentando dividir 10 entre 2:");
            Dividir(10, 2);  // Dividir sin error

            Console.WriteLine("Intentando dividir 10 entre 0:");
            Dividir(10, 0);  // Intento de dividir entre 0

            Console.WriteLine("Intentando dividir 10 entre 3:");
            Dividir(10, 3);  // Dividir sin error
        }
    }
}
