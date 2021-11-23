using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Lab
{
    class Payment
    {
        private double mPayAmount;

        public Payment(double payAmount)
        {
            mPayAmount = payAmount;
        }

        public double PayAmount { get => mPayAmount; set => mPayAmount = value; }

        public String PaymentDetails()
        {
            return "The payment amount is " + this.PayAmount;
        }
    }
}
