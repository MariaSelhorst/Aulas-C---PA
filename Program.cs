//2. Desenvolva um programa que calcule a área de um círculo, solicitando
//ao usuário o valor do raio.

using System;

class Raio 
{
    static void Main()
    {
        Console.WriteLine("---Área de um circulo---");
        Console.WriteLine("Digite a área do circulo: ");
        double raio = Convert.ToDouble(Console.ReadLine());
        
        double area = Math.PI * Math.Pow(raio, 2);

        Console.WriteLine("A área do circulo é: " + area);
    }

}