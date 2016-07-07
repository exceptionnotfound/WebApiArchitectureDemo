using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiArchitectureDemo.Common.DTOs;

namespace WebApiArchitectureDemo.Web.Clients
{
    public interface IApiClient
    {
        List<User> GetAllUsers();
    }
}