// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Penjumlahan.jumlahTigaAngka<double>(13, 02, 23));

    }
}

class Penjumlahan
{

    public static T jumlahTigaAngka<T>(T num1, T num2, T num3) where T : IAdditionOperators<T,T,T>
    { 
        // dynamic result = 0;
        return num1 + num2 + num3;
        
    }
}