using Newtonsoft.Json;
using ProtocolModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Notifications
{
    public class UpdateContentNotification : NotificationBase
    {
        [JsonProperty("data")]
        public Line Content { get; set; }

        [JsonProperty("type")]
        public UpdateType Type { get; set; } = UpdateType.Insert;

        [JsonProperty("pos")]
        public int Position { get; set; } = 0;

        [JsonProperty("len")]
        public int Length { get; set; } = 1;

    }

    public enum UpdateType
    {
        Insert = 0,
        Delete = 1,
        Replace = 2
    }


}
