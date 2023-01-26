namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void PrintThousandRange( int high, int low)
        {
            for (int i = high; i >= low; i--)
            {
                Console.WriteLine(i);
            }

        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void PrintByThree()
        {
            for (int k =3; k <=999; k += 3)
            {
                Console.WriteLine(k);
            }

        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static bool CheckForEqual(int a, int b)

        {
            if (a == b)
            {
                return true;
               
            }
            else
            {
                return false;
  
            }

        }
        
        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd()
        {
            int number;
            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
              
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }



        //Write a method to check whether a given number is positive or negative

        public static void PositiveOrNegative()
        {
            int num;
            Console.WriteLine("Input a number");
            num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine($"{num} is a positive number");
            }
            else
            {
                Console.WriteLine($"{num} is a negative number");
            }
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void VotingAge()
        {
            var age = 29;
            Console.WriteLine("Are you able to vote? Lets see, enter your age");
            age = int.Parse(Console.ReadLine());

            if (age > 18 && age < 80)
            {
                Console.WriteLine("Yay, you are eligible to vote!");

            }
            else
            {
                Console.WriteLine("Sorry, you are not eligble to vote");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void RangeOfTens()
        {
            int userInput;
            Console.WriteLine("Lets see if the the number you pick is within range. Insert a number");
            userInput = int.Parse(Console.ReadLine());

            if (userInput <= 10 && userInput >= -10)
            {
                Console.WriteLine("You are within the given range");
              
            }
            else
            {
                Console.WriteLine("You are not within the given range");
            }

          
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultiplicationTable()
        {
            int userNum, multiplier;
            Console.WriteLine("Enter the number of your choice");
            userNum = Convert.ToInt32(Console.ReadLine());
          

            for (multiplier = 1; multiplier <= 12; multiplier++)
            { 
                Console.WriteLine("{0} * {1} = {2}", userNum, multiplier, (userNum * multiplier));
            }


        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintThousandRange(1000, -1000);

            PrintByThree();

            CheckForEqual(10, 17);

            EvenOrOdd();

            PositiveOrNegative();

            VotingAge();

            RangeOfTens();

            MultiplicationTable();
        }
    }
}
