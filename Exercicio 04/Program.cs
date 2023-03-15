namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kmInicial, kmFinal, combustivel, consumo;

            Console.Write("Digite a quilometragem inicial do percurso: ");
            kmInicial = double.Parse(Console.ReadLine());

            Console.Write("Digite a quilometragem final do percurso: ");
            kmFinal = double.Parse(Console.ReadLine());

            Console.Write("Digite o consumo de combustível durante o percurso (em litros): ");
            combustivel = double.Parse(Console.ReadLine());

            consumo = (kmFinal - kmInicial) / combustivel;

            Console.WriteLine("O consumo de combustível por km foi de: " + consumo + " km/l");


        }
    }
}