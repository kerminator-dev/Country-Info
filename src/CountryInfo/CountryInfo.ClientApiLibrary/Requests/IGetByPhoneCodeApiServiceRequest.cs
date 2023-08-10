namespace CountryInfo.ClientApiLibrary.Requests
{
    public interface IGetByPhoneCodeApiServiceRequest<TResult>
    {
        Task<TResult> GetByPhoneCodeAsync(int phoneCode);
    }
}
