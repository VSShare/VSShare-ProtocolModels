using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Notifications
{
    public class UpdateBroadcastStatusNotification
    {
        [JsonProperty("view")]
        public long ViewCount { get; set; }

        [JsonProperty("visitor")]
        public long VisitorCount { get; set; }

    }
}
