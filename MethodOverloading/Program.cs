namespace MethodOverloading
{
    public class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("This is the sum of:  3,3");
            Console.WriteLine(Add(3, 3));
            Console.WriteLine();
            Console.WriteLine("This is the sum of:  3.3,3.2");
            Console.WriteLine(Add(3.3m, 3.2m));
            Console.WriteLine();
            Console.WriteLine("Enter a first number to sum...");
            string r = Console.ReadLine();
            Console.WriteLine("Enter a second number to sum...");
            string s = Console.ReadLine();
            Console.WriteLine("Enter 'true' to continue processing...");
            Console.WriteLine("Or, 'false' to cancel program...");
            bool b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(Add(r, s, b));
        }

        //Add method with ints
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        //Add method with decimals
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }


        //Add method with strings and boolean
        public static string Add(string num1, string num2, bool b)
        {
            int answ = int.Parse(num1) + int.Parse(num2);
            

            if (answ > 1 && b == true)
                return $"The sum is {answ} dollars";
              

            else if (answ == 1 && b == true)
                return $"The sum is {answ} dollar";
                    
         
            else
                 return ($"Program stopped!  The boolean value is false");
              





            
        }
    }
}
