namespace TemplateProject.Services
{
    public class TemplateProjectClient
    {
        public HttpClient _client;
        public TemplateProjectClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<WeatherForecast>> GetWeatherForecast()
        {
            //TODO: implement the logic of the client for getting the data here. It can be a DB call or a a call to an external API
            throw new NotImplementedException();
        }
    }
}
