using System.Net;

namespace TraingleArea;

public class Class1
{
    static void Main()
    {
        int width = MsgEnquiryNumbers("What is the width of the supposed Triangle");
        int height = MsgEnquiryNumbers("What is the height of the supposed Triangle");

        int area = Area(width, height);
        if(area == 0) Console.WriteLine("Both the height and width values have to be greater than 0");
        else Console.WriteLine($"The area of the triangle is {area}");
    }


    static int Area(int width, int height)
    {
        if(width > 0 && height > 0)
        {
            int area = width * height / 2;
            return area;
        }
        return 0;
    }

    static int MsgEnquiryNumbers(string message)
    {
        Console.Write(message + ": ");
        int intResponse = Convert.ToInt32(Console.ReadLine());
        return intResponse;
    }

    static string MsgEnquiryText(string message)
    {
        Console.Write(message + ": ");
        string response = Console.ReadLine();
        return response;
    }
}
