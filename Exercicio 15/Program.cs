using static System.Net.Mime.MediaTypeNames;

namespace Exercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperaturaCelsius, temperaturaFahrenheit;

            Console.Write("Digite a temperatura em graus Celsius: ");
            temperaturaCelsius = double.Parse(Console.ReadLine());


            temperaturaFahrenheit = (temperaturaCelsius * 1.8) + 32;


            Console.WriteLine($"A temperatura em Fahrenheit é de {temperaturaFahrenheit:F2} graus.");
         
            
        }
    }
}