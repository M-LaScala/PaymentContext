using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Test1()
        {
            var subscription = new Subscription(null);
            var student = new Student("Matheus","La Scala", "123123","matheus@gmail.com");
            student.AddSubscription(subscription);
        }
    }
}