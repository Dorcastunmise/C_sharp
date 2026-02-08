namespace Exercise;

public class Program
{
    static void Main(string[] args)
    {
        /*
            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine(string.Format("{0} x {1} = {2}", i, input, i * input));
            }
        */

        bool threeDiv = false;
        bool fiveDiv = false;

        for(int i = 1; i <= 15; i++)
        {
            threeDiv = i % 3 == 0;
            fiveDiv = i % 5 == 0;

            if(threeDiv && fiveDiv)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if(threeDiv)
            {
                Console.WriteLine("Fizz");
            }
            else if(fiveDiv)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
