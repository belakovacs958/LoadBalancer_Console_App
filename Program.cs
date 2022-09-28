using System.Net;



string input = "0";

while (true) {
    

Console.WriteLine("write in a number");

input = Console.ReadLine();


var url = "http://192.168.1.103:4000/DistributeRequest/http%3A%2F%2F192.168.1.103%3A8080%2FListNumbers%2F" + input;

HttpClient client = new HttpClient();
string data = await client.GetStringAsync(url);



System.Console.WriteLine(data);

}


