namespace ArraySum;

public class Class1
{
     static void Main(string[] args)
    {
        int[] numbers = new int[]
        {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9
        };

        bool result = ArraySum(numbers, out int sum);
        if(result) Console.WriteLine($" The total is {sum}");
        else Console.WriteLine("Cannot add up an empty array!");
    }

    static bool ArraySum(int[] numbers, out int sum)
    {
        sum = 0;
        if(numbers.Length > 0){
           
            foreach(int number in numbers)
            {
                sum += number;
                //Console.WriteLine($"Sum: {sum} + {number}");
            }

            return true;
        } else {
            return false;
        }
    }

}
