﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolModels.Auth
{
    public class AuthorizeListenerResponse
    {
        [JsonProperty("success")]
        public bool IsSuccess { get; set; }
    }
}
