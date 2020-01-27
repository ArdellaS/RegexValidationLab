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

                Console.Write("Please enter your first name: ");
                string name = Console.ReadLine();
                Console.WriteLine($"{Name(name)}");

                Console.Write("\nPlease enter your email: ");
                string email = Console.ReadLine();
                Console.WriteLine($"{Email(email)}");

                Console.Write("\nPlease enter your phone number(123-457-7890): ");
                string phoneNumber = Console.ReadLine();
                Console.WriteLine($"{Phone(phoneNumber)}");

                Console.Write("\nPlease enter the date(DD/MM/YYYY): ");
                string date = Console.ReadLine();
                Console.WriteLine($"{Date(date)}");


                Console.WriteLine("\nWould you like to try again? yes/no");
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



            static string Phone(string phoneNumber)
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

            static string Date(string date)
            {
                string datePattern = @"^((0?[1-9])|([1]*[0-2]))\/[\d]{2}\/[\d9]{4}$";
                string dateValidation;

                if (Regex.IsMatch(date, datePattern))
                {
                    dateValidation = "Date is valid.";
                }
                else
                {
                    dateValidation = "Date is not valid.";
                }
                return dateValidation;

            }
        }
    }
}
