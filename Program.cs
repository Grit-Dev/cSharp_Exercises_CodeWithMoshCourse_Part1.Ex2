using System;

namespace program
{
    class Program
    {
        public static void Exercise1()
        {
            const int MAX = 100;
            int total = 0;

            /*Write a program to count how many numbers 
            between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.
            */

            for (int i = 0; i < MAX; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i +" ");
                    total++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Total numbers divisible by [{MAX}] is: [{total}] \n");

        }

        public static void Exercise2()
        {
            /*Write a program and continuously ask the user to enter a number or "ok" to exit. 
              Calculate the sum of all the previously entered numbers and display it on the console.
            */

            
            bool isTrue = true; 
            int sum = 0; 

            while (isTrue)
            {
                try
                {
                    Console.WriteLine("Please enter in a number or type 'okay' to exit");
                    var userInput = Console.ReadLine();

                    if (userInput.ToLower() == "okay")
                    {
                        break;
                    }
                    else
                    {
                        sum = sum + Int32.Parse(userInput);
                    }

                    Console.WriteLine($"The total is: [{sum}]");
                }
                catch (Exception)
                {
                    Console.WriteLine("You did not enter a numerical number or entered something else that was not 'Okay");
                }
              
            }

            Console.WriteLine("Thank you for using the system \n");

        }

        public static void Exercise3()
        {

            ///Write a program and ask the user to enter a number.Compute the factorial of the number and print it on the console. 
            ///For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            int userInput;
            int total = 0;

            try
            {
                Console.WriteLine("Please enter in a number");
                userInput = Int32.Parse(Console.ReadLine());

                total = userInput;

                for (int i = 1; i < userInput; i++)
                {
                    
                    total = total * i;
                    Console.Write(total + " ");


                }

                Console.WriteLine($"Factorial of {userInput}! = {total}");
            }
            catch (Exception)
            {
                Console.WriteLine("You did not enter in a digit number");
            }

            

              
        }

        public static void Exercise4()
        {
            /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
            /// If the user guesses the number, display “You won"; otherwise, display “You lost". 
            /// (To make sure the program is behaving correctly, you can display the secret number on the console first.)
            /// 

            const string NOTE = "NOTE: You will not lose any chances because of this";
            const int ZERO = 0;
            const int MAX = 10;
            int theRandomNumber;
            int chances = 4;
            int userInput;
            int i = 0;

            Random random = new Random();
            theRandomNumber = random.Next(1, 10);

            Console.WriteLine($"Testing purposes: Secret answer is: {theRandomNumber} \n");

            try
            {

                while (i < chances)
                {
                    if (chances == ZERO)
                    {
                        break;
                    }

                    Console.WriteLine("Welcome to the guessing game!");
                    Console.WriteLine("Please select a random positive number");
                    userInput = Int32.Parse(Console.ReadLine());

                    if (userInput < ZERO || userInput > MAX)
                    {
                        Console.WriteLine("You entered in a negative number or a number greater that 10");
                        Console.WriteLine(NOTE);
                        Console.WriteLine("Please try again \n");
                       
                    }
                    else if (userInput == theRandomNumber)
                    {
                        Console.WriteLine("Congratulations");
                        Console.WriteLine($"You had {chances} left \n");
                        break;
                    }
                    else
                    {
                        chances = chances - 1;
                        Console.WriteLine("You Lost!!!");
                        Console.WriteLine($"You have {chances} remaining \n");
                        
                    }

                }

            }
            catch (Exception)
            {
                Console.WriteLine("You did not enter in a number \n");
                Console.WriteLine(NOTE);
                

                Exercise4();
            }

            Console.WriteLine("Thank you for playing! \n");
        





        }

        public static void Exercise5()
        {
            ///Write a program and ask the user to enter a series of numbers separated by comma. 
            ///Find the maximum of the numbers and display it on the console. 
            ///For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            ///


            try
            {
                Console.Write("Enter commoa separated numbers: ");
                var input = Console.ReadLine();

                var numbers = input.Split(',');


                var max = Convert.ToInt32(numbers[0]);

                foreach (var str in numbers)
                {
                    var number = Convert.ToInt32(str);
                    if (number > max)
                        max = number;
                }

                Console.WriteLine("Max is " + max);
            }
            catch (Exception)
            {
                Console.WriteLine("You did not enter a digit number or used commas");
            }



        }


        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();


            
        }
    }
}
