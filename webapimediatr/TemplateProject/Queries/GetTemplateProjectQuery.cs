using MediatR;

namespace TemplateProject.Queries
{
    public record GetTemplateProjectQuery(int Id) : IRequest<List<WeatherForecast>>;
}
