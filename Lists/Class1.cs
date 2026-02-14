namespace Lists;

public class Class1
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        for(int i =0; i < 3; i++)
        {
            Console.Write("Enter a number:");
            numbers.Add(Convert.ToInt32(Console.ReadLine()));
        }

        for(int n = 0; n <= numbers.Count; n++)
        {
            Console.WriteLine(numbers[n]);   
        }

        numbers.RemoveAt(0);
        foreach(int n in numbers)
        {
            Console.WriteLine(n);
        }

    }
}
