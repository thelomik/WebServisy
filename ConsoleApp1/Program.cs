using System.Collections;
using System.Net;
using System.Text;
using System.Text.Json;

var url = "https://localhost:7292/WeatherForecast";

var request = WebRequest.Create(url);
request.Method = "GET";

using var webResponse = request.GetResponse();
using var webStream = webResponse.GetResponseStream();

using var reader = new StreamReader(webStream);
var data = reader.ReadToEnd();

Console.WriteLine(data);

