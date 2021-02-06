using DinoDevs.Classes;
using DinoTeam.Modules;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinoDevs.Web.Controllers
{
    public class DinoController : Controller
    {
        DinoLogger log;
        private string ControllerName = "Dino";

        public DinoController()
        {
            log = new DinoLogger();
        }

        public IActionResult Hihi()
        {
            string actionName = this.ControllerContext.RouteData.Values["action"].ToString();
            Logger logger = new Logger(controllerName: this.ControllerName,
                actionName: actionName, logLevel: "Debug");
            log.Debug(logger);
            log.Close();
            return View();
        }
    }
}
