using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Goplecs.GTracker.DAL;

namespace Goplecs.GTracker.Api.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        [ActionName("GetAllUsers")]
        public List<User> Get()
        {
            using (var Context = new GTContext())
            {
               var a =  Context.Users.ToList();
                return a;
            }
        }

        [HttpPost]
        [ActionName("Save")]
        public User Save(User user)
        {
            if (user == null)
            {
                return new User();
            }
            else
            {
                using (var Context = new GTContext())
                {
                   var savedUser =  Context.Users.Add(user);
                   Context.SaveChanges();
                    return savedUser;

                }
            }
        }
    }
}
