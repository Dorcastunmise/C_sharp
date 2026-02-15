namespace Debugging;

public class Class1
{
    static void Main()
    {
        string name = "Alice";
        int age;
        age = 30;

        printDetails(name, age);
        string msg = readFromConsole("Enter a message to display: ");
        Console.WriteLine(msg);
    }

    static void printDetails(string name, int age)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    static string readFromConsole(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}
