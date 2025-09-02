using NetCoreAiProject3_RapidApi.ViewModel;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;

var client = new HttpClient();
List<ApiSeriesViewModel> apiSeriesViewModels = new List<ApiSeriesViewModel>();

var request = new HttpRequestMessage
{
    Method = HttpMethod.Get, 
    RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/series/"), //istek yapılacak adres
    Headers =
    {
        { "x-rapidapi-key", "d5de75ce18msh5f8812e520152b4p1599a4jsnbe977e6e2e4c" }, //istek yapılan kaynak
        { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" }, //istek yapılan sunucu
    },
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    apiSeriesViewModels = JsonConvert.DeserializeObject<List<ApiSeriesViewModel>>(body);

    foreach(var series in apiSeriesViewModels)
    {
        Console.WriteLine(series.rank + "-" + series.title + "- film puanı " + series.rating + "- yapım yılı " + series.year);
    }
  
}
Console.ReadLine();
