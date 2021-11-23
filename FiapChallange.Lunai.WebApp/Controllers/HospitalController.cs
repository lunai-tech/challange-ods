using FiapChallange.Lunai.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace FiapChallange.Lunai.WebApp.Controllers
{
    public class HospitalController : Controller
    {
        private readonly IHospitalService _hospitalService;

        public HospitalController(IHospitalService hospitalService)
        {
            _hospitalService = hospitalService;
        }

        public ActionResult ListarHospitais()
        {
            var listaHospitais = _hospitalService.ListarHospitais();
            return View(listaHospitais);
        }    
    }
}
