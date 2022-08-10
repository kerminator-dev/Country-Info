using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryInfoAPI.Entities
{
    /// <summary>
    /// Страна
    /// </summary>
    public class Country
    {
        [Key]
        [Column("id", Order = 0)]

        public int Id { get; set; }
        [Column("shortname", Order = 1)]

        public string ShortName { get; set; }

        [Column("name", Order = 2)]
        public string Name { get; set; }

        [Column("phonecode", Order = 3)]
        public int PhoneCode { get; set; }

        public virtual ICollection<State> States { get; set; }
    }
}
