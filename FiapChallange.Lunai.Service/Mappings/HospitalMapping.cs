using FiapChallange.Lunai.Domain.Entities;
using FiapChallange.Lunai.Service.ViewModel.Hospital;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiapChallange.Lunai.Service.Mappings
{
    public static class HospitalMapping
    {
        public static HospitalViewModel EntityToViewModel(HospitalEntity hospital)
        {
            return new HospitalViewModel()
            {
                IdHospital = hospital.IdHospital,
                NomeHospital = hospital.Nome,
                Aberto = hospital.Status.Equals(StatusEnum.Aberto) ? true : false,
                TipoInstituicao = hospital.TipoInstituicao.ToString(),
                TelefoneContato = hospital.TelefoneContato,
                HorarioDisponiveis = new List<string>(new string[] { "11:30", "12:00", "13:00", "13:30" ,"16:00", "18:00" }),
                Endereco = $"{hospital.Endereco.Rua}, Nº {hospital.Endereco.Numero} - {hospital.Endereco.Bairro}, {hospital.Endereco.Cidade} - {hospital.Endereco.Estado}"
            };
        }
    }
}
