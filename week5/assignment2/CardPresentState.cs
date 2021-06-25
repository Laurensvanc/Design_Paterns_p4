using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class CardPresentState : IATMState
    {
        private ATMMachine _machine;

        public CardPresentState(ATMMachine machine)
        {
            this._machine = machine;
        }

        void EnterPincode(int pincode) 
        {
            Console.WriteLine("You have entered the correct pincode");
            _machine.SetMachineState(_machine.GetCorrectPinState());
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
            Console.WriteLine("");
            _machine.SetMachineState(_machine.GetCorrectPinState());
        }
    }
}
