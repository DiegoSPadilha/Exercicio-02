namespace Exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.Write("Digite a temperatura em graus Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9.0 / 5.0) + 32.0;

            Console.WriteLine("A temperatura em graus Fahrenheit é de " + fahrenheit + " graus");
        }
    }
}