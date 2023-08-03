using CountryInfo.Shared.DTOs.Responses;
using CountryInfo.WebAPI.CQRS.Queries.States;
using CountryInfo.WebAPI.Entities;
using CountryInfo.WebAPI.Services.Abstractions;
using MediatR;

namespace CountryInfo.WebAPI.CQRS.Handlers.States
{
    public class GetStateByIdHandler : IRequestHandler<GetStateByIdQuery, StateWithCitiesResponseDTO>
    {
        private readonly IStateService _stateService;

        public GetStateByIdHandler(IStateService stateService)
        {
            _stateService = stateService;
        }

        public async Task<StateWithCitiesResponseDTO> Handle(GetStateByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _stateService.GetAsync(request.StateId);

            return new StateWithCitiesResponseDTO()
            {
                Id = result.Id,
                Name = result.Name,
                Cities = result.Cities.Select(city => new CityResponseDTO()
                {
                    Id = city.Id,
                    Name = city.Name
                }),
            };
        }
    }
}
