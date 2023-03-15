namespace Exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBase, totalVendas, comissao, salarioTotal;
            double percentualComissao;

            Console.Write("Digite o salário base do vendedor: ");
            salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Digite o total de vendas do vendedor: ");
            totalVendas = double.Parse(Console.ReadLine());


            Console.Write("Digite o percentual de comissão do vendedor em %: ");
            percentualComissao = double.Parse(Console.ReadLine());

            comissao = totalVendas * percentualComissao / 100;
            salarioTotal = salarioBase + comissao;


            Console.WriteLine("O salário total do vendedor é de R$" + salarioTotal);

        }
    }
}