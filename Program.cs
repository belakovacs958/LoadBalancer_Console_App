using System.Net;



string input = "0";

while (true) {
    

Console.WriteLine("wrinte in a number");

input = Console.ReadLine();


var url = "http://172.24.9.102:4000/WeatherForecast/http%3A%2F%2F172.24.9.102%3A8080%2FWeatherForecast%2F" + input;

HttpClient client = new HttpClient();
string data = await client.GetStringAsync(url);

System.Console.WriteLine(data);

}


