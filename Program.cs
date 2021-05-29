using System;
using System.Threading;

namespace age_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var repeatProgram = true;
            while (repeatProgram == true)
            {
                var repeatQuestionDate = true;
                DateTime parsedBirthdate = new DateTime();
                Console.WriteLine("please enter your birthdate in this format: yyyy-mm-dd");
                while (repeatQuestionDate == true)
                {
                    try
                    {
                        var birthdate = Console.ReadLine();
                        parsedBirthdate = DateTime.Parse(birthdate);
                        repeatQuestionDate = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("the format of the birthdate is not correct");
                        Thread.Sleep(1000);
                        Console.WriteLine("please reenter your birthdate in this format: yyyy-mm-dd");
                        repeatQuestionDate = true;
                    }
                }
                DateTime currentDate = DateTime.Now;
                TimeSpan age = currentDate.Subtract(parsedBirthdate);
                var ageInSecondsDouble = age.TotalSeconds;
                long ageInSecondsLong = 0;
                ageInSecondsLong = Convert.ToInt64(ageInSecondsDouble);
                if (ageInSecondsLong > 0)
                {
                    Console.WriteLine($"your age is seconds is {ageInSecondsLong}");
                }
                else
                {
                    Console.WriteLine($"you entered a future birthdate, it didn't happen yet");

                }
                Thread.Sleep(1000);
                Console.WriteLine("do you want to try another birthdate? please enter yes or no");
                while (true)
                {
                    var repeatAnswer = Console.ReadLine().ToLower();
                    if (repeatAnswer == "yes")
                    {
                        repeatProgram = true;
                        Console.Clear();
                        break;
                    }
                    else if (repeatAnswer == "no")
                    {
                        repeatProgram = false;
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("please enter either yes or no");
                    }
                }
            }
        }
    }
}