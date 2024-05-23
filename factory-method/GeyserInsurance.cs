using factory_method.constants;

namespace factory_method
{
    public class GeyserInsurance : IPolicy
    {
        public string InstallmentAmount()
        {
            return $"Installment of R2300, for geyser insurance.";
        }

        public string PaymentFrequency()
        {
            return $"You are paying {PaymentFrequencyType.Annual}, for geyser insurance.";
        }

        public string PaymentMethod()
        {
            return $"The payment is made via {PaymentMethodType.EFT}, for geyser insurance.";
        }

        public string Status()
        {
            return $"Current status is {StatusType.Active}, for geyser insurance.";
        }
    }
}
