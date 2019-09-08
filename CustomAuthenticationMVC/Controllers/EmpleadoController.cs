using CustomAuthenticationMVC.CustomAuthentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomAuthenticationMVC.Controllers
{
    [CustomAuthorize(Roles = "Empleado")]
    public class EmpleadoController : Controller
    {

        // GET: User  
        public ActionResult Index()
        {
            ViewBag.Nombre = User.Identity.Name;
            return View();
        }
    }
}
