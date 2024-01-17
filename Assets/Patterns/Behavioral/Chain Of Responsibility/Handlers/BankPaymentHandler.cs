using UnityEngine;

namespace ChainOfResponsibility
{
    public class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if(receiver.IsBankTransfer == true)
            {
                Debug.Log("Completed Bank payment");
            }
            else if(Successor != null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}
