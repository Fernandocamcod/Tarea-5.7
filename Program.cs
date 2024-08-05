using System;

class Program
{
    static void Main()
    {
        int numero;
        bool esValido = false;

        while (!esValido)
        {
            Console.Write("Por favor, introduce un número entero positivo: ");
            string input = Console.ReadLine();

            // Verifica que la entrada del usuario es un número entero válido y positivo
            if (int.TryParse(input, out numero) && numero > 0)
            {
                esValido = true;
                Console.WriteLine($"¡Gracias! Has introducido el número {numero}.");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debes introducir un número entero positivo.");
            }
        }

        // Mantiene la consola abierta hasta que el usuario presione una tecla
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

