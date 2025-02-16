
namespace Animals.Api_sep.Domain.Animals.Records;

public record CreateAnimalRequest(
    string Name,
    int Age,
    string Description);