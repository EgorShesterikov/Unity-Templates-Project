using UnityEngine;

namespace ChainOfResponsibility
{
    public class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.IsPayPalTransfer == true)
            {
                Debug.Log("Completed PayPal payment");
            }
            else if (Successor != null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}
