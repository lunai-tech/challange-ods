using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiapChallange.Lunai.WebApp.Controllers
{
    public class MarcarConsultaController : Controller
    {
        // GET: MarcarConsultaController
        public ActionResult Index(Guid idHospital)
        {
            return View();
        }
    }
}
