using System;

public static class Program
{
    public static void Main()
    {
        int[,] combinaciones = new int[100, 6];
        int num;
        for (int i = 0; i < 100; i++)
        {
            Console.Write(i + ".  ");
            for (int j = 0; j < 6; j++)
            {
                num = aleatorio();
                if (num == combinaciones[i, 0] || num == combinaciones[i, 1] || num == combinaciones[i, 2] || num == combinaciones[i, 3] || num == combinaciones[i, 4])
                    j = j - 1;
                else
                {
                    combinaciones[i, j] = num;
                    Console.Write(combinaciones[i, j] + "\t\t");
                }
            }
            Console.WriteLine("\n");
        }


        int aleatorio()
        {
            Random al = new Random();
            return al.Next(1, 50);
        }

        //
    }
}