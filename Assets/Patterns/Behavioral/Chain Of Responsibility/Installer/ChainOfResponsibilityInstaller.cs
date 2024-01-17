using Zenject;

namespace ChainOfResponsibility
{
    public class ChainOfResponsibilityInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Receiver receiver = new Receiver(false, true, true);

            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler payPalPaymentHandler = new PayPalPaymentHandler();
            PaymentHandler moneyPaymentHandler = new MoneyPaymentHandler();

            bankPaymentHandler.Successor = payPalPaymentHandler;
            payPalPaymentHandler.Successor = moneyPaymentHandler;

            bankPaymentHandler.Handle(receiver);
        }
    }

}
