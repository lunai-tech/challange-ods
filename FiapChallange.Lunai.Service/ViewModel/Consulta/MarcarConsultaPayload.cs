using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace FiapChallange.Lunai.Service.ViewModel.Consulta
{
    public class MarcarConsultaPayload
    {
        [JsonPropertyName("documento")]
        [Required]
        public string Documento { get; set; }

        [JsonPropertyName("nome_completo")]
        [Required]
        public string NomeCompleto { get; set; }

        [JsonPropertyName("data_nascimento")]
        [Required]
        public DateTime DataNascimento { get; set; }

        [JsonPropertyName("horario_consulta")]
        [Required]
        public string HorarioConsulta { get; set; }

        [JsonPropertyName("id_hospital")]
        [Required]
        public Guid IdHospital { get; set; }
    }
}
