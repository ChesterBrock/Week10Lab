using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Lab
{
    class CreditCardPayment : Payment
    {
        private String cardHolder;
        private String cardNumber;

        public CreditCardPayment(double payAmount, String cardHolder, String cardNumber) : base(payAmount)
        {
            this.PayAmount = payAmount;
            this.cardHolder = cardHolder;
            this.cardNumber = cardNumber;
        }
        public void PaymentDetails()
        {
            Console.WriteLine("\nThe payment amount is Credit : $" + this.PayAmount + "\n Name :" + this.cardHolder + "\nCard number **" + this.cardNumber);
        }
    }
}
