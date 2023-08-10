namespace CountryInfo.ClientApiLibrary.Requests
{
    public interface IGetAllApiServiceRequest<TResponse>
    {
        /// <summary>
        /// Получить список всех объектов типа <typeparamref name="T"/>
        /// </summary>
        /// <returns>Список всех объектов типа <typeparamref name="T"/></returns>
        Task<IEnumerable<TResponse>> GetAllAsync();
    }
}
