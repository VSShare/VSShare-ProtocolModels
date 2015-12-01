using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Notifications
{
    public abstract class SessionNotificationBase
    {
        [JsonProperty("id")]
        public string SessionId { get; set; }
    }

}
