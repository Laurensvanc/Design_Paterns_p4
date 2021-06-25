using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class NoCardState : IATMState
    {
        private ATMMachine _machine;

        public NoCardState(ATMMachine machine)
        {
            _machine = machine;
        }

        void EnterPincode(int pincode) 
        {
            Console.WriteLine("entered unknown command");
        }
        void InjectCard() 
        {
            if (_machine.AmountInMachine <= 0)
            {
                Console.WriteLine("Not enough cash available in machine");
                RejectCard();
                return;
            }

            Console.WriteLine("Please enter your pincode: ");
            _machine.SetMachineState(_machine.GetCardPresentState());
        }
        void RejectCard() 
        {
            if (_machine.AmountInMachine <= 0)
            {
                Console.WriteLine("Your card has been rejected");
                _machine.SetMachineState(_machine.GetNoCashState());
                return;
            }

            Console.WriteLine("No card entered");
        }
        void WithdrawCash(double amount) 
        {
            Console.WriteLine("Please enter a card first");
        }
    }
}
