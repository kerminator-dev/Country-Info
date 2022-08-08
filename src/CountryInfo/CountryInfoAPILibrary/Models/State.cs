using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CountryInfoAPILibrary.Models
{
    public class State
    {
        [Key]
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countryId")]
        public int CountryId { get; set; }

        [JsonProperty("cities")]
        public virtual ICollection<City> Cities { get; set; }
    }
}
