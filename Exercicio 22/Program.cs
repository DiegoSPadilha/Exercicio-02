namespace Exercicio_22
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

            if (a == b)
            {
                c = a + b;
                Console.WriteLine("A soma de A e B é: " + c);
            }
            else
            {
                c = a * b;
                Console.WriteLine("A multiplicação de A por B é: " + c);
            }

            Console.WriteLine("O valor de c é: " + c);
        }
    }
}