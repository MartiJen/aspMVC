using Roomy.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roomy.Areas.BackOffice.Controllers
{
    [AuthenticationFilter]
    public class DashBoardController : Controller
    {
        // GET: BackOffice/DashBoard
        public ActionResult Index()
        {
            return View();
        }
    }
}