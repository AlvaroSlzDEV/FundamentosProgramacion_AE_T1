using System;

class Calculadora
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la calculadora");

        // Declaración de variables para los números
        double numero1, numero2;

        // Bucle para asegurar que ambos números sean positivos
        do
        {
            Console.Write("Introduce el primer número (positivo): ");
            numero1 = ObtenerNumero();
            
            Console.Write("Introduce el segundo número (positivo): ");
            numero2 = ObtenerNumero();

            if (numero1 < 0 || numero2 < 0)
            {
                Console.WriteLine("Ambos números deben ser positivos. Inténtalo de nuevo.\n");
            }
        } while (numero1 < 0 || numero2 < 0);

        // Menú iterativo
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\n--- Menú de Operaciones ---");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción (1-5): ");

            int opcion = ObtenerOpcion();

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Resultado de la suma: {numero1 + numero2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado de la resta: {numero1 - numero2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado de la multiplicación: {numero1 * numero2}");
                    break;
                case 4:
                    if (numero2 != 0)
                    {
                        Console.WriteLine($"Resultado de la división: {numero1 / numero2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre 0.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa. ¡Adiós!");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }
        }
    }

    // Método para obtener un número desde consola y validar su entrada
    static double ObtenerNumero()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                return numero;
            }
            else
            {
                Console.Write("Entrada no válida. Introduce un número: ");
            }
        }
    }

    // Método para obtener una opción válida del menú
    static int ObtenerOpcion()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int opcion) && opcion >= 1 && opcion <= 5)
            {
                return opcion;
            }
            else
            {
                Console.Write("Entrada no válida. Selecciona una opción (1-5): ");
            }
        }
    }
}

	   	
	   	
	   	
	   	
	   	
	   	
	









}
