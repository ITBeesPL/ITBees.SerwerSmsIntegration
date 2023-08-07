using System;
using System.Collections.Generic;
using System.IO;

namespace DwServices.SmsSender.Infrastructure
{
    public interface ISerwerSmsIntegrationService
    {
        void Send(string phone, string message, string senderName);
    }
}