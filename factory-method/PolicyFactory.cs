using factory_method.enums;

namespace factory_method
{
    public partial class PolicyFactory
    {
        public static IPolicy Create(PolicyType policyType) 
        {
            if (PolicyType.CarInsurance == policyType) return new CarInsurance();
            if (PolicyType.Funeral == policyType) return new Funeral();
            if (PolicyType.GeyserInsurance == policyType) return new GeyserInsurance();
            if (PolicyType.HouseInsurance == policyType) return new HouseInsurance();
            if (PolicyType.Retirement == policyType) return new Retirement();
            throw new NotSupportedException("Oooops, we don't have this kind of policy yet.");
        }
    }
}
