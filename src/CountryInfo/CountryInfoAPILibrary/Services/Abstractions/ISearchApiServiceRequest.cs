using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryInfoAPILibrary.Services.Abstractions
{
    internal interface ISearchApiServiceRequest<TResponse, TValue>
    {
        Task<TResponse> SearchAsync(TValue value);
    }
}
