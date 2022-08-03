using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountriesWebAPI.Models
{
    /// <summary>
    /// Штат/регион страны
    /// </summary>
    public class State
    {
        [Key]
        [Column("id", Order = 0)]
        public int Id { get; set; }

        [Column("name", Order =1)]
        public string Name { get; set; }

        [Column("country_id", Order = 2)]
        public int CountryId { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
