namespace _8._10._password_generator;

class Program
{
    static void Main(string[] args)
    {
        string lastName = Input.AskString("What's your lastname? ");
        string phoneNumber = Input.AskString("Enter your phone number? ");
        int postalCode = Input.AskInteger("Enter your postal Code? ");
        

        string password = GeneratePassword(lastName, phoneNumber, postalCode);
        Console.WriteLine($"Your generated password is {password}");
    }
    // Methods
    public static string GeneratePassword(string lastName, string phoneNumber, int postalCode)
    {
        char [] nameFieldTemp = lastName.ToCharArray();
        char [] phoneNumberTemp = phoneNumber.ToCharArray();
        int number = (postalCode / 1000);
        double power = 2.0;
        double postalCodeField = Math.Pow(number,power);
        char[] password = { Char.ToUpper(nameFieldTemp[0]), Char.ToLower(nameFieldTemp[1]), phoneNumberTemp[1], phoneNumberTemp[2] };
        string passwordPart1 = new string(password);
        string composedPWD = passwordPart1 + postalCodeField;

        return composedPWD;
    }
   
    // Classes
    public static class Input
    {
        public static string AskString(string question)
        {
            Console.Write($"{question}");
            return Console.ReadLine() ?? string.Empty;
        }
        public static int AskInteger(string question)
        {
            while (true)
            {
                Console.Write($"{question}");
                if (int.TryParse(Console.ReadLine(), out int r))
                    return r;

            }
        }
        public static char AskChar(string question)
        {
            while (true)
            {
                Console.Write($"{question}");
                if (char.TryParse(Console.ReadLine(), out char r))
                    return r;

            }


        }

        public static double AskDouble(string question)
        {
            while (true)
            {
                Console.Write($"{question}");
                if (double.TryParse(Console.ReadLine(), out double r))
                    return r;


            }
        }
    }
}
