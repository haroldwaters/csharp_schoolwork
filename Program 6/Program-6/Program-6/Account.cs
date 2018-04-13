using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_6
{
    class Account : IAccountUpdate
    {
        //Non-interface props
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string CreditCardNumber { get; set; }

        //Interface Props
        public double BalanceOwed { get; set; }
        public double MinutesUsed { get; set; }
        public double CostPerMinute { get; set; }
        
        public double CalculateCharge()
        {
            return (this.MinutesUsed * this.CostPerMinute) + this.BalanceOwed;
        }

        public void AdjustMinutes(int minutes)
        {
            this.MinutesUsed += minutes;
        }


    }
}
