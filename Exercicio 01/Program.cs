double comprimento, largura, altura, volume;




Console.Write("Digite o comprimento da caixa em metros: ");
comprimento = double.Parse(Console.ReadLine());

Console.Write("Digite a largura da caixa em metros: ");
largura = double.Parse(Console.ReadLine());

Console.Write("Digite a altura da caixa em metros: ");
altura = double.Parse(Console.ReadLine());

volume = comprimento * largura * altura;


Console.WriteLine("O volume da caixa é de " + volume + " metros cúbicos");
