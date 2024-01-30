using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Contracts
{
    public class CreateAddressContract : Contract<Address>
    {                                    
        public CreateAddressContract(Address address)
        {
            Requires()
                .IsGreaterThan(address.Street, 3, "Address.Street", "A rua deve ter pelo menos 3 caracteres")
                .IsLowerThan(address.City, 40, "Address.City", "A cidade deve ter até 40 caracteres");
        }
    }
}
