//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using Newtonsoft.Json;
//using System.Net;
//using Newtonsoft.Json.Linq;
//using System.IO;
using System.Threading.Tasks;
using CodeChallenge1_GettingDataFromAnAPI.Controllers;
using CodeChallenge1_GettingDataFromAnAPI.Models;



namespace CodeChallenge1_GettingDataFromAnAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {

            CreditCardAPIController creditCardCtl = new CreditCardAPIController();
            creditCardCtl.User = "Regression";
            creditCardCtl.Token = "f8cd3f4554f74a89bdb625bc";
            TerminalIdentifiersModel terminalIdentifiersMdl = new TerminalIdentifiersModel();
            terminalIdentifiersMdl.TerminalNames = await creditCardCtl.GetTerminalIdentifiers();
             
             
            System.Console.WriteLine(terminalIdentifiersMdl.ToString());
            System.Console.WriteLine("Press enter to continue.");
            System.Console.ReadLine();
            /**
             * Objective: Write a controller to pull data from an API. Data must be stored in a model. 
             * I don't want to see too much work done within this main class. You should encapsulate anything you can in a
             * controller.
             * 
             * Endpoint: https://ccm.cps.golf/RegressionSRCCM/Transactions.svc/GetTerminalIdentifiers
             * Result type: List of Strings
             * User: Regression
             * User Token: f8cd3f4554f74a89bdb625bc
             * 
             * To authenticate against this API, you need to send an HTTP header called Authorization and provide the username
             * and user token in the format of user:token as a Base64 encoded string.
             * 
             * 
             * 
             */
            // var userName = "Regression";
            // var passwd = "f8cd3f4554f74a89bdb625bc";
            // var url ="https://ccm.cps.golf/RegressionSRCCM/Transactions.svc/GetTerminalIdentifiers";// "https://httpbin.org/basic-auth/user7/passwd";
            // url = "https://ccm.cps.golf";
            // url = "https://ccm.cps.golf/RegressionSRCCM";
            // //url = "Transactions.svc/GetTerminalIdentifiers";
            // //url = "RegressionSRCCM/Transactions.svc/GetTerminalIdentifiers";
            // var client = new HttpClient();

            // var authToken = Encoding.ASCII.GetBytes($"{userName}:{passwd}");
            // client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
            //         Convert.ToBase64String(authToken));
            //// client.BaseAddress = new Uri("https://ccm.cps.golf");
            //// client.DefaultRequestHeaders.Accept.Add(
            ////        new MediaTypeWithQualityHeaderValue("application/json"));
            // var result = await client.GetAsync(url);

            // var content = await result.Content.ReadAsStringAsync();
            // Console.WriteLine(content);





            /* 
            * Helpers:
            * EncodingHelper class in the Helpers folder will allow you to encode/decode a base64 string for doing API autentication. 
            * The use case is EncodingHelper.Encode(string).
            * 
            * NuGet Packages:
            * Newtonsoft.Json allows you to convert JSON replies from API requests to a usable object or vice versa.
            * 
            * Advice - The HttpClient class will allow you to send/receive responses from an API. API requests are done asynchronously
            * so you'll have to use an await.
            * */

            //               var userName = "Regression";
            //    var passwd = "f8cd3f4554f74a89bdb625bc";
            //    var url = "https://ccm.cps.golf/RegressionSRCCM/Transactions.svc/GetTerminalIdentifiers";// "https://httpbin.org/basic-auth/user7/passwd";
            //    url = "https://ccm.cps.golf";
            //    url = "https://ccm.cps.golf/RegressionSRCCM";
            //    //url = "Transactions.svc/GetTerminalIdentifiers";
            //    //url = "RegressionSRCCM/Transactions.svc/GetTerminalIdentifiers";
            //    url = "https://ccm.cps.golf/RegressionSRCCM/Transactions.svc/GetTerminalIdentifiers";
            //    var client = new HttpClient();
            //     var authToken = Encoding.ASCII.GetBytes($"{userName}:{passwd}");
            //    //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
            //    //        Convert.ToBase64String(authToken));
            //   // client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", Convert.ToBase64String(authToken));
            //    //client.DefaultRequestHeaders.Add("Authorization", Convert.ToBase64String(authToken));
            //    client.DefaultRequestHeaders.Add("Authorization", $"TOKEN id=\"{Convert.ToBase64String(authToken)}\"");
            //    // client.BaseAddress = new Uri("https://ccm.cps.golf");
            //    // client.DefaultRequestHeaders.Accept.Add(
            //    //        new MediaTypeWithQualityHeaderValue("application/json"));
            //    var result = await client.GetAsync(url); //PostAsync(url.ToString(), default(string),Convert.ToBase64String(authToken), null, null); //GetAsync(url);
            //    var response = await client.PostAsync(url.ToString(), null);

            //   var content = await result.Content.ReadAsStringAsync();
            //    Console.WriteLine(content);

            //   await PostAsync1(client,Convert.ToBase64String(authToken),url,"test" );

            //    //host = host.EndsWith("/") ? host : $"{host}/";
            //    //var url = new Uri($"{host}Transactions.svc/GetTerminalIdentifiers");
            //    //var authorizeToken = CPSEncryption.EncryptBaseString64($"{username}:{token}");

            //    //var response = await _apiClient.PostAsync(url.ToString(), default(string), authorizeToken, null, null);
            //    //response.EnsureSuccessStatusCode();
            //    //var jsonResponse = await response.Content.ReadAsStringAsync();

            //    //return !string.IsNullOrEmpty(jsonResponse) ?
            //    //    JsonConvert.DeserializeObject<string[]>(jsonResponse) :
            //    //    throw new ReferencesNotFoundDomainException();

        }

        /// <summary>
        /// Post for a REST api
        /// </summary>
        /// <param name="token">authorization token</param>
        /// <param name="url">REST url for the resource</param>
        /// <param name="content">content</param>
        /// <returns>response from the rest url</returns>
        //public static async Task<JObject> PostAsync(string token, string url, string content)
        //{
        //    byte[] data = Encoding.UTF8.GetBytes(content);
        //    WebRequest request = WebRequest.Create(url);
        //    request.Method = "POST";
        //    request.ContentType = "application/json";
        //    request.Headers.Add("Authorization", "Bearer " + token);
        //    request.ContentLength = data.Length;



        //    using (Stream stream = request.GetRequestStream())
        //    {
        //        stream.Write(data, 0, data.Length);
        //    }

        //    try
        //    {
        //        WebResponse response = await request.GetResponseAsync();
        //        using (StreamReader reader = new StreamReader(response.GetResponseStream()))
        //        {
        //            string responseContent = reader.ReadToEnd();
        //            JObject adResponse =
        //                Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(responseContent);
        //            return adResponse;
        //        }
        //    }
        //    catch (WebException webException)
        //    {
        //        if (webException.Response != null)
        //        {
        //            using (StreamReader reader = new StreamReader(webException.Response.GetResponseStream()))
        //            {
        //                string responseContent = reader.ReadToEnd();
        //                return Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(responseContent); ;
        //            }
        //        }
        //    }

        //    return null;

        //}
        //public static async Task<HttpResponseMessage> PostAsync1(HttpClient client, string token, string url, string content)
        //{
        //    try
        //    {
        //        var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);

        //        requestMessage.Headers.Add("Authorization", token);

        //        //byte[] data = Encoding.UTF8.GetBytes(content);
        //        //WebRequest request = WebRequest.Create(url);
        //        //request.Method = "POST";
        //        //request.ContentType = "application/json";
        //        //request.Headers.Add("Authorization", "Bearer " + token);
        //        //request.ContentLength = data.Length;


        //        object item = new object();
        //        var response = await client.SendAsync(requestMessage);

        //        // raise exception if HttpResponseCode 500 
        //        // needed for circuit breaker to track fails

        //        if (response.StatusCode == HttpStatusCode.InternalServerError)
        //        {
        //            throw new HttpRequestException();
        //        }

        //        return response;
        //    }
           
        //    catch (WebException webException)
        //    {
        //        if (webException.Response != null)
        //        {
        //            using (StreamReader reader = new StreamReader(webException.Response.GetResponseStream()))
        //            {
        //                string responseContent = reader.ReadToEnd();
        //                //return Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(responseContent); ;

        //            }
        //        }
        //        return null;
        //    }
        //    catch (Exception exp)

        //    {
        //        Console.WriteLine(exp.ToString());
        //        return null;
        //    }



        //}
    }
   
}
