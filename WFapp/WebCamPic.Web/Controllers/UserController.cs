using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCamPic.Web.Models;

namespace WebCamPic.Web.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Login(string username, string pass)
        {
            User user = new User();
            return View();
        }
    }
}