namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, mediaPonderada;
            double peso1, peso2;

            Console.Write("Digite a primeira nota do aluno: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso da primeira nota: ");
            peso1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota do aluno: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso da segunda nota: ");
            peso2 = double.Parse(Console.ReadLine());

            mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            Console.WriteLine("A média ponderada das notas do aluno é de " + mediaPonderada);
        }

    }
}