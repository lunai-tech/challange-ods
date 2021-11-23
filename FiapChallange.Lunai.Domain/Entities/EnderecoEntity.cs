﻿using System;

namespace FiapChallange.Lunai.Domain.Entities
{
    public class EnderecoEntity
    {
        public Guid IdEndereco { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Complemento { get; set; }
    }
}