using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using AppContext = System.AppContext;

namespace WebApplication1.Controllers
{
    public class EntityController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
    }
}