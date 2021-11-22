using System;
using System.Collections.Generic;
using System.Text;

namespace FiapChallange.Lunai.Domain.Entities
{
    public class HospitalEntity
    {
        public Guid IdHospital { get; set; }
        public string Nome { get; set; }
        public string TelefoneContato { get; set; }
        public TipoInstituicaoEnum TipoInstituicao { get; set; }
        public DateTime DataCadastro { get; set; }
        public EnderecoEntity Endereco { get; set; }
        public StatusEnum Status { get; set; }
    }
}
