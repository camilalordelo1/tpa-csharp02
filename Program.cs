using System;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variavel do tipo real
            double X;
            double Y;
            double XY;
            // entrada de dados
            Console.WriteLine("Digite N1: "); //escreval
            X = double.Parse(Console.ReadLine()); //leia
            Console.WriteLine("Digite N2: "); //escreval
            Y = double.Parse(Console.ReadLine());
            XY = X + Y;

            //saida de dados
            Console.WriteLine("Soma: " + XY);
        }
    }
}
