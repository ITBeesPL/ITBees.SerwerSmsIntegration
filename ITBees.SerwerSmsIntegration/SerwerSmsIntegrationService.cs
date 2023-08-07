using DwServices.SmsSender.Infrastructure;
using ITBees.Interfaces.Platforms;
using Microsoft.Extensions.Logging;

namespace ITBees.SerwerSmsIntegration
{
    public class SerwerSmsIntegrationService : ISerwerSmsIntegrationService
    {
        private readonly IPlatformSettingsService _platformSettings;
        private readonly ILogger<SerwerSmsIntegrationService> _logger;

        public SerwerSmsIntegrationService(IPlatformSettingsService platformSettings, ILogger<SerwerSmsIntegrationService> logger)
        {
            _platformSettings = platformSettings;
            _logger = logger;
        }

        /// <summary>
        /// Allowes send sms
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="message"></param>
        /// <param name="senderName">Leave this filed empty to send eco message</param>
        public void Send(string phone, string message, string senderName)
        {
            try
            {
                var serwerSms = new SerwerSmsPL(_platformSettings.GetSetting("SmsServerLogin"), _platformSettings.GetSetting("SmsServerPassword"), _platformSettings.GetSetting("SmsServerURL"));
                var data = new Dictionary<string, string>();

                String sender = senderName;

                var item = new Dictionary<string, string>();
                item.Add("phone", phone);
                item.Add("text", message);

                List<Dictionary<string, string>> messages = new List<Dictionary<string, string>>();
                messages.Add(item);

                serwerSms.messages.sendPersonalized(messages, sender, data).ToString();
                _logger.LogInformation($"SMS has been sent.");
            }
            catch (Exception e)
            {
                throw e;
            };
        }
    }
}
