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
        public static string MobileNumber(string mobile)
        {
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
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("yor mobileNumber is registered");
                    Console.ResetColor();

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number, tried more than three times, try again in 30 minutes ");
                    Console.ResetColor();

                }
            return mobile;
        }
     
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //Date &Time
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("welcome To Computer school");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("********To take this course, you must be under 30 years old and Female********");
            Console.ResetColor();
            Divider(); Divider();



            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Please enter your name as person "+ (i+1));//Get name
                string name = Console.ReadLine();
                Console.WriteLine("Please enter your last name:");
                string lastname = Console.ReadLine();
                string fullname = Fullname(name, lastname);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Hello {fullname}"); Divider();
                while(true)
                    {

                    try
                    {
                        Console.WriteLine("please enter your gender: 'F' for Female & 'M' for Male");//Get gender
                        string genderSTR = Console.ReadLine();
                        Console.WriteLine("please enter your age");//Get age
                        string ageSTR = Console.ReadLine();
                        int age = Convert.ToInt32(ageSTR);
                        if (genderSTR == "F" && age <= 30)//control age
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("press any key to contnue");
                            Console.ResetColor();
                            ConsoleKeyInfo key = Console.ReadKey();

                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Sorry!! You dont have condition for contnue");
                            Console.ResetColor();
                            return;
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("please enter just number.....!");
                        throw;
                    }
                    i++;
                    if (true)
                        break;
                }
         
                string mobileSTR = Console.ReadLine();
                MobileNumber(mobileSTR);
                string discription = $"your Fullname is {fullname},your mobilenumber is {mobileSTR}";
                Console.WriteLine(discription);
                Console.WriteLine("If it is correct, type 'T'; Otherwise, go through the steps again");
                var discribtion = Console.ReadLine();

                if (discribtion == "T")
                {
                    Console.WriteLine($"Hi {name}, Please select your appropriate course from the list below and Enter the course number :");
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("____1.C#Fundamental : 120$____" + " ____2.programing in C# :210$____" + "____ 3.SQL Server :280$___");
                    Console.ResetColor();
                    string CoUrsename = Console.ReadLine();// select course
                    switch (CoUrsename)
                    {
                        case "1":
                            {
                                Console.WriteLine("**Your registration in ''C#Fundamental Course''  was successful**");
                                Console.BackgroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("your Payment invoice:120$");
                                Console.ResetColor();
                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine("** Your registration in ''programing in C# Course''  was successful**");
                                Console.BackgroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("your Payment invoice:210$");
                                Console.ResetColor();
                                break;
                            }
                        case "3":
                            {
                                Console.WriteLine("** Your registration in ''SQL Server :280$''  was successful**");
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.BackgroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("your Payment invoice:280$");
                                Console.ResetColor();
                                break;
                            }
                    }
                    Console.WriteLine("After payment, proceed to finalize the registration");
                    Divider();

                  

                }
            }

        }
    }

}











