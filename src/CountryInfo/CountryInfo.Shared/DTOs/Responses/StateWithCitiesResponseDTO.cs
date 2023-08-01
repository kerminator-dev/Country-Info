namespace CountryInfo.Shared.DTOs.Responses
{
    public class StateWithCitiesResponseDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }

        public virtual ICollection<CityResponseDTO> Cities { get; set; }
    }
}
