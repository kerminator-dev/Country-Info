namespace CountryInfo.WebAPI.Extensions
{
    public static class IEnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection) 
        {
            if (collection == null)
                return true;

            return !collection.Any();
        }
    }
}
