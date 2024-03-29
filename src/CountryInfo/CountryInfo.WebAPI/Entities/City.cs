﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryInfo.WebAPI.Entities
{
    /// <summary>
    /// Город
    /// </summary>
    public sealed class City
    {
        [Key]
        [Column("id", Order = 0)]
        public int Id { get; set; }

        [Column("name", Order = 1)]
        public string Name { get; set; }

        [Column("state_id", Order = 2)]
        public int StateId { get; set; }
    }
}
