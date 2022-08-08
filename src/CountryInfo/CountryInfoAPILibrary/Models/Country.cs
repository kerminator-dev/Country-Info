using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CountryInfoAPILibrary.Models
{
    public class Country
    {
        [Key]
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phoneCode")]
        public int PhoneCode { get; set; }

        [JsonProperty("states")]
        public virtual ICollection<State> States { get; set; }
    }
}
