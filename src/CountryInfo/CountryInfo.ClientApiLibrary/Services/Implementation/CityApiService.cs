using CountryInfo.ClientApiLibrary.Services.Abstractions;

namespace CountryInfo.ClientApiLibrary.Services.Implementation
{
    internal class CityApiService : BaseApiService<City>, ISearchApiServiceRequest<CityResponseDTO, string>
    {
        private const string CONTROLLER_NAME = "Cities";

        public CityApiService(string baseServerAddress) : base(baseServerAddress, CONTROLLER_NAME)
        {

        }

        public async Task<IEnumerable<City>> SearchAsync(string value)
        {
            try
            {
                var address = new Uri($"{_baseServerAddress}api/{_controllerName}/Search={value}");

                return await MakeGETRequest<IEnumerable<City>>(address);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
