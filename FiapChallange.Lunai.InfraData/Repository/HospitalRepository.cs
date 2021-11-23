using Dapper;
using FiapChallange.Lunai.Domain.Entities;
using FiapChallange.Lunai.Domain.Interfaces;
using FiapChallange.Lunai.Domain.Queries;
using FiapChallange.Lunai.InfraData.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapChallange.Lunai.InfraData.Repository
{
    public class HospitalRepository : IHospitalRepository
    {

        private readonly MysqlContext _mysqlcontext;

        public HospitalRepository(MysqlContext mysqlcontext)
        {
            _mysqlcontext = mysqlcontext;
        }

       
        public IEnumerable<HospitalEntity> ListarHospitais()
        {
            return _mysqlcontext.Connection
                .Query<HospitalEntity,EnderecoEntity,HospitalEntity>(
                HospitalQueries.ListarHospitais(),
                map: (hospital, endereco) =>
                {
                    hospital.Endereco = endereco;
                    return hospital;
                },
                splitOn: "IdEndereco,IdEndereco");
        }

        public HospitalEntity DadosHospital(Guid idHospital)
        {
            var result = _mysqlcontext.Connection
                .Query<HospitalEntity, EnderecoEntity, HospitalEntity>(
                HospitalQueries.DetalheHospital(idHospital),
                map: (hospital, endereco) =>
                {
                    hospital.Endereco = endereco;
                    return hospital;
                },
                splitOn: "IdEndereco,IdEndereco");

            return result.AsList().FirstOrDefault();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
