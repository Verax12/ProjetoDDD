using E_Commerce.Domain.Entities.BaseEntitie;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Domain.Entities
{
    public class Produtos : BaseEntity
    {
        public string Nome { get; set; }
        public TipoProduto TipoProduto { get; set; }
        public decimal Valor { get; set; }
        public DateTime Validade { get; set; }
    }
}
