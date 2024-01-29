using PaymentContext.Shared.ValueObjects;
using PaymentContext.Domain.Contracts;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;
            AddNotifications(new CreateEmailContract(this));
        }

        public string Address { get; private set; }
    }
}