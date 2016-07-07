using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiArchitectureDemo.Common.DTOs;

namespace WebApiArchitectureDemo.Web.Clients
{
    public class ApiClient : RestClient, IApiClient
    {
        private static readonly string BaseURL = "http://localhost:55675/";

        public ApiClient() : base(BaseURL) { }

        public List<User> GetAllUsers()
        {
            RestRequest request = new RestRequest("users/all");
            var response = base.Execute(request);
            return JsonConvert.DeserializeObject<List<User>>(response.Content);
        }
    }
}