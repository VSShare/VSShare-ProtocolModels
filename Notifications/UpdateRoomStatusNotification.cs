using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Notifications
{
    public class UpdateRoomStatusNotification : NotificationBase
    {
        [JsonProperty("view")]
        public long ViewerCount { get; set; }

        [JsonProperty("visitor")]
        public long TotalVisitorCount { get; set; }

    }
}
