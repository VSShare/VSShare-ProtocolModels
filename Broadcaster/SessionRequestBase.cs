using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Broadcaster
{
    public abstract class SessionRequestBase
    {
        [JsonProperty("id")]
        public string SessionId { get; set; }
    }

}
