namespace Exercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, salarioAumento, salarioFinal;

            Console.Write("Digite o salário do funcionário: R$");
            salario = double.Parse(Console.ReadLine());

            salarioAumento = salario * 1.15;
            salarioFinal = salarioAumento * 0.92;

            Console.WriteLine($"Salário inicial: R${salario:F2}");
            Console.WriteLine($"Salário com aumento: R${salarioAumento:F2}");
            Console.WriteLine($"Salário final (com impostos): R${salarioFinal:F2}");
        }
    }
}