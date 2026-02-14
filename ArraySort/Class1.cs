namespace Arrays;

public class Class1
{
    static void Main()
    {
        //Sort
        int[] numbers = new int[]
        {
            1,2,6,3,1,88,3,0,9
        };

        Array.Sort(numbers);

        foreach(int num in numbers)
        {
            Console.Write(num);
        }
        Console.WriteLine();
        //--------------

        //Reversal
        int[] people = new int[]
        {
          5,8,9,2,4  
        };
        Array.Reverse(people);

        foreach(int num in people)
        {
            Console.Write(num);
        }
        Console.WriteLine();

        int[] streets = new int[]
        {
            0,1,2,3,4,5,6,7,8,9
        };
        int x = 0;
        int n = streets.Length;
        int[] sortedStreets = new int[n];
        for(int i = streets.Length - 1; i >= 0; i--)
        {
            sortedStreets[x] = streets[i];
            x++;
        }
        foreach(int num in sortedStreets)
        {
            Console.Write(num);
        }
        Console.WriteLine();
        //--------------

        //IndexOf()
        Console.WriteLine("Enter the number you want to search for...");
        int search = Convert.ToInt32(Console.ReadLine());

        /*
        int position = Array.IndexOf(numbers, search); --everything
        last parameter is to indicate the starting position for searching
        int position = Array.IndexOf(numbers, search,2);  --2nd index to the end
        second to last parameter is to indicate the starting position for searching , while 2 is the index where the search ends
        int position = Array.IndexOf(numbers, search,0,2); --0th index to 2nd
        if(position > -1 )//IndexOf returns -1 if it fails
        {
            Console.WriteLine($"Number {search} was found at {position + 1}");
        }
        else
        {
            Console.WriteLine($"Number {search} was not found");
        }
        */

        //or
        int position = -1;
        for(int i= 0; i < numbers.Length; i++)
        {
           if(numbers[i] == search)
            {
                position = i;
                break;
            } 
        }

        if(position > -1 )  Console.WriteLine($"Number {search} was found at {position + 1}");
        else Console.WriteLine($"Number {search} was not found");
        
        //------------

        //Clearing
        //resetting numbers content to default(i.e 0) from position 6 to its end
        Array.Clear(numbers, 6, numbers.Length); 

        //or
        for (int i = 6; i < numbers.Length; i++)
        {
            numbers[i] = default;//or 0;
        }

        foreach (var item in numbers)
        {
            Console.Write(item);
        }
        //--------------
    }

}
