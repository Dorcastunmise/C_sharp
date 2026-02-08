using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await Task.WhenAll(
            PerformLongOperationAsync(),
            PerformLongOperationAsync2()
        );

        PrintNumberStyles();
        Console.WriteLine("\n Main Method ends. \n");
    }

    public static async Task PerformLongOperationAsync()
    {
        Console.WriteLine("\n Operation begins ...");
        await Task.Delay(2000);
        Console.WriteLine("\n Operation ends.");
    }

    public static async Task PerformLongOperationAsync2()
    {
        try
        {
            Console.WriteLine("\n Second operation begins...\n");
            await Task.Delay(3000);
            throw new Exception("\n Simulated error");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n An error occurred: {ex.Message}");
        }
    }

    public static void PrintNumberStyles()
    {
        long bigNumber = 1000000000L;
        float precision = 5.000001F;
        double negative = -55.267D;
        decimal money = 1400.99M;
        int report = 50;

        string name = "John"; //double quote for string
        //single quote for char and a char can't be empty i.e char gender = '';
        //if it has no value to be assigned yet, then it should have the default \0 e.g char gender = '\0';
        char gender = 'M'; 
        string textAge = "-23";
        string hectare = "1000000000";
        long land  = Convert.ToInt64(hectare);
        int age = Convert.ToInt32(textAge);
        string feeRate = "55.26";
        double fee = Convert.ToDouble(feeRate);
        string preciseValue = "12.000000";
        float amount = Convert.ToSingle(preciseValue);
        string moneyGauge = "500";
        decimal bigMoney = Convert.ToDecimal(moneyGauge);



        Console.WriteLine(
            $"With huge expectancy of {bigNumber} numbers, for the land of {land} hectares, \n" +
            $"we have attained at {precision} with a negative of {negative}.\n" +
            $"He has to pay {money}. Though with the new policy in place, the fee can be reduced by {fee}.\n" +
            $"But the report given is {report}/50. Can be weighed to {amount} (the usual being {bigMoney}).\n" +
            $"His name is {name} and his gender is {gender}.\n" +
            $"And he is {age} years old."
        );
    }
}