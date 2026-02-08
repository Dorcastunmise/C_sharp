namespace IsNullOrEmpty;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        if(name.Equals("")) Console.WriteLine("0");
        else Console.WriteLine("1");

        if(!string.IsNullOrEmpty(name)) Console.WriteLine("2"); //IsNullOrEmpty checks for "" and null as well 
    }
}
