using factory_method;
using factory_method.enums;

var policy = PolicyFactory.Create(PolicyType.Retirement);
var installmentAmount = policy.InstallmentAmount();
var frequency = policy.PaymentFrequency();
var paymentMethod = policy.PaymentMethod();
var status = policy.Status();
Console.WriteLine($"{installmentAmount}");
Console.WriteLine($"{frequency}");
Console.WriteLine($"{paymentMethod}");
Console.WriteLine($"{status}");
