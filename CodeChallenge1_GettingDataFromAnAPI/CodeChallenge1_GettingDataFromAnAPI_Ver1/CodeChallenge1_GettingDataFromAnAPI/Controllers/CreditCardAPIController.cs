using System;
using System.Threading.Tasks;
using CodeChallenge1_GettingDataFromAnAPI.Helpers;
using Newtonsoft.Json;

using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace CodeChallenge1_GettingDataFromAnAPI.Controllers
{
    public class CreditCardAPIController
    {
    public  string Token { get; set; }
    public  string User { get; set; }

        public  async Task<List<string>> GetTerminalIdentifiers()
        {
            try
            {

        
            var client = new HttpClient();
            var authToken = Encoding.ASCII.GetBytes($"{User}:{Token}");

            client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", Convert.ToBase64String(authToken));
           
            var response = await client.PostAsync("https://ccm.cps.golf/RegressionSRCCM/Transactions.svc/GetTerminalIdentifiers", null);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();

            return !string.IsNullOrEmpty(content) ?
               JsonConvert.DeserializeObject<List<String>>(content) :
               new List<string>();
           
            }
            catch (Exception e){
                Console.WriteLine(e.ToString());
                return new List<string>();
            }

        }
    }
}
