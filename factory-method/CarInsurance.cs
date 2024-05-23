using factory_method.constants;

namespace factory_method
{
    public class CarInsurance : IPolicy
    {
        public string InstallmentAmount()
        {
            return $"Installment of R1400.";
        }

        public string PaymentFrequency()
        {
            return $"Should make, {PaymentFrequencyType.Monthly}.";
        }

        public string PaymentMethod()
        {
            return $"The payment is made via {PaymentMethodType.Deposit}.";
        }

        public string Status()
        {
            return $"Current status is {StatusType.Active}.";
        }
    }
}
