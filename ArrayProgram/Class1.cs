namespace ArrayProgram;

public class Class1
{
    static void Main()
    {
        Console.WriteLine("How many times do you want this to run?");
        int anglesLength = Convert.ToInt32(Console.ReadLine());

        /*
        int[] runtimes = new int[anglesLength];
        for(int i = 0; i <= runtimes.Length; i++)
        foreach(int num in runtimes)
        {
            angle_sum += num;
        }
        */
        int angle_sum = 0;
        /*
        for(int i = 0; i <= angles; i++)
        {
            Console.Write($"Input {i + 1} angle:");
            angle_sum += Convert.ToInt32(Console.ReadLine());
        }     
        */

        Console.WriteLine(angle_sum == 180 ? "Correct!" : "Wrong!");
    }
}
