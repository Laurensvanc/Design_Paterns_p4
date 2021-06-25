using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    interface IATMState
    {
        void EnterPincode(int pincode) { }
        void InjectCard() { }
        void RejectCard() { }
        void WithdrawCash(double amount) { }

    }
}
