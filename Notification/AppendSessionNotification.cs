using Newtonsoft.Json;
using ProtocolModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Notification
{
    public class AppendSessionNotification
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string FileName { get; set; }

        [JsonProperty("type")]
        public ContentType ContentType { get; set; }

        [JsonProperty("owner")]
        public string BroadcasterName { get; set; }
    }
}
