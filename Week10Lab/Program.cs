using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating the two cash objects
            CashPayment cash1 = new CashPayment(312);
            CashPayment cash2 = new CashPayment(299);

            // creating the two cc objects 
            CreditCardPayment CC1 = new CreditCardPayment(100, "Eric sun", "1234567890");
            CreditCardPayment CC2 = new CreditCardPayment(389, "Moose howser", "97382367286");

            // displaying the methods
            cash1.PaymentDetails();
            cash2.PaymentDetails();

            CC1.PaymentDetails();
            CC2.PaymentDetails();

            Console.ReadLine();
        }
    }
}
