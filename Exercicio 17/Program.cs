namespace Exercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            c = int.Parse(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine("A soma de A e B é menor que C.");
            }
            else
            {
                Console.WriteLine("A soma de A e B não é menor que C.");
            }
        }
    }
}