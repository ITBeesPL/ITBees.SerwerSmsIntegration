namespace ITBees.SerwerSmsIntegration
{
    public interface ISerwerSmsIntegrationService
    {
        void Send(string phone, string message, string senderName);
    }
}