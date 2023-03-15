using static System.Net.Mime.MediaTypeNames;

namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, area, volume;
            Console.Write("Digite o valor do altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do area: ");
            area = double.Parse(Console.ReadLine());
            volume = Math.PI * area * area * altura;
            Console.WriteLine("O valor do volume: " + volume);
            Console.WriteLine();

            Application.Exit();
        }
    }
}