using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Contracts
{
    public class CreateNameContract : Contract<Name>
    {
        public CreateNameContract(Name name)
        {
            Requires()
                .IsLowerThan(name.FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                .IsGreaterThan(name.FirstName, 40, "Name.FirstName", "Nome deve conter até 40 caracteres")
                .IsLowerThan(name.LastName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres");
        }
    }
}
