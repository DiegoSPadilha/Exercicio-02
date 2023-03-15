namespace Exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, volume;

            Console.Write("Digite o raio da base da lata em centímetros: ");
            raio = double.Parse(Console.ReadLine());


            Console.Write("Digite a altura da lata em centímetros: ");
            altura = double.Parse(Console.ReadLine());


            volume = Math.PI * Math.Pow(raio, 2) * altura;


            Console.WriteLine("O volume da lata de óleo é de " + volume + " centímetros cúbicos");
        }
    }
}