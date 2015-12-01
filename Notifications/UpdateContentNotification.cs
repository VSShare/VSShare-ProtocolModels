using Newtonsoft.Json;
using ProtocolModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Notifications
{
    public class UpdateContentNotification : SessionNotificationBase
    {
        [JsonProperty("data")]
        public List<Line> Content { get; set; }

        [JsonProperty("type")]
        public UpdateType Type { get; set; } = UpdateType.Append;

        [JsonProperty("pos")]
        public uint Position { get; set; } = 0;

        [JsonProperty("len")]
        public uint Length { get; set; } = 1;

    }

    public enum UpdateType
    {
        Insert = 0,
        Delete = 1,
        Replace = 2,
        Append = 3,
        RemoveMarker = 4,
        ResetAll = 5
    }


}
