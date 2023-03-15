namespace Exercicio_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                int soma = a + b;
                Console.WriteLine("A soma de A e B é: " + soma);
            }
            else
            {
                int multiplicacao = a * b;
                Console.WriteLine("A multiplicação de A por B é: " + multiplicacao);
            }
        }
    }
}