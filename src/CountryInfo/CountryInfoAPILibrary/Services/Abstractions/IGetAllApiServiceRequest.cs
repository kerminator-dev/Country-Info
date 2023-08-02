namespace CountryInfoAPILibrary.Services.Abstractions
{
    internal interface IGetAllApiServiceRequest<TResponse>
    {
        Task<TResponse> GetAllAsync();
    }
}
