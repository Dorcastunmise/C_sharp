using Microsoft.VisualBasic;

namespace TryParse;

public class Program
{
    static void Main(string[] args)
    {
        bool check = true;
        while (check)
        {
            Console.Write("Enter a number: ");
            string inputNum = Console.ReadLine();
            //int formtVal = 0;

            if (int.TryParse(inputNum, out int formtVal))
            {
                check = false;
                Console.WriteLine(formtVal);
            } else {
                Console.WriteLine("Failed to convert! ");
            }
        }        

        Console.WriteLine();
    }

}
