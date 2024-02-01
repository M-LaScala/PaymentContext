using PaymentContext.Shared.Commands;

namespace PaymentContext.Shared.Handlers
{
    // <T> indica que a interface é do tipo generico
    //  T deve ser um tipo que implementa a interface ICommand ( Where T : ICommand )
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
