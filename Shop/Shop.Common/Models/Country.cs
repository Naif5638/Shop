using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Common.Models
{
    public partial class Country
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cities")]
        public List<City> Cities { get; set; }

        [JsonProperty("numberCities")]
        public int NumberCities { get; set; }
    }
}
