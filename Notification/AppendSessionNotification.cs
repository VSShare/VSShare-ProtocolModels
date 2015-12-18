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

        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("type")]
        public string ContentType { get; set; }

        [JsonProperty("owner_name")]
        public string BroadcasterName { get; set; }
    }
}
