using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiapChallange.Lunai.WebApp.Controllers
{
    public class HospitalController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;


        public HospitalController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public ActionResult ListarHospitais()
        {
            return View();
        }    
    }
}
