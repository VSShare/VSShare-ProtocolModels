using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Requests
{
    public abstract class SessionRequestBase
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
