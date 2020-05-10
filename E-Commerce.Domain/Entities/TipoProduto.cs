using E_Commerce.Domain.Entities.BaseEntitie;

namespace E_Commerce.Domain.Entities
{
    public class TipoProduto: BaseEntity
    {
        public string Nome { get; set; }
        public Pessoa CadastradoPor { get; set; }
        public Pessoa Professor { get; set; }
    }
}