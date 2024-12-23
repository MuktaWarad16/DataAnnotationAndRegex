using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DataAnnotation_RegularExpression_PatternMatching
{
    internal class Program1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();

            Console.WriteLine("enter age");
            string age = Console.ReadLine();

            Console.WriteLine("enter zip");
            string zip = Console.ReadLine();

            bool ValidName = ValidateName(name);
            bool ValidateAge = IsValidateAge(age);
            bool ZipCodeValidate = IsZipCode(zip);

            if (ValidName && ValidateAge && ZipCodeValidate)
            {
                Console.WriteLine("user data is valid");

            }
            else
            {
                if (!ValidName)
                    Console.WriteLine("name should start with caps and min length is 2");

                if (!ValidateAge)
                    Console.WriteLine("age should be between 18 and 65");

                if (!ZipCodeValidate)
                    Console.WriteLine("enter valid zip code");
            }

        }


        public static bool ValidateName(string name)
        {
            string pattern = @"^[A-Z][a-z]{2,50}$";
            return Regex.IsMatch( name,pattern);

        }

        public static bool IsValidateAge(string age)
        {
            string pattern = @"^\d+$";
            if (Regex.IsMatch(age,pattern))
            {
                int ageV = int.Parse(age);
                return ageV >= 18 && ageV <= 65;
            }
            return false;
        }

        public static bool IsZipCode(string zip)
        { 
            
            string pattern = @"^\d{5}$";
            return Regex.IsMatch(zip, pattern);
        }
    }
}