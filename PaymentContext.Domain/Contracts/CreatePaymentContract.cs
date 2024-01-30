using PaymentContext.Domain.Entities;
using Flunt.Validations;

namespace PaymentContext.Domain.Contracts
{
    public class CreatePaymentContract : Contract<Payment>
    {
        public CreatePaymentContract(Payment payment)
        {
            Requires()
                .IsLowerOrEqualsThan(0, payment.Total, "Payment.Total", "O total não pode ser zero")
                .IsGreaterOrEqualsThan(payment.Total, payment.TotalPaid, "Payment.TotalPaid", "O valor pago é menor que o valor do pagamento");
        }
    }
}
