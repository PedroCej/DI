using System;

public static partial class Program
{
    public static void Main()
    {
        Boleto boleto = new Boleto();
        Boleto boleto1 = new Boleto(1,2,3,4,5,6);
        Boleto boleto2 = new Boleto(1,2,9,4,6,5);
        Console.WriteLine(boleto1);
        Console.WriteLine(boleto2);
        Console.WriteLine(boleto);

        if(boleto1.Equals(boleto2)) Console.WriteLine("Son iguales");
    }
}
   
