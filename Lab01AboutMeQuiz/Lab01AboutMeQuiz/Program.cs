using System;
//using statement System give acces to libraries within the program. Example Console.WriteLine would no run without this and you would have to input System.Console.WriteLine every time

namespace Lab01AboutMeQuiz
{
    class Program
    {
        //Public>access modifier; Void>returns no value; Main>entry point of the program; Takes an array of strings as arguments
        //C# is looking at program and then is looking for the MAIN method(function) to start running at

        public static void Main(string[] args)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("About Me");
            Console.WriteLine("-----------");
            Question1();
            Console.WriteLine("-----------");
            Question2();
            Console.WriteLine("-----------");
            Question3();
            Console.WriteLine("-----------");
            BirthMonth();
            Console.WriteLine("I'm a motorcycle enthusiast! Please answer True or False.");
            Question4();
            Console.WriteLine("-----------");
            Console.WriteLine("I enjoy cooking so much that I went to culinary school right after high school.");
            //used another write line because of screen space
            Console.WriteLine("Where's one of the many best places in the world that I went to experience pastry artistry?"); 
            Question5();
            Console.WriteLine("-----------");
            Console.WriteLine("Thanks for getting to know a little about me");
        }

        //"static" method can be used in main method "void" is the return type that does not return a value
        public static void Question1()
        {
            Console.WriteLine("Hi, What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!" + " My name is Jamilah, nice to meet you!");

        }

        public static void Question2()
        {
            Console.WriteLine("Where are you from?");
            string where = Console.ReadLine();
            Console.WriteLine("You're from " + where + "!" + " Awesome!" + " I was born and raised in Seattle.");
        }

        //this is a void method that is inserting a non void return type into the method. I wanted to use the following block of code to experiment a little bit write and read line 
        public static void Question3()
        {
            Console.WriteLine("What month were you born in?");
            Console.WriteLine("You were born in " + BirthMonth() + ". Cool!");
            Console.WriteLine("I was born in June. #GEMINIS RULE!");
        }

        //"string" is the return type
        public static string BirthMonth()
        {
            return Console.ReadLine();
        }

        //this is a non void method with a return type of bool for a true or false response from the program user
        public static bool Question4()
        {
            
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "true")
            {
                Console.WriteLine("Yes, I am! I've owned two. Unfortunately the first one got totalled.");
                return true;
                
            }
            else
            {
                Console.WriteLine("You answered false. The answer is true.");
                return false;
            }

        }

        //this is a non void method with a string as a return type
        public static string Question5()
        {
            string userInput = Console.ReadLine().ToLower();
            try
            {
                
                if (userInput == "paris")
                {
                    Console.WriteLine("Absolutely! I ate my way through Paris one pastry and awesome dish after another");
                }
            }

            finally

            {
                
                Console.WriteLine("You must enter a city name");
                
                if (userInput == "paris")
                {
                    Console.WriteLine("Absolutely! I ate my way through Paris one pastry and awesome dish after another");
                }
                else
                {
                    Console.WriteLine("You didn't guess correctly. I went to Paris!");
                }


            }
            
            return userInput;
            //non void methods need a return
        }



    }
}
