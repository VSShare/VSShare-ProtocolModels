using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Auth
{
    public class AuthorizeListenerRequest
    {
        [JsonProperty("token")]
        public string Token { get; set; }

    }
}
