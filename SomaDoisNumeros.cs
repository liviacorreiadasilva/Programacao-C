using System;

class Program
{
    static void Main()
    {
        float n1, n2, soma;
        Console.Write("Digite um numero: ");
        n1 = float.Parse(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        n2 = float.Parse(Console.ReadLine());
        
        soma = (n1 + n2);
        
        Console.WriteLine("A soma de: " + n1 + " + " + n2 + " vale :" + soma);
        Console.ReadKey();
    }
}
