namespace ClassLibrary1;

public class Class1
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            1000 % 90 + "\n" +
            100 % 90 + "\n" +
            71 % 10 + "\n" 
        );

        Console.WriteLine("Can you enter your name please: ");
        string name = Console.ReadLine();

        // for Write(), the input is maintained on same line as the printed output
        Console.Write("Can you enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Data Summary: Name is {name} and Age is {age}");

        if(age >= 18)
        {
            Console.WriteLine("\nYou're eligible to vote");
        } else
        {
            Console.WriteLine("\nYou're not eligible to vote");
        }

        Console.Write("First Number? ");
        int fstNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("The second number? ");
        int scndNo = Convert.ToInt32(Console.ReadLine());

        if (fstNo < 0 || scndNo < 0)
        {
            Console.WriteLine("Invalid input...provide a number above 0 for both inputs");
        } 
        
        
        
        int rightAns = fstNo * scndNo;
        int userProduct = 0;
        do
        {
            Console.Write("What is the product of your numbers? ");
            userProduct = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

             if (userProduct != rightAns) {
                Console.WriteLine("Close but was still wrong!");
                Console.WriteLine();
            }

        }
        while (userProduct != rightAns);
        
        /*
            {
            Console.Write("What is the product of your numbers? ");
            userProduct = Convert.ToInt32(Console.ReadLine());

            if (userProduct != rightAns) {
                Console.WriteLine("Close but was still wrong!");
                Console.WriteLine();
            }

        } */

        Console.WriteLine("Correct!");


    }
}
