using FiapChallange.Lunai.Service.ViewModel.Hospital;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiapChallange.Lunai.Service.Interfaces
{
    public interface IHospitalService : IDisposable
    {
        IEnumerable<HospitalViewModel> ListarHospitais(); 
    }
}
