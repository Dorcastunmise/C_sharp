namespace OddEven;

public class Class1
{
    static void Main(string[] args)
    {
        List<int> even = new List<int>();
        List<int> odd = new List<int>();

        for(int i = 0; i <= 20; i++)
        {
            if(i % 2 == 0) even.Add(i);
            else odd.Add(i);
        }
        Console.WriteLine(Environment.NewLine + "Processing Even Numbers");
        foreach(var evenItem in even)
        {
            Console.Write($"{evenItem}->");
        }
        Console.WriteLine(Environment.NewLine + "Processing Odd Numbers");
        foreach(var oddItem in odd)
        {
            Console.Write($"{oddItem}->");
        }
    }
}
