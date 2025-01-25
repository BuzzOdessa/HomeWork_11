using Animals.Application.Domain.Animals.Queries.GetAnimalsByName;
using Animals.Persistence.Core.Animals.DataProvider;
using MediatR;

namespace Animals.Infrastructure.Application.Domain.Animals.Queries.GetAnimalsByName
{
    internal class GetAnimalsByNameQueryHandler(IAnimalsDataProvider animalsDataProvider)
        : IRequestHandler<GetAnimalsByNameQuery, List<AnimalByNameDto>>
    {
        public async Task<List<AnimalByNameDto>> Handle(
            GetAnimalsByNameQuery query,
            CancellationToken cancellationToken)
        {
            
            var animals = await animalsDataProvider.GetAll();

            var result = animals?
                    .Where(animal => animal.Name.Contains(query.name))
                    .Select(a => new AnimalByNameDto(a.Id, a.Name, a.Age, a.Description))
                    .OrderBy(a => a.Name)
                    .ToList();
            return result;
        }
    }
}
