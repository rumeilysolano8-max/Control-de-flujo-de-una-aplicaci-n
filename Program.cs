using System;

namespace ControlFlujoApp
{
    class Program
    {
        //FUNCIONES

        /// <summary>
         
        /// </summary>
        static double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }

        /// <summary>
        
        /// </summary>
        static double CalcularAreaCuadrado(double lado)
        {
            return lado * lado;
        }|

        /// <summary>
       
        /// </summary>
        static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }

        /// <summary>
         
        /// </summary>
        static string VerificarEdad(int edad)
        {
            if (edad >= 18)
                return "Es MAYOR de edad.";
            else
                return "Es MENOR de edad.";
        }

        //PROGRAMA PRINCIPAL 
        static void Main(string[] args)
        {
            Console.Title = "Calculadora de Áreas y Verificación de Edad";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("   CONTROL DE FLUJO - ALGORITMOS COMPUTACIONALES");

            Console.WriteLine("1. ÁREA DEL TRIÁNGULO");
            Console.Write("   Ingrese la base: ");
            double baseT = Convert.ToDouble(Console.ReadLine());
            Console.Write("   Ingrese la altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double areaTriangulo = CalcularAreaTriangulo(baseT, altura);
            Console.WriteLine($"   → Área del triángulo: {areaTriangulo:F2}\n");

            Console.WriteLine("2. ÁREA DEL CUADRADO");
            Console.Write("   Ingrese el lado: ");
            double lado = Convert.ToDouble(Console.ReadLine());

            double areaCuadrado = CalcularAreaCuadrado(lado);
            Console.WriteLine($"   → Área del cuadrado: {areaCuadrado:F2}\n");

            Console.WriteLine("3. ÁREA DEL CÍRCULO");
            Console.Write("   Ingrese el radio: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double areaCirculo = CalcularAreaCirculo(radio);
            Console.WriteLine($"   → Área del círculo: {areaCirculo:F2}\n");

            Console.WriteLine("4. VERIFICACIÓN DE EDAD");
            Console.Write("   Ingrese la edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            string resultadoEdad = VerificarEdad(edad);
            Console.WriteLine($"   → {resultadoEdad}\n");

            Console.WriteLine("         ¡Programa finalizado!");
            Console.ReadKey();
        }
    }
}