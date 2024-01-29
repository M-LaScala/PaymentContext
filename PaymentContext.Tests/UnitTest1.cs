using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var name = new Name("Teste", "Teste");
            foreach (var item in name.Notifications) 
            {
                Console.WriteLine($"Notfi: {item.Message}");
            }
        }
    }
}