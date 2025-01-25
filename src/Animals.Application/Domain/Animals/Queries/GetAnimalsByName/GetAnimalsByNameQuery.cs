using Animals.Application.Common;
using MediatR;

namespace Animals.Application.Domain.Animals.Queries.GetAnimalsByName;

public record GetAnimalsByNameQuery(
    string name
): IRequest<List<AnimalByNameDto>>;