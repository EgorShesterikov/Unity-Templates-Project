using UnityEngine;

namespace ChainOfResponsibility
{
    public class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.IsMoneyTransfer == true)
            {
                Debug.Log("Completed Money payment");
            }
            else if (Successor != null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}
