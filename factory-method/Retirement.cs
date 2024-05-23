using factory_method.constants;

namespace factory_method
{
    public class Retirement : IPolicy
    {
        public string InstallmentAmount()
        {
            return $"Installment of R4800, into your retirement fund.";
        }

        public string PaymentFrequency()
        {
            return $"Should make, {PaymentFrequencyType.Quarterly}, for your retirement.";
        }

        public string PaymentMethod()
        {
            return $"The payment is made via {PaymentMethodType.Debit}, for your retirement fund.";
        }

        public string Status()
        {
            return $"Current status is {StatusType.Active}, of your retirement fund.";
        }
    }
}
