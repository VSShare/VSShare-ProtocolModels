using Newtonsoft.Json;
using ProtocolModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Broadcaster
{
    public class UpdateCursorRequest : SessionRequestBase
    {

        [JsonProperty("anchor")]
        public CursorPosition Anchor { get; set; } = null;

        [JsonProperty("active")]
        public CursorPosition Active { get; set; }

        [JsonProperty("type")]
        public CursorType Type { get; set; }

    }

}
