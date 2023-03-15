namespace Exercicio_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
              

            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            int resultado = 1;

            Console.Write(num + "! = ");

            for (int i = num; i > 0; i--)
            {
                Console.Write(i);
                resultado *= i;
                if (i != 1)
                {
                    Console.Write(" x ");
                }
            }

            Console.WriteLine(" = " + resultado);
        }
    }
}