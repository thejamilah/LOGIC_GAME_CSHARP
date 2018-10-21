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
            //Question4();
            //Console.WriteLine("-----------");
            //Question5();
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

        //public static int Question4()
        //{
        //    Console.WriteLine("How many times have I been to Ireland?");
        //    {

        //    }

        //}
    }
}
