using System;

public static partial class Program
{
    public static void Main()
    {
        Boleto boleto = new Boleto();
        Boleto boleto1 = new Boleto(1, 2, 3, 4, 5, 6);
        Boleto boleto2 = new Boleto(1, 2, 3, 4, 6, 5);
        Console.WriteLine(boleto1.ToString());
        Console.WriteLine(boleto2);
        Console.WriteLine(boleto);

        if (boleto1.Equals(boleto2)) Console.WriteLine("Son iguales");

        Boleto[] loteria = new Boleto[100];
        // meter 100



        for (int i = 0; i < loteria.Length; i++)
        {
            Boleto posibleBoleto = new Boleto();

            bool nuevoCorrecto = true;
            do
            {
                for (int j = 0; j <= i; j++)
                {
                    if (posibleBoleto.Equals(loteria[j])) {
                        nuevoCorrecto = false;
                    }
                }

                loteria[i] = new Boleto();

            } while (!nuevoCorrecto);
        }


        for (int i = 0; i < loteria.Length; i++) { //Leer 
            Console.WriteLine("Boleto "+i+" - "+loteria[i]);
        }
    }
}

   
