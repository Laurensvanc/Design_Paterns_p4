using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class ATMMachine
    {
        double amountInMachine;
        IATMState cardPresent;
        IATMState correctPinCode;
        IATMState noCard;
        IATMState noCash;

        public double AmountInMachine { get; set; }

        private IATMState machineState;

        ATMMachine() 
        {
            this.amountInMachine = AmountInMachine;

            cardPresent = new CardPresentState(this);
            correctPinCode = new CorrectPinState(this);
            noCard = new NoCardState(this);
            noCash = new NoCashState(this);
            
        }
        public void EnterPincode(int code) 
        {
            machineState.EnterPincode(code);
        }
        public IATMState GetCardPresentState() 
        {
            Console.WriteLine();
            return cardPresent;
        }
        public IATMState GetCorrectPinState() 
        {
            Console.WriteLine();
            return correctPinCode;
        }
        public IATMState GetNoCardState() 
        {
            Console.WriteLine();
            return noCard;
        }
        public IATMState GetNoCashState() 
        {
            Console.WriteLine();
            return noCash;
        }
        public void InsertCard() 
        {
            machineState.InjectCard();
        }
        public void RejectCard() 
        {
            machineState.RejectCard();
        }
        public void SetAmountInMachine(int amount) 
        {
            AmountInMachine = amount;
        }
        public void SetMachineState(IATMState newState) 
        {
            machineState = newState;
        }
        public void WithdrawCash(double amount) 
        {
            machineState.WithdrawCash(amount);
        }
    }
}
