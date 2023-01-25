namespace Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Grade in ISM 4300: ");
            // try catch
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                
                if(n1>=0 && n1 < 60)
                {
                    Console.WriteLine("Your letter grade is F");
                }
                else if (n1 >= 60 && n1 < 70)
                {
                    Console.WriteLine("Your letter grade is D");
                }
                else if (n1 >= 70 && n1 < 80)
                {
                    Console.WriteLine("Your letter grade is C");
                }
                else if (n1 >= 80 && n1 < 90)
                {
                    Console.WriteLine("Your letter grade is B");
                }
                else if (n1 >= 90 && n1 <= 100)
                {
                    Console.WriteLine("Your letter grade is A");
                }
                else
                {
                    Console.WriteLine(" Your marks are not valid");
                } // end try
            }
            catch 
            {
                Console.WriteLine("Please enter a numeric value. Try again. ");
            } // end try
        }
    }
}