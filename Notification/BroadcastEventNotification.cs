using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Notification
{
    public class BroadcastEventNotification
    {
        [JsonProperty("event")]
        public BroadcastEventType EventType { get; set; }

    }

    public enum BroadcastEventType
    {
        StartBroadcast = 0,
        StopBroadcast = 1,

    }

}
