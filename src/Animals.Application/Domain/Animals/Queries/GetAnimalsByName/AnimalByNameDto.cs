using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Application.Domain.Animals.Queries.GetAnimalsByName
{
    public record AnimalByNameDto(    Guid Id,    string Name,    int Age, string Description);
}
