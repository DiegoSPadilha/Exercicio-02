 namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius;


            Console.Write("Digite a temperatura em graus Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5.0 / 9.0;


            CConsole.WriteLine("A temperatura em graus Celsius é de " + celsius + " graus");

        }
    }
}