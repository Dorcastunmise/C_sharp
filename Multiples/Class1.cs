namespace Multiples;

public class Class1
{
    static void Main()
    {
        Console.WriteLine("Enter the integer value:");
        int num = Convert.ToInt32(Console.ReadLine());
    
        Console.WriteLine("Enter the size of the array you expect:");
        int arr_size = Convert.ToInt32(Console.ReadLine());

        int[] result = new int[arr_size];
        int counter = 0;

        for(int i = 1; i <= result.Length; i++, counter++)
        {
            result[counter] = num * i;
            Console.Write(result[counter] + ", ");
        }


    }

}
