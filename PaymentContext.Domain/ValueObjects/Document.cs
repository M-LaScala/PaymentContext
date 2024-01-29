using PaymentContext.Shared.ValueObjects;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Contracts;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
            AddNotifications(new CreateDocumentContract(this));
        }
        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }
    }
}
