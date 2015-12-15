using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Auth
{
    public class AuthorizeBroadcasterRequest
    {
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("room_name")]
        public string RoomName { get; set; }

        [JsonProperty("room_token")]
        public string RoomToken { get; set; }

    }
}
