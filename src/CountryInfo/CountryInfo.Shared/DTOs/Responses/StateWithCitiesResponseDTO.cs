namespace CountryInfo.Shared.DTOs.Responses
{
    public class StateWithCitiesResponseDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<CityResponseDTO> Cities { get; set; }
    }
}
