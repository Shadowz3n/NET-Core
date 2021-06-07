
namespace app.Domain.Handlers.Contracts
{
    public interface IHandler<T>
    {
        void Handle();
    }
}