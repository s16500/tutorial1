using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tutorial1
{
    class Program
    {

        public static async Task Main(string[] args)
        {
            //int? a = null;
            // Boolean b = false;
            //int age = 25;
            // string m = "mustfa";




            //Console.WriteLine($"i am  { age} years old);
            //Console.WriteLine($"i am  { age} years old");
            //Console.WriteLine("Hello World!");

            var url = @"https://www.pja.edu.pl/";


            var httpClient = new HttpClient();


            var response =await httpClient.GetAsync(url);


            var content = response.Content.ReadAsStringAsync();

            var regex = new Regex("[a-z]+[a-z0-9]*@[a-z]+\\.[a-z]+",RegexOptions.IgnoreCase);


            var matches = regex.Matches(content);

        foreach (var match in matches)
            {

                Console.WriteLine(match.ToString());



            }







        }
    }
}
