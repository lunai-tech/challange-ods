using System;
using System.Collections.Generic;
using System.Text;

namespace FiapChallange.Lunai.Service.ViewModel.Hospital
{
    public class HospitalViewModel
    {
        public Guid IdHospital { get; set; }
        public string NomeHospital { get; set; }
        public bool Aberto { get; set; }
        public string TipoInstituicao { get; set; }
        public string TelefoneContato { get; set; }
        public string Endereco { get; set; }

        public List<string> HorarioDisponiveis { get; set; }
    }
}
