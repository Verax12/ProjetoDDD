using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Domain.Entities.BaseEntitie
{
    public class BaseEntity
    {
        public virtual int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataModificação { get; set; }
    }
}
