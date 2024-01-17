namespace ChainOfResponsibility
{
    public class Receiver
    {
        private bool _isBankTransfer;
        private bool _isMoneyTransfer;
        private bool _isPayPalTransfer;

        public Receiver(bool isBankTransfer, bool isMoneyTransfer, bool isPayPalTransfer)
        {
            _isBankTransfer = isBankTransfer;
            _isMoneyTransfer = isMoneyTransfer;
            _isPayPalTransfer = isPayPalTransfer;
        }

        public bool IsBankTransfer => _isBankTransfer;
        public bool IsMoneyTransfer => _isMoneyTransfer;
        public bool IsPayPalTransfer => _isPayPalTransfer;
    }

}
