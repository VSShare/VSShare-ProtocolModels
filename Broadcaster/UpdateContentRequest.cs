using Newtonsoft.Json;
using ProtocolModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Broadcaster
{
    public class UpdateContentRequest : SessionRequestBase
    {
        [JsonProperty("data")]
        public List<UpdateContentData> Data { get; set; }

    }

    public class UpdateContentData
    {
        [JsonProperty("data")]
        public List<Line> Content { get; set; }

        [JsonProperty("type")]
        public UpdateType Type { get; set; } = UpdateType.Append;

        [JsonProperty("pos")]
        public uint Position { get; set; } = 0;

        [JsonProperty("len")]
        public uint Length { get; set; } = 1;

        [JsonProperty("order")]
        public int Order { get; set; } = 0;
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
