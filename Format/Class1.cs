using System.Globalization;

namespace Format;

public class Program
{
    static void Main(string[] args)
    {
        double value = 1000D / 12.34D;
        Console.WriteLine(value);
        DateTime today = DateTime.Now;
        Console.WriteLine("Enter your name ? ");
        string name = Console.ReadLine();

        //"{0} {1}" means value will be displayed first then 1000
        //Console.WriteLine(string.Format("{0} {1}", value, 1000));

        //{0:0.00} means the entire integer part and first 2 decimal place of value gets displayed
        Console.WriteLine(string.Format("{0:0.00}", value));
        Console.WriteLine(string.Format("{0:0.#}", value));
        Console.WriteLine(string.Format("Hello, {0}! Today's date is {1:MMMM dd, yyyy}.", name, today));
        Console.WriteLine();

        decimal price = 19.99m;
        string result = String.Format("The price is {0:C}.", price);
        Console.WriteLine(result);
        Console.WriteLine();
        // Output might be: The price is $19.99. (depending on your system's culture)

        double sample = 123.45678;
        result = String.Format("sample: {0:F2}", sample);
        Console.WriteLine(result);
        Console.WriteLine();
        // Output: Value: 123.46

        /*
        Padding and Alignment
        Control spacing and alignment using a comma after the index, followed by the desired width. 
        A positive number aligns right, and a negative number aligns left.
        */
        string item = "Apple";
        price = 1.50M;
        double money = -10D / 3D;
        result = String.Format("{0,-10} {1,10:C}", item, price);
        Console.WriteLine(result);
        Console.WriteLine(money.ToString("C0"));
        Console.WriteLine(money.ToString("C1"));
        Console.WriteLine();

        /*
            Hexadecimal Formatting
            Format an integer as a hexadecimal string using the X specifier.
        */
        int number = 255;
        result = String.Format("The number {0} in hexadecimal is {0:X}.", number);
        Console.WriteLine(result);
        Console.WriteLine();
        // Output: The number 255 in hexadecimal is FF.

        /*
            Including Literal Braces
            To output a literal brace ({ or }), double them ({{ or }}).
        */
        result = String.Format("Literal braces: {{ and }}");
        Console.WriteLine(result);
        Console.WriteLine();
        // Output: Literal braces: { and }


        Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
        Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-NG")));
        Console.WriteLine();
        
        Console.ReadLine();
    } 
}
