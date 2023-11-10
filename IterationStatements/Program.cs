namespace IterationStatements
{
    public class Program
    {
        public static void PrintRange()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);// Prints range 1000 to -1000
            }
        }

        public static void Threes() // Prints 3s 
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }
        public static void IsEqual(int a, int b) // check if equal
        {
            if (a == b)
            {
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                Console.WriteLine("The numbers are NOT equal");
            }
              
        }
        public static void EvenOrOdd(int num) // check if number is even or odd 
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number");
            }
            else 
            {
                Console.WriteLine($"{num} is an odd number");
            }
        }
        public static void IsPositive(int num) // checks if number is positive or negative
        {
            if (num > 0) 
            {
                Console.WriteLine($"{num} is a postive number");
            }
            else
            {
                Console.WriteLine($"{num} is a negative number");
            }
        }
       public static void CheckVotingAge() // check for voting age 
        {
            Console.WriteLine("What is your age?");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < 18)
            {
                Console.WriteLine($" I am sorry {userInput} is too young to vote");
            }
            else
            {
                Console.WriteLine("You are old enough to vote!"); 
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintRange();
            Threes();
            IsEqual(4, 3);
            EvenOrOdd(5); 
            IsPositive(-45);
            CheckVotingAge();
        }
    }
}
