using System;

class Program
{
    static void Main(string[] args)
    {
        string[] originalArray = { "Hello", "2", "world", ":-)" };
        
        string[] newArray = new string[originalArray.Length];
        int count = 0;
        foreach (string str in originalArray)
        {
            if (str.Length <= 3)
            {
                newArray[count] = str;
                count++;
            }
        }
        string[] finalArray = new string[count];
        Array.Copy(newArray, finalArray, count);

        Console.WriteLine("Исходный массив:");
        Console.WriteLine("[" + string.Join(", ", originalArray) + "]");
        Console.WriteLine("Новый массив (строки длиной не более 3 символов):");
        Console.WriteLine("[" + string.Join(", ", finalArray) + "]");

        Console.ReadLine();
    }
}