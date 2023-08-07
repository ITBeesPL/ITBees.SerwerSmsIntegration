namespace ITBees.SerwerSmsIntegration.Infrastructure
{
    public class SmsResponse
    {
        public bool Success { get; set; }
        public int Queued { get; set; }
        public int Unsent { get; set; }
    }
}
