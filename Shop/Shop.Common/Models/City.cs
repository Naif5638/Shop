using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Common.Models
{
    public partial class City
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
