using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Contracts
{
    public class CreateDocumentContract : Contract<Document>
    {
        public CreateDocumentContract(Document document)
        {
            Requires()
                .IsTrue(Validade(document), "Document.Number", "Documento inválido");
        }

        private bool Validade(Document document)
        {
            if (document.Type == EDocumentType.CNPJ && document.Number.Length == 14)
            {
                return true;
            }
            else if (document.Type == EDocumentType.CPF && document.Number.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
