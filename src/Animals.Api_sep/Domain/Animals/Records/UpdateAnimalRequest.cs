namespace Animals.Api_sep.Domain.Animals.Records;

public record UpdateAnimalRequest(
    string Name,
    int Age,
    string Description);