namespace CsvBlazor.Client.Core
{
    /// <summary>
    /// To show message to the users (as message at the right of the screen)
    /// </summary>
    public interface IUiMessage
    {
        Task Error(string message);
        Task Info(string message);
        Task Success(string message);
        Task Warning(string message);
    }
}
