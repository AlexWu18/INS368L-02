using System;

namespace SecuenciaFibonacci2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0, Azul;
            Console.WriteLine("Secuencia Fibonacci");
            Console.WriteLine("Escriba el digito para la cantidad de sucesion:");
            
            Azul = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 2; i < Azul; i++)
            {
                c = a + b;
                a = b;
                b = c;

                if (c % 2 == 0)
                {
                    Console.Write(c + " Par,");
                }
                else
                {
                    Console.Write(c + " Impar,");
                }

                if (c % 2 == 0)
                {
                    Console.WriteLine("No es primo,");
                }
                else
                {
                    Console.WriteLine("primo,");
                }

            }
               
        }
    }
}
