using E_Commerce.Domain.Entities.BaseEntitie;

namespace E_Commerce.Domain.Entities
{
    public class Contato : BaseEntity
    {
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool Telefone_Whatsapp { get; set; }
    }
}