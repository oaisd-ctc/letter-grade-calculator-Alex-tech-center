using System;


    public class program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Please type a grade from 0-100.");
            int num = int.Parse (Console.ReadLine());

            if (num >= 100) 
            {
                Console.WriteLine("A+");
                Console.WriteLine("Very cool!");
            }

            else if (num >= 90)
            {
                Console.WriteLine("A");
                Console.WriteLine("Really good!");
            }

            else if (num >= 80)
            {
                Console.WriteLine("B");
                Console.WriteLine("Good Job!");
            }

            else if (num >= 70)
            {
                Console.WriteLine("C");
                Console.WriteLine("You got this!");
            }

            else if (num >= 60)
            {
                Console.WriteLine("D");
                Console.WriteLine("You can do better than that.");
            }

            else
            {
                Console.WriteLine("E");
                Console.WriteLine("Don't give up now.");
            }





        }






    }

  

