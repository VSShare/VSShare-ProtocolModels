using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Auth
{
    public class LoginListenerRequest
    {
        [JsonProperty("token")]
        public string Token { get; set; }

    }
}
