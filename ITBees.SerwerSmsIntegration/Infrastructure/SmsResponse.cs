using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwServices.SmsSender
{
    public class SmsResponse
    {
        public bool Success { get; set; }
        public int Queued { get; set; }
        public int Unsent { get; set; }
    }
}
