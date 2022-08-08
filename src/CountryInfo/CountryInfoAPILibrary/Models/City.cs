using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CountryInfoAPILibrary.Models
{
    public class City
    {
        [Key]
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stateId")]
        public int StateId { get; set; }
    }
}
