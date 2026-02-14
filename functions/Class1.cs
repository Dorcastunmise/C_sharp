using System.Reflection;
using System.Runtime.InteropServices;

namespace functions;

public class Class1
{
    static void Main(string[] args)
    {
        //Console.Title = Author();


        int[] arr_no = ArrayContent();
        for (int i = 0; i < arr_no.Length; i++)
        {
            arr_no[i] = ReadConsoleNumbers("Enter a number");
        }

        foreach(var item in arr_no)
        {
            Console.WriteLine($"{item}");
        }

        Introduction();
        Console.WriteLine();
        CreateAndPrintArray();
        Console.WriteLine();

        int msgNo = ReadConsoleNumbers("Enter an angle");
        int msgNo2 = ReadConsoleNumbers("Enter second angle");
        Console.WriteLine(Add(msgNo,msgNo2));

        //----------
        
        List<string> beverageList = new List<string>
        {
            "Capuccino", "Coffee", "Tea" 
        };

        string CartItem = ReadConsoleString("Enter a beverage");
        bool whey = SearchList(CartItem, beverageList, out int index);
        Console.WriteLine(whey ? $"Fetched at {index}!" : "Not Found!"); 
        //-------------   

        int numerical_data = 10;
        Assign(out numerical_data);
        Console.WriteLine(numerical_data);
        
        //--------------Reference parameters
        int trialAge = 20;
        string trialName = "Tester";
        RefTest(name: ref trialName, age: ref trialAge);

        string newNames = ReadConsoleString("Enter your new name");
        if(NameChange(ref trialName, newNames)) Console.WriteLine($"Your new name is {trialName}!");
        else Console.WriteLine($"Your new name cannot be empty!");
        

    } 
    static bool NameChange(ref string name, string newName)
    {
        if(!string.IsNullOrEmpty(newName))
        {
            name = newName;
            return true;
        }
        return false;
    }

    static void Assign(out int num)
    {
        num = 20;
    }

    static void RefTest(ref int age, ref string name)
    {
        //Assignment not compulsory in ref
    }
    
    static bool SearchList(string s, List<string> list, out int index)
    {

        index = -1;

        for(int i = 0; i < list.Count; i++)
        {
            if(list[i].ToLower().Equals(s.ToLower()))
            {
                index = i;
            }
        }    
        bool search = index > -1;

        return search;
    }   

    //static int Add(int a, int b = default) or...
    //static int Add(int a, int b = 0) or...
    //static int Add(int a, string b = "") or...
    //static int Add(int a, string b = "Adain") or...
    //static int Add(int a, string b = default) or...
    static int Add(int a, [Optional] int b)
    {
        return a + b;
    }
    static int[] ArrayContent() {
        return new int[3] { 6, 12, 3 };  
    }
    static int ReadConsoleNumbers(string message)
    {
        Console.Write($"{message}: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    static string ReadConsoleString(string message)
    {
        Console.Write($"{message}: ");
        return Console.ReadLine();
    }
    //static keyword make the function accessible anywhere without the need to instantiate 
    //e.g void CreateAndPrintArray() will need int res_arr = new CreateAndPrintArray(); in Main()
    static void CreateAndPrintArray()
    {
        int[] numbers = new int[6];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 2;
            Console.Write(numbers[i] + ", ");
        }
    }

    static string Author()
    {
        string author = ReadConsoleString("Kindly enter your name");
        return author;
    }
    static void Introduction()
    {
        string sectorInput = ReadConsoleString("Enter your sector");
        int ageInput = ReadConsoleNumbers("Enter your age");
        string addressInput = ReadConsoleString("Enter your address");

        //the attaching of the parameters in the userDeatails() is too allow the misarrangement of the passed arguments by specifying the actual parameter they're meant for
        // ...this is referred to as named parameters
        Console.WriteLine($"Hi, I'm {Author()} !{UserDetails(address: addressInput, sector: sectorInput, age: ageInput)}"); 
    }

    static string UserDetails(string sector, int age, string address)
    {
        return $"My sector is {sector} and I am {age} years old.";
    }

    
}
