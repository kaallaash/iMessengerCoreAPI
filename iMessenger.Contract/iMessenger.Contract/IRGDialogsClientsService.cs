namespace iMessenger.Contract;

public interface IRGDialogsClientsService
{
    Task<object> Get(
        string[] ids);
}