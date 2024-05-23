using factory_method.constants;

namespace factory_method
{
    public class HouseInsurance : IPolicy
    {
        public string InstallmentAmount()
        {
            return $"Installment of R0, for home insurance.";
        }

        public string PaymentFrequency()
        {
            return $"Should make, {PaymentFrequencyType.SemiAnnual}, for home insurance.";
        }

        public string PaymentMethod()
        {
            return $"The payment is made via {PaymentMethodType.Debit}, for home insurance.";
        }

        public string Status()
        {
            return $"Current status is {StatusType.Canceled}, for home insurance.";
        }
    }
}
