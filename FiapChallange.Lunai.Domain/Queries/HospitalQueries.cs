using System;
using System.Collections.Generic;
using System.Text;

namespace FiapChallange.Lunai.Domain.Queries
{
    public static class HospitalQueries
    {
        public static string ListarHospitais()
        {
            return "SELECT * FROM Lunai.Hospitais h Join Lunai.Enderecos e on h.IdEndereco = e.IdEndereco WHERE h.Status=1;";
        }

        public static string DetalheHospital(Guid idHospital)
        {
            return $"SELECT * FROM Lunai.Hospitais h Join Lunai.Enderecos e on h.IdEndereco = e.IdEndereco WHERE h.IdHospital={idHospital.ToString()};";
        }
    }
}
