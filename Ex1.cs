using System;
using System.Globalization;



class Program
{
    public static void Main(string[] args)
    {
        string nome;
        int idade;
        double n1;
        double n2;



        Console.WriteLine("Digite seu Nome:");
        nome = Console.ReadLine();



        Console.WriteLine("Olá, " + nome);
        Console.WriteLine("Quantos anos você tem?");
        idade = int.Parse(Console.ReadLine());



        Console.WriteLine("Legal agora digite um número inteiro de 0 a 10");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Agora digite mais um número inteiro de 0 a 10");
        n2 = double.Parse(Console.ReadLine());



        Console.WriteLine("Então, " + nome + " de " + idade + " anos, você digitou os números " + n1 + " e " + n2);
        Console.WriteLine("A soma dos números é: " + (n1 + n2));
        Console.WriteLine("A subtração dos números é: " + (n1 - n2));
        Console.WriteLine("A Multiplicação dos números é: " + (n1 * n2));
        Console.WriteLine("A Divisão dos números é: " + (n1 / n2));
        Console.WriteLine(n1.ToString());
    }
}