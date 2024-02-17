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

        }
}