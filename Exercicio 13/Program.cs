namespace Exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdPao, qtdBroa;
            double totalArrecadado, valorGuardado;

            Console.Write("Digite a quantidade de pães vendidos: ");
            qtdPao = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de broas vendidas: ");
            qtdBroa = int.Parse(Console.ReadLine());

            totalArrecadado = (qtdPao * 0.12) + (qtdBroa * 1.5);
            valorGuardado = totalArrecadado * 0.1;

            Console.WriteLine($"Total arrecadado: R$ {totalArrecadado:F2}");
            Console.WriteLine($"Valor a ser guardado na poupança: R$ {valorGuardado:F2}");
        }
    }
}