
//Operaciones con cadenas:
using System;
using System.Text.RegularExpressions;
partial class Program
{

    static void Main()
    {
        // Comparación de cadenas
        string cadena1 = "Gracias";
        string cadena2 = "Galicia";
        string cadena3 = "gracias";

        // Comparar cadenas usando el método Equals
        bool sonIguales = cadena1.Equals(cadena2, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine("¿Cadena1 y Cadena2 son iguales? " + sonIguales);

        sonIguales = cadena1.Equals(cadena3, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine("¿Cadena1 y Cadena3 son iguales? " + sonIguales);


        sonIguales = cadena1.Equals(cadena2, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine("¿Cadena1 y Cadena2 son iguales (ignorando mayúsculas/minúsculas)? " + sonIguales);

        // Comparar cadenas usando el operador ==
        bool sonIgualesOperador = cadena1 == cadena2;
        Console.WriteLine("¿Cadena1 y Cadena2 son iguales usando el operador ==? " + sonIgualesOperador);


        sonIgualesOperador = cadena1.Equals(cadena2, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine("¿Cadena1 y Cadena2 son iguales usando el operador == (ignorando mayúsculas/minúsculas)? " + sonIgualesOperador); // Devuelve true

        // Concatenación de cadenas.
        string cadena1Concat = "Ser";
        string cadena2Concat = " Positivo";
        string cadena3Concat = "es lo";
        string cadena4Concat = "mejor";

        // Concatenación usando el operador +
        string concatenacion1 = cadena1Concat + cadena2Concat;
        Console.WriteLine("Concatenación usando el operador +: " + concatenacion1);
        string concatenacion2 = cadena3Concat + cadena4Concat;
        Console.WriteLine("Concatenación usando el operador +: " + concatenacion1);

        // Concatenación usando el método Concat
        _ = string.Concat(cadena1Concat, cadena2Concat, cadena3Concat);
        Console.WriteLine("Concatenación usando el método Concat: " + concatenacion2);

        // Concatenación usando el método Join
        string[] palabras = ["Ser", "Positivo", "es lo", "mejor"];
        string concatenacion3 = string.Join(" ", palabras);
        Console.WriteLine("Concatenación usando el método Join: " + concatenacion3);

        // Búsqueda de patrones
        string texto = "Entrega siempre más de lo que esperan de ti";
        string patron = "ti";
        MatchCollection coincidencias = Regex.Matches(texto, patron, RegexOptions.IgnoreCase);
        Console.WriteLine("Se encontraron " + coincidencias.Count + " coincidencias del patrón '" + patron + "':");
        foreach (Match coincidencia in coincidencias.Cast<Match>())
        {
            Console.WriteLine("Coincidencia encontrada en el índice " + coincidencia.Index);
        }

        // Formateo de cadenas
        string nombre = "Karen";
        int edad = 27;
        double altura = 1.50;

        string mensaje = string.Format("Hola, me llamo {0}, tengo {1} años y mido {2} metros de altura.", nombre, edad, altura);
        Console.WriteLine(mensaje);

        string fecha = "2024-02-27";
        DateTime fechaFormateada = DateTime.ParseExact(fecha, "yyyy-MM-dd", null);
        string mensajeFecha = string.Format("La fecha formateada es: {0:dddd, MMMM d, yyyy}", fechaFormateada);
        Console.WriteLine(mensajeFecha);
    }
}

