namespace Exercicio_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i <= 500; i += 2)
            {
                if (i % 3 == 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine("A soma dos números ímpares múltiplos de três é: " + soma);
        }
    }
}