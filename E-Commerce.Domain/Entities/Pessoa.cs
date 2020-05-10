using E_Commerce.Domain.Entities.BaseEntitie;
using System;

namespace E_Commerce.Domain.Entities
{
    public class Pessoa : BaseEntity
    {
        public string PrimeiroNome { get; set; }
        public string UltimoName { get; set; }
        public Contato Contato { get; set; }
        public DateTime Nascimento { get; set; }
        public bool Ativo { get; set; }

       
    }
}