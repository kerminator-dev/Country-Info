using CountryInfo.WebAPI.Entities;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Queries.States
{
    public class GetStateByIdQuery : IRequest<State>
    {
        public int StateId { get; set; }

        public GetStateByIdQuery(int stateId)
        {
            StateId = stateId;
        }
    }
}
