//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using WhiteBoarding;

namespace John
{
    class program
    {
        static void Main(string[] args)
        {
            //for (int love = 0; love <= 50; love += 5)
            //{
            //    Console.WriteLine(love +" IS LOWER THAN 50");
            //}

            //for (int odd = 1; odd <= 20;odd += 2)
            //{
            //    Console.WriteLine(odd);
            //}


            //int Counter = 0;
            //do
            //{
            //    Console.WriteLine(Counter);
            //    Counter++;
            //}
            //while (Counter < 5);

            //int lenghtOfText  = 0;
            //string wholeText = "";
            //do
            //{
            //    Console.WriteLine("Please enter the name of your friend");
            //    string nameOfAFriend = Console.ReadLine();
            //    int currentLength = nameOfAFriend.Length;
            //    lenghtOfText += currentLength;
            //    wholeText += nameOfAFriend;
            //} while (lenghtOfText < 20);
            //Console.WriteLine("Thanks, that was enough!" + wholeText);



            //int counter = 0;
            //while (counter < 10)
            //{

            //    Console.WriteLine(counter);
            //    counter++;
            //}


            //Console.WriteLine("Please press enter to enter inside the bus");

            //int count = 0;

            //string enterText = "";
            //while (enterText.Equals(""))
            //{
            //    Console.WriteLine("please press enter to increase the amount by one");
            //    enterText = Console.ReadLine();

            //    count++;
            //    Console.WriteLine("Current people count {0} ", count);

            //}

            //HumanClass John = new HumanClass();
            //John.firstName = "John";
            //John.IntroduceMyself();

            //HumanClass micheal = new HumanClass();
            //micheal.firstName = "micheal";
            //micheal.IntroduceMyself();

            //HumanClass Timileyin = new HumanClass();
            //Timileyin.firstName = "Peter";
            //Timileyin.IntroduceMyself();

            HumanClass love = new HumanClass("divid", "ade");
            love.IntroduceMyself();

            HumanClass oruko = new HumanClass("sam", "ken");
            oruko.name();

            HumanClass myname = new HumanClass("sam", "ken");
            oruko.ame();
        }
    }
}
