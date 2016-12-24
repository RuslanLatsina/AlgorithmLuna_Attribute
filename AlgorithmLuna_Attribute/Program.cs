using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AlgorithmLuna_Attribute
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var creditCard = new CreditCard();
            creditCard.Code = Console.ReadLine();
            var results = new List<ValidationResult>();
            if(Validator.TryValidateObject(creditCard, new ValidationContext(creditCard), results, true))
                Console.WriteLine("Correct number");
            
            Console.WriteLine("Incorrect number");


            Console.ReadLine();
        }
    }
}
