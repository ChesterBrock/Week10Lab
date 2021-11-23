using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Lab
{
    class CashPayment : Payment
    {
        public CashPayment(double payAmount) : base(payAmount)
        {
            this.PayAmount = payAmount;
        }
        public void PaymentDetails()
        {
            Console.WriteLine("The payment amount is Cash : $" + this.PayAmount);
        }

    }
}
