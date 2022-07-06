using System;

namespace Ejercicio2DeFelipeTorres
{
    class Program
    {
        static void Main(string[] args)
        {
            double P;
            Console.WriteLine("Ingresar Lado A");
            double LadoA = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar Lado B");
            double LadoB = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar Lado C");
            double LadoC = double.Parse (Console.ReadLine());
            P = ((LadoA + LadoB + LadoC) / 2);
            if (VerificarLado(LadoA, LadoB, LadoC))
            {
                if (EsTriangulo(LadoA, LadoB, LadoC))
                {
                    TipoDeTriangulo(LadoA, LadoB, LadoC);
                    El_Perimetro(LadoA, LadoB, LadoC);
                    La_Superfice(P, LadoA, LadoB, LadoC); ;
                }
                else 
                {
                    Console.WriteLine("No es un Triangulo");
                }
            }
            else
            {
                Console.WriteLine("Error Los Lados No pueden ser 0");
            }

        }

        private static void El_Perimetro(double ladoA, double ladoB, double ladoC)
        {
            double Perimetro = ladoA + ladoB + ladoC;
            Console.WriteLine($"El Perimetro es {Perimetro}");
        }

        private static void TipoDeTriangulo(double ladoA, double ladoB, double ladoC)
        {
            
            if (ladoA * ladoA < ladoB * ladoB + ladoC * ladoC)
            {
                Console.WriteLine("Es Un Triangulo Acutángulo");
            }
            else if (ladoA+ladoA > ladoB*ladoB + ladoC*ladoC)
            {
                Console.WriteLine("Es Un Triangulo Obtusángulo");
            }
            else
            {
                Console.WriteLine("Es Un Triangulo Rectángulo");
            }
            
        }

        private static object La_Superfice(double P, double ladoA, double ladoB, double ladoC)
        {
            return Math.Sqrt(P + (P - ladoA) * (P - ladoB) * (P - ladoC));
        }

        private static bool EsTriangulo(double ladoA, double ladoB, double ladoC)
        {
            return (ladoA + ladoB > ladoC) && (ladoA +ladoC > ladoB) && (ladoB + ladoC > ladoA);
        }

        private static bool VerificarLado(double ladoA, double ladoB, double ladoC)
        {
            return (ladoA > 0) && (ladoB> 0) && (ladoC> 0);
        }
    }
}
