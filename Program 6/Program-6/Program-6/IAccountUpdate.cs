using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_6
{
    interface IAccountUpdate
    {
        double BalanceOwed { get; set; }
        double MinutesUsed { get; set; }
        double CostPerMinute { get; set; }

        double CalculateCharge();
        void AdjustMinutes(int minutes);
    }
}
