namespace Dictionaries;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        Dictionary<int, string> names = new Dictionary<int, string>
        {
            {1, "Aba"},
            {10, "Aban"},
            {101, "Abani"}
        };

        for (int i = 0; i < names.Count; i++)
        {
            KeyValuePair<int, string> pair = names.ElementAt(i);
            Console.WriteLine($"{pair.Key} {pair.Value}");
        }

        Console.WriteLine();

        foreach(KeyValuePair<int, string> item in names)
        {
            Console.WriteLine($"{item.Key} {item.Value}");
        }
        */

        Dictionary<string, string> teachers = new Dictionary<string, string>
        {
            {"Math", "Dickson"},
            {"English", "Esther"},
            {"History", "Binta"},
            {"Economics", "Jake"},
            {"Physics", "Enoch"}
        };

        if(teachers.TryGetValue("Math", out string teacher)) {
            Console.WriteLine(teacher);
            teachers["Math"] = "Joe";
        }
        else Console.WriteLine("Teacher not found");

        Console.WriteLine();

        if(teachers.ContainsKey("Math"))
        {
            teachers.Remove("Math");
        }
        else
        {
            Console.WriteLine("Teacher not found");
        }
        
        foreach(var item in teachers)
        {
            Console.WriteLine($"{item.Key} {item.Value}");
        }
         
        Console.WriteLine(teachers.Count);


    }
}
