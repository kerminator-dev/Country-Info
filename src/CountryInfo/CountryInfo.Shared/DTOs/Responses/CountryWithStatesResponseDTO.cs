namespace CountryInfo.Shared.DTOs.Responses
{
    public class CountryWithStatesResponseDTO
    {
        public int Id { get; set; }

        public string ShortName { get; set; }

        public string Name { get; set; }

        public int PhoneCode { get; set; }

        public virtual IEnumerable<StateResponseDTO> States { get; set; }
    }
}
