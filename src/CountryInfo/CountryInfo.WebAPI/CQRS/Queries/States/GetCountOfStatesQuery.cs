using MediatR;

namespace CountryInfo.WebAPI.CQRS.Queries.States
{
    public class GetCountOfStatesQuery : IRequest<int>
    {
    }
}
