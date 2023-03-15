namespace Exercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            double notaHarmonica = 3 / ((1 / nota1) + (1 / nota2) + (1 / nota3));

            Console.WriteLine(Math.Round(notaHarmonica, 2));
        }
    }
}