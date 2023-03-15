namespace Exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, contador = 0;

            Console.Write("Digite um número inteiro positivo: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)
            {
                Console.WriteLine("O número " + numero + " é primo.");
            }
            else
            {
                Console.WriteLine("O número " + numero + " não é primo.");
            }  
        }
    }
}