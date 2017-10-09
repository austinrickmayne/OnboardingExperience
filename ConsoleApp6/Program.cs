using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingExperience
{
    class Program
    {

        static void Main(string[] args)

        {
            var user = new User();
            Console.WriteLine("Hey there!Welcome to our Onboarding Experience!");

            user.FirstName = AskQuestion("What is your first name?");
            Console.WriteLine("Awesome! Your name is " + user.FirstName);

            user.LastName = AskQuestion("What is your last name?");
            Console.WriteLine("Awesome! Your full name is " + user.FirstName + "" + user.LastName);

            user.IsAccountOwner = AskBoolQuestion("Are you the account owner?");
            Console.WriteLine("Awesome! You are account owner : " + user.IsAccountOwner);

            user.PinNumber = AskPinNumber("What is your 4 - digit pin?", 4 );
            Console.WriteLine("Yes, we can use that. Keep this for your records: " + user.PinNumber);

        }

        public static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static bool AskBoolQuestion(string question)
        {
            var hasAnsweredCorrectly = false;
            var responseBool = false;

            while (!hasAnsweredCorrectly)
            {
                var response = AskQuestion(question + " (y/n)");

                if (response == "y")
                {
                    responseBool = true;
                    hasAnsweredCorrectly = true;
                }
                else if (response == "n")
                {
                    responseBool = false;
                    hasAnsweredCorrectly = true;
                }
            }

            return responseBool;
        }

        static string AskPinNumber(string question, int length)
        {
            string numberString = null;
            while (numberString == null)
        

            {
                var response= AskQuestion(question);

                if (response.Length == length && Int32.TryParse(response, out int _))
                {            
            
                  numberString = response; 
                
                }
            }

                    return numberString;
                    
        }
                
                                 


        


    }

    
}