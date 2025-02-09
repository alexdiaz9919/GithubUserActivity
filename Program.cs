using static System.Net.WebRequestMethods;

namespace GithubUserActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
                Console.WriteLine("Usage: github-activity <username>");
            else
            {
                var username = args[1];
                var url = $"https://api.github.com/users/{username}/events";

                var client = new HttpClient();
                client.BaseAddress = new Uri(url);

                var response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();

                var result = response.Content.ReadAsStringAsync().Result;

            }
        }
    }
}
