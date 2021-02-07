using DinoDevs.Classes;
using DinoTeam.Modules;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinoDevs.Web.Controllers
{
    public class PrimaryController : Controller
    {
        private string ControllerName = "Primary";
        private DinoLogger log;

        public PrimaryController()
        {
            log = new DinoLogger();
        }

        public IActionResult Index()
        {
            string actionName = this.ControllerContext.RouteData.Values["action"].ToString();
            Logger logger = new Logger(actionName: actionName, controllerName: ControllerName, logLevel: "Error",
                more: "Divide for zero exception");
            log.Error(logger, "");
            log.Close();
            return View();
        }
    }
}
