using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Broadcaster
{
    public class AppendSessionResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("success")]
        public bool IsSuccess { get; set; }
    }
}
