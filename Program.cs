// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(double[] args)
    {
        Penjumlahan.jumlahTigaAngka<double>(13,02,23);
    }
}

class Penjumlahan
{

    public static void jumlahTigaAngka<T>(T num1, T num2, T num3) 
    { 
        if (num1 == null || num2 == null || num3 == null) 
        {
            return;
        }

        dynamic result = 0;

        result = num1 + num2 + num3;
    }
}