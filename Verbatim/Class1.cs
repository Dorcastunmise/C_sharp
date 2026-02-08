namespace Verbatim;

public class Program
{
    static void Main(string [] args)
    {
        string path = "C:\\xampp\\htdocs\\console_app\\Verbatim\n";
        Console.WriteLine(path);

        path = @"C:\xampp\htdocs\console_app\Verbatim" + "\n";
        string name = @"Hello ""Someone!""";
        
        Console.WriteLine();
        Console.WriteLine("{0} \n {1}", name, path);
        Console.WriteLine($"{name} \n {path}");
        name = "Tunmise";
        Console.WriteLine();
        Console.WriteLine(string.Concat("Your name is ", name,"\n","this file is situated at ",path));

        Console.WriteLine();
        string[] students = ["Jackson ", "Eben ", "Aaron "];
        Console.WriteLine(string.Concat(students));

        name = ""; 
        //or
        name = string.Empty;
        Console.WriteLine();

        string limit = "pinned";
        string based  = "Pinned";

        //if(limit == based)
        /*
            if(.Equals() checks the literal values of the variables
            and ==  checks the values held inside the memory address
        */
        if(limit.Equals(based))
        {
            Console.WriteLine("Same!");
        }
        //else if(limit != based)
        else if(!limit.Equals(based))
        {
            Console.WriteLine("Different!");
        } else
        {
            Console.WriteLine("Nothing!");
        }

        Console.WriteLine();
        char[] chars = ['p', 'i', 'n', 'n', 'e', 'd'];
        object newCompare = new string(chars);

        //if(limit == newCompare) = Different! == compares string object to an object
        if(limit.Equals(newCompare)) Console.WriteLine("Same!");
        else Console.WriteLine("Different!");

        Console.WriteLine();

    }
}
