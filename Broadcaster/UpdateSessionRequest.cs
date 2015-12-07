using Newtonsoft.Json;
using ProtocolModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Broadcaster
{
    
    public class UpdateSessionInfoRequest : SessionRequestBase
    {
        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("type")]
        public ContentType ContentType { get; set; } = ContentType.PlainText;

    }
}
