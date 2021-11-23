using FiapChallange.Lunai.Domain.Interfaces;
using FiapChallange.Lunai.Service.Interfaces;
using FiapChallange.Lunai.Service.Mappings;
using FiapChallange.Lunai.Service.ViewModel.Hospital;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiapChallange.Lunai.Service.Services
{
    public class HospitalService : IHospitalService
    {
        private readonly ILogger<HospitalService> _logger;
        private readonly IHospitalRepository _hospitalRepository;

        public HospitalService(ILogger<HospitalService> logger, IHospitalRepository hospitalRepository)
        {
            _logger = logger;
            _hospitalRepository = hospitalRepository;
        }

        public IEnumerable<HospitalViewModel> ListarHospitais()
        {
            var hospitais = _hospitalRepository.ListarHospitais();

            return hospitais.Select(x => HospitalMapping.EntityToViewModel(x));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
