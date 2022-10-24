using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoarding
{
    public class HumanClass
    {
      
     
        
        
        //public  string firstName = "Timileyin";

        //public void IntroduceMyself()
        //{
        //    Console.WriteLine("Hi am {0} ", firstName); 
        //}
        public string firstName;
        public string lastName;

        public HumanClass(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi i am {0} {1}" , firstName, lastName);
        }

        public void name(string firstName, string lastName)
        {
            this.firstName=firstName;
            this.lastName = lastName;
        }
        public void  ame(string firstname)
        {
            this.firstName = firstName;
        }
        public void name()
        {
            if(firstName != null && lastName != null)
            {
                Console.WriteLine("Hi my name is {0} {1}" ,firstName, lastName);
            }
            else
            {
                Console.WriteLine("Hi I'm {0} {1}. I am not a young boy any more", firstName, lastName);
            }
        }
        public void ame()
        {
            if (firstName != null )
            {
                Console.WriteLine("Hi my name is {0} ", firstName);
            }
            else
            {
                Console.WriteLine("Hi I'm {0} . I am not a young boy any more", firstName);
            }
        }
    }
}
