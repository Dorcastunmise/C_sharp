namespace Exceptions;

public class Class1
{
    static void Main()
    {
        /*
        bool looping = true;
        
        while(looping)
        {
            try
            {
                Console.Write("Enter an integer: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You entered: " + number);
                looping = false;
            }
            catch(FormatException)
            {
                Console.WriteLine("Input was not in a correct format. Please enter a valid number.");
                looping = true;
            }
            catch(OverflowException)
            {
                Console.WriteLine("The number entered is too large or too small. Please enter a number within the valid range(2 billion).");
                looping = true;
            }
            catch(Exception e)
            {
                string errorMsg = e.Message;
                Console.WriteLine(errorMsg);
                looping = true;
            }
        }

        Console.WriteLine("Program has ended. Press any key to exit.");
        Console.ReadLine();

        */

        Console.Write("Enter an integer to parse: ");   
        if(TryParse(Console.ReadLine(), out int result)) Console.WriteLine("Parsed number: " + result);
        else Console.WriteLine("Failed to parse the input as an integer.");

    }

    static bool TryParse(string input, out int result)
    {
        result = -1;
        try
        {
            result = Convert.ToInt32(input);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

}
