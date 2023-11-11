using System;

namespace final_project
{
    internal class Program
    {
        static void Divider()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*****************************^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*********************************");
            Console.ResetColor();
        }
        static string Fullname(string name, string lastname)
        {
            return name + " " + lastname;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //Date &Time
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("welcome To Csharpsco course");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("To take this course, you must be under 30 years old and female");
            Console.ResetColor();
            Divider(); Divider();
            Console.WriteLine("Please enter your name:");//Get name
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string lastname = Console.ReadLine();
            string fullname = Fullname(name, lastname);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Hello {fullname}"); Divider();
            Console.WriteLine("please enter your gender: 'F' for Female & 'M' for Male");//Get gender
            string genderSTR = Console.ReadLine();
            Console.WriteLine("please enter your age");//Get age
            string ageSTR = Console.ReadLine();
            int age = Convert.ToInt32(ageSTR);
            string massage = age <= 30 && genderSTR == "F" ? "press any key to contnue" : "Sorry!! You dont have condition for contnue";
            if (genderSTR == "F" && age <= 30)// control condition of age and gender
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine(massage);
                Console.ResetColor();
                ConsoleKeyInfo key = Console.ReadKey();

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(massage);
                Console.ResetColor();
                return;
            }



          
            bool isenteredValidmobileNumberSTR = false;
            for (int i = 0; i < 3; i++)// control mobileNumber
            {
                Console.WriteLine("Please enter your mobileNumber:");
                string mobileNumberSTR = Console.ReadLine();
                if (!string.IsNullOrEmpty(mobileNumberSTR) && mobileNumberSTR.Length == 11)
                {
                    string Submobile = mobileNumberSTR.Substring(0, 2);
                    if (Submobile == "09")
                    {
                        isenteredValidmobileNumberSTR = true;
                        break;
                    }



                }
                

            }
            if (isenteredValidmobileNumberSTR)
            {
                Console.BackgroundColor= ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("yor mobileNumber is registered");
                Console.ResetColor();
                

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong number, tried more than three times, try again in 30 minutes ");
                Console.ResetColor();
                return;
            }
            string discription = $"your Fullname is {fullname},your mobilenumber is {isenteredValidmobileNumberSTR} ";
            Console.WriteLine(discription);





        }


    }

        }










