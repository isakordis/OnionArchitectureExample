using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OA.Services;

namespace OA.WEB.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices UserServices;
        private readonly IUserProfileServices userProfileServices;
        public UserController(IUserServices  userServices,IUserProfileServices userProfile)
        {
            this.UserServices = userServices;
            this.userProfileServices = userProfile;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
