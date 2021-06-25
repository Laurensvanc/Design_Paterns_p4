using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class CorrectPinState : IATMState
    {
        private ATMMachine _machine;

        public CorrectPinState(ATMMachine machine)
        {
            this._machine = machine;
        }

        void EnterPincode(int pincode) 
        {
            Console.WriteLine("Your pincode is already entered");
        }
        void InjectCard() 
        {
            Console.WriteLine("A card has been inserted already");
        }
        void RejectCard() 
        {
            Console.WriteLine("Your card has been rejected");
            _machine.SetMachineState(_machine.GetNoCardState());
        }
        void WithdrawCash(double amount) 
        {
            Console.WriteLine($"{amount} withdrawn from machine");
            _machine.AmountInMachine -= amount;
            RejectCard();
        }
    }
}
