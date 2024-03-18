// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Penjumlahan.jumlahTigaAngka<double>(13, 02, 23));

        SimpleDataBase<double> myData = new SimpleDataBase<double>();   
        
        for (int i = 0; i < 10; i++)
        {
            myData.addNewData(i);
        }
        myData.printAllData();
    }
}

class SimpleDataBase <T>
{
    public List<T> storedData;
    private List<DateTime> inputDates;   

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();      
    }


    public void addNewData(T data)
    {
        storedData.Add(data);
        this.inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData.ElementAt(i)}, yang disimpan pada waktu UTC: {inputDates.ElementAt(i)}");
        }
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