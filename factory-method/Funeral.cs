using factory_method.constants;

namespace factory_method
{
    public class Funeral : IPolicy
    {
        public string InstallmentAmount()
        {
            return $"Installment of R60.";
        }

        public string PaymentFrequency()
        {
            return $"Should make, {PaymentFrequencyType.Monthly}.";
        }

        public string PaymentMethod()
        {
            return $"The payment is made via {PaymentMethodType.Debit}.";
        }

        public string Status()
        {
            return $"Current status is {StatusType.Canceled}.";
        }
    }
}
