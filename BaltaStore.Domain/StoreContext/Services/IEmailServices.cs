namespace BaltaStore.Domain.StoreContext.Services
{
    public interface IEmailServices
    {
        void Send(string to, string from, string suject, string body);
    }
}