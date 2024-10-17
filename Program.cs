namespace FormatException
{
    class Program
        {
            static void Main()
            {
                try
                {
                    Console.Write("Enter a number: ");
                    string input = Console.ReadLine();

                    // Convert the input to an integer
                    int number = int.Parse(input);

                    Console.WriteLine($"The number you entered is: {number}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number."+ex.Message);
                }
            }
        }
    }

