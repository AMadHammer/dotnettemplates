using MediatR;
using TemplateProject.Queries;
using TemplateProject.Services;

namespace TemplateProject.Handlers
{
    public class GetTemplateProjectHandler : IRequestHandler<GetTemplateProjectQuery, List<WeatherForecast>>
    {
        public  readonly TemplateProjectClient _templateProjectClient;
        public GetTemplateProjectHandler(TemplateProjectClient templateProjectClient)
        {
            _templateProjectClient = templateProjectClient;
        }

        public Task<List<WeatherForecast>> Handle(GetTemplateProjectQuery request, CancellationToken cancellationToken)
        {
            //TODO: Implement the logic of the handler here

            return _templateProjectClient.GetWeatherForecast();
        }
    }
}
