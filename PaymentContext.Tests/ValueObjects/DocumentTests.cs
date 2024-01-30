using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        // Red, Green, Refactor
        // Fazer testes com erro
        // Fazer testes sucesso
        // Refatorar o codigo
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CNPJ);
            Assert.IsTrue(!doc.IsValid);
        }

        [TestMethod]
        public void ShouldReturnSucessWhenCNPJIsValid()
        {
            var doc = new Document("34110468000150", EDocumentType.CNPJ);
            Assert.IsTrue(doc.IsValid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CPF);
            Assert.IsTrue(!doc.IsValid);
        }

        // Tambem pode se fazer dessa forma para testar em massa.
        [TestMethod]
        [DataTestMethod]
        [DataRow("34225545806")]
        //[DataRow("33529396087")]
        public void ShouldReturnSucessWhenCPFJIsValid(string cpf)
        {
            var doc = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(doc.IsValid);
        }
    }
}
