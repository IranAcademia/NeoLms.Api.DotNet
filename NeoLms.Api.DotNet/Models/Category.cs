using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoLms.Api.DotNet.Models
{
    public class Category
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
