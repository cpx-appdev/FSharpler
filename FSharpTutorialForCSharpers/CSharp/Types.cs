using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Types
    {
        // --------------------------
        // Primitive Typen
        // --------------------------
        int number = 1;

        double floating = 1.0;

        bool flag = true;

        string text ="Text";

        // --------------------------
        // Tupel
        // --------------------------

        Tuple<int, int> coord = Tuple.Create(123, 456);
        Tuple<double, string> price = Tuple.Create(9.99, "€");

       
        // --------------------------
        // Discriminated Unions
        // --------------------------

        enum Gender
        {
            Female,
            Male
        }

        void Test4()
        {
            var male = Gender.Male;
        }

        interface IPaymentMethod { }

        sealed class Cash : IPaymentMethod
        {
        }

        sealed class CreditCard : IPaymentMethod
        {
            public int CardNr { get; set; }
            public DateTime ValidUntil { get; set; }

            public CreditCard(int cardNr, DateTime validUntil)
            {
                CardNr = cardNr;
                ValidUntil = validUntil;
            }
        }

        sealed class Giro : IPaymentMethod
        {
            public string Iban { get; set; }
            public string Bic { get; set; }

            public Giro(string iban, string bic)
            {
                Iban = iban;
                Bic = bic;
            }
        }

        sealed class UnsupportedPayment : IPaymentMethod { }

        // --------------------------
        // Records
        // --------------------------

        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            // public DateTime DateOfBirth { get; set; }
        }

        void Test5()
        {
            var homer = new Person
            {
                FirstName = "Homer",
                LastName = "Simpson"
            };
        }
    }
}
