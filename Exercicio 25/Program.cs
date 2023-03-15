namespace Exercicio_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("digite o numero da tabuada: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)

                Console.WriteLine($"{n} * {i} = {n * i}");
        }
    }
}