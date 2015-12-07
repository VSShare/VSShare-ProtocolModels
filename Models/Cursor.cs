using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Models
{
    public enum CursorType
    {
        Point = 0,
        Select = 1
    }

    public class CursorPosition
    {
        [JsonProperty("line")]
        private long LineNumber { get; set; } = 0;

        [JsonProperty("pos")]
        long PositionNumber { get; set; } = 0;
    }

}
