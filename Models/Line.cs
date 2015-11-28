using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Models
{
    public class Line
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("ismod")]
        public bool IsModified { get; set; }

    }




}
