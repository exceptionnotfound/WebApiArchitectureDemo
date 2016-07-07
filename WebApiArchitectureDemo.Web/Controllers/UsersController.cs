using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using WebApiArchitectureDemo.Web.Clients;

namespace WebApiArchitectureDemo.Web.Controllers
{
    [RoutePrefix("users")]
    public class UsersController : Controller
    {
        private IApiClient _apiClient;

        public UsersController(IApiClient client)
        {
            _apiClient = client;
        }

        [HttpGet]
        [Route("index")]
        public ActionResult Index()
        {
            return View(_apiClient.GetAllUsers());
        }
    }
}
