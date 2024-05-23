using factory_method.constants;

namespace factory_method
{
    public interface IPolicy
    {
        string PaymentMethod();
        string PaymentFrequency();
        string Status();
        string InstallmentAmount();
    }
}