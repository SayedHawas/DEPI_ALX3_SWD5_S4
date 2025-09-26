namespace AsyncDemoDay20Lab
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //https://api.github.com/repos/dotnet/runtime
            Console.WriteLine("Starting async method...");

            string url = "https://api.github.com/repos/dotnet/runtime";
            string result = await FetchDataAsync(url);

            Console.WriteLine("Data fetched:");
            Console.WriteLine(result);
        }
        //API URI (URL)
        //Get
        //await GetAsync
        static async Task<string> FetchDataAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
        }
    }
}
