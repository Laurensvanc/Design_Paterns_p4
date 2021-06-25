using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class NoCashState : IATMState
    {
        private ATMMachine _machine;

        public NoCashState(ATMMachine machine)
        {
            _machine = machine;
        }

        void EnterPincode(int pincode) 
        {
            Console.WriteLine("No cash in this machine");
            RejectCard();
        }

        void InjectCard() 
        {
            Console.WriteLine("No cash in this machine");
            RejectCard();
        }

        void RejectCard() 
        {
            Console.WriteLine("Your card has been rejected");
            _machine.SetMachineState(_machine.GetNoCardState());
        }

        void WithdrawCash(double amount) 
        {
            Console.WriteLine("No cash in this machine");
        }
    }
}
