namespace Exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade, diasDeVida;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();


            Console.Write("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());


            diasDeVida = idade * 365;



            Console.WriteLine($"Olá {nome}, você tem {diasDeVida} dias de vida.");
        }
    }
}