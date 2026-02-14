namespace IsNullOrEmpty;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your password: ");
        string pass = Console.ReadLine();
    
        Console.Write("Confirm your password:");
        string confirm_pass = Console.ReadLine();

        //if (!string.IsNullOrEmpty(pass) && !string.IsNullOrEmpty(confirm_pass))
        if (!pass.Equals(string.Empty))
        {      
            if(pass.Length >= 6 && confirm_pass.Length >= 6) {   
                if (!confirm_pass.Equals(string.Empty))
                {
                    if(pass.Equals(confirm_pass)){
                        Console.WriteLine("Passwords match!");
                    }
                    else {
                        Console.WriteLine("Passwords do not match!");                  
                    }
                } else
                        {
                            Console.WriteLine("Please confirm password");
                        }
            } else
            {
                Console.WriteLine("Passwords must be at least 6 characters long");
            }

           
        } else
        {
            Console.WriteLine("Please provide a password");
        }
        
        

    }
}
