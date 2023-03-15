namespace Exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, area;

            Console.Write("Digite a largura do terreno em metros: ");
            largura = double.Parse(Console.ReadLine());

            Console.Write("Digite o comprimento do terreno (em metros): ");
            comprimento = double.Parse(Console.ReadLine());

            area = largura * comprimento;

            Console.WriteLine($"A área do terreno é de {area:F2} metros quadrados.");
        }
    }
}