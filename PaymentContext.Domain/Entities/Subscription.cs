namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
