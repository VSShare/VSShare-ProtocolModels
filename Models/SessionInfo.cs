using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Models
{
    public class SessionInfo
    {
        public string Id { get; set; }

        public string FileName { get; set; }

        public string Nickname { get; set; }

        public ContentType Type { get; set; }

    }

}
