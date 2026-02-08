using System.ComponentModel;

namespace StringLoop;

public class Program
{
    public static void Main(string[] args)
    {
        string msg = "C# is awesome";
        for(int i = 0; i < msg.Length; i++)
        {
            Console.Write(msg[i]);
            Thread.Sleep(100);
        }

        Console.WriteLine();
        Console.WriteLine(msg.Contains("C"));

        bool contains = false;
        for(int i = 0; i < msg.Length; i++)
        {
            if(msg[i] == 'C')
            {
                contains = true;
            }
        }
        Console.WriteLine(contains);
        
    }
}
