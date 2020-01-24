using System;
using System.Text.RegularExpressions;

namespace RegexValidationLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            do
            {

                Console.Write("Please enter your first and last name: ");
                string name = Console.ReadLine();

                Console.Write("\nPlease enter your email: ");
                string email = Console.ReadLine();

                Console.Write("Please enter your phone number: ");
                double phoneNumber = double.Parse(Console.ReadLine());

                Console.WriteLine($"{Name(name)}");
                Console.WriteLine($"{Email(email)}");
                Console.WriteLine($"{Phone(phoneNumber)}");
                Console.WriteLine("\nWould you like to add another user? yes/no");
                answer = Console.ReadLine();
            } while (answer.Equals("yes") || answer.Equals("y"));

            static string Name(string name)
            {
                string namePattern = @"^[A-Z][A-z]{0,29}$";
                string nameRight;

                if (Regex.IsMatch(name, namePattern))
                {
                    nameRight = "Name is valid.";
                }
                else
                {
                    nameRight = "Name is invalid.";
                }

                return nameRight;
            }

            static string Email(string email)
            {
                string emailPattern = @"^[A-Z]+[\w]{4,30}@[\w]{5,10}\.[\w]{2,3}$";
                string emailValidation;


                int letterCount = email.Length;

                if (letterCount <= 30 || letterCount >= 5)
                {
                    if (Regex.IsMatch(email, emailPattern))
                    {
                        emailValidation = "Email is valid.";
                    }
                    else
                    {
                        emailValidation = "Email not valid.";
                    }

                }
                else
                {
                    emailValidation = "Email must be betwen 5 and 30 characters.";
                }

                return emailValidation;

            }
            //A phone number should be in the following format: {area code of 3 digits} – {3digits} – {4 digits} such as 313-555-1212



            static string Phone(double phoneNumber)
            {
                string phonePattern = @"^[0-9\S+\s]{10,14}$";
                string phoneValidation;
                string num = phoneNumber.ToString();

                int numberCount = phoneNumber.ToString().Length;

                if (numberCount <= 14 || numberCount >= 10)
                {
                    if (Regex.IsMatch(num, phonePattern))
                    {
                        phoneValidation = "Phone number is valid.";
                    }
                    else
                    {
                        phoneValidation = "Phone number not valid.";
                    }

                }
                else
                {
                    phoneValidation = "Email must be betwen 5 and 30 characters.";
                }

                return phoneValidation;
            }
        }
    }
}
