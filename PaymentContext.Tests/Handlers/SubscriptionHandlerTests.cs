using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Lucas";
            command.LastName = "Mendes";
            command.Document = "99999999999";
            command.Email = "hello@balta.io2";
            command.BarCode = "123456789";
            command.BoletoNumber = "123456789";
            command.PaymentNumber = "1234123";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(2);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "FRANGO";
            command.PayerDocument = "1234567891020";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "franog@balta.io3";
            command.Street = "asdfas";
            command.Number = "asdasdas";
            command.Neighborhood = "asdasd";
            command.City = "AS";
            command.State = "SA";
            command.Country = "AS";
            command.ZipCode = "3332222111";

            handler.Handle(command);

            Assert.AreEqual(false, handler.IsValid);
        }
    }
}
