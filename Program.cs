using System;

namespace Aula22S
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Conversor.CotacaoDolar = 5.29f;
            System.Console.WriteLine("Seus reais valem, em dólar: "+Conversor.RealParaDolar(22));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Seu dólar vale, em reais: "+Conversor.DolarParaReal(120));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Conversor.CotacaoEuro = 5.7f;
            System.Console.WriteLine("Seus reais valem, em euros: "+Conversor.RealParaEuro(2));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            System.Console.WriteLine("Seus euros valem, em reais: "+Conversor.EuroParaReal(90));
            Console.ResetColor();
            
        }
    }
}
