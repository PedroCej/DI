public class Boleto
{

    private int num;
    private int[] combinacion = new int[6];
    public Boleto()
    {
        for (int i = 0; i < 6; i++)
        {
            num = Aleatorio();
            if (num == combinacion[0] || num == combinacion[1] || num == combinacion[2] || num == combinacion[3] || num == combinacion[4] || num == combinacion[5])
                i--;
            else
            {
                combinacion[i] = num;
            }

        }
    }

    public Boleto(int num1, int num2, int num3, int num4, int num5, int num6)
    {
        combinacion[0] = num1;  
        combinacion[1] = num2;
        combinacion[2] = num3;
        combinacion[3] = num4;
        combinacion[4] = num5;
        combinacion[5] = num6;
    }

    public override string ToString()
    {
        return combinacion[0] +"\t"+ combinacion[1] + "\t" + combinacion[2] + "\t" + combinacion[3] + "\t" + combinacion[4] + "\t" + combinacion[5].ToString();
    }

    public override bool Equals(object? obj)
    {
        HashSet<int> set1 = new HashSet<int>(this.combinacion);
        HashSet<int> set2 = new HashSet<int>(combinacion);

        return set1.SetEquals(set2);
    }

    public int Aleatorio()
    {
        Random al = new Random();
        return al.Next(1, 50);
    }
}