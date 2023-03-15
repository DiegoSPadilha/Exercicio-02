namespace Exercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Digite o primeiro valor inteiro: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor inteiro: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor inteiro: ");
            c = int.Parse(Console.ReadLine());

            if (a > b && b > c)
            {
                Console.WriteLine($"{a} > {b} > {c}");
            }
            else if (a > c && c > b)
            {
                Console.WriteLine($"{a} > {c} > {b}");
            }
            else if (b > a && a > c)
            {
                Console.WriteLine($"{b} > {a} > {c}");
            }
            else if (b > c && c > a)
            {
                Console.WriteLine($"{b} > {c} > {a}");
            }
            else if (c > a && a > b)
            {
                Console.WriteLine($"{c} > {a} > {b}");
            }
            else if (c > b && b > a)
            {
                Console.WriteLine($"{c} > {b} > {a}");
            }
            else
            {
                Console.WriteLine("Os valores informados são iguais.");
            }
        }
    }
}