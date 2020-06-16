using System;

namespace logica1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double pontoFlutuante = a+b;
            a=2.5884;
            b=5.1235;
            Console.WriteLine("O Joao recebeu de sua mae" + a + "reais e" + b + "e de seu pai");
            Console.WriteLine("O valor final que o Joao recebeu e" + pontoFlutuante.ToString("F2"));

            Console.ReadLine();
        }
    }
}
