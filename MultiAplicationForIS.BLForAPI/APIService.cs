using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiAplicationForIS.BLForAPI
{
    internal class APIService
    {
        public static string Post ( string url , string content )
        {
            var options = new RestClientOptions();
           
            var client = new RestClient(options);
            var request = new RestRequest(url, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = content;
           
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response =  client.ExecuteAsync(request).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return response.Content;
            }
            else
                throw new Exception(response.Content);
           
        }
    }
}
