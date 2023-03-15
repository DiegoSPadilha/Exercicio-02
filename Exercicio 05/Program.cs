namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, volume;

            Console.Write("Digite o raio da esfera em metros: ");
            raio = double.Parse(Console.ReadLine());

            volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);

            Console.WriteLine("O volume da esfera é de " + volume + " metros cúbicos");
        }
    }
}