//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Reflection.Metadata;
//using System.Security.Cryptography.X509Certificates;

//namespace DataAnnotation_RegularExpression_PatternMatching
//{
//    internal class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine( "enter user details");

//            Console.WriteLine( "enter user name");
//            string name=Console.ReadLine();

//            Console.WriteLine( "enter user email");
//            string email=Console.ReadLine();

//            Console.WriteLine("enter age");
//            int age=int.Parse(Console.ReadLine());


//            var user = new User
//            {
//                Name = name,
//                Age = age,
//                Email = email
//            };

//            var context=new ValidationContext(user);
//            var results=new List <ValidationResult>();
//            bool isValid=Validator.TryValidateObject(user,context,results,true);

//            if (isValid)
//            {
//                Console.WriteLine("user data is valid");
//                Console.WriteLine($"Name:{user.Name} ,Age:{user.Age} ,Email:{user.Email}");
//            }
//            else {
//                Console.WriteLine("validation errors");
//                foreach (var error in results)
//                {
//                    Console.WriteLine( $"{ error.ErrorMessage}");

//                }
//                }




//        }
//    }
//}
