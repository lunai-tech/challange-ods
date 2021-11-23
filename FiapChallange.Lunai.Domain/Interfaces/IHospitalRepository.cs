using FiapChallange.Lunai.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FiapChallange.Lunai.Domain.Interfaces
{
    public interface IHospitalRepository : IDisposable
    {
        IEnumerable<HospitalEntity> ListarHospitais();

        HospitalEntity DadosHospital(Guid idHospital);

    }
}
