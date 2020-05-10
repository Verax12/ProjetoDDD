using System;
using System.Collections.Generic;
using System.Text;
using E_Commerce.Domain.Entities.BaseEntitie;

namespace E_Commerce.Domain.Entities
{
    public class Cliente : Pessoa
    {
        IEnumerable<Produtos> Produtos { get; set; }
        public Perfil Perfil { get => Perfil.Cliente; }



        /// <summary>
        /// Retorna a Idade do Cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>Idade do Cliente </returns>
        public int Idade(Cliente cliente)
        {
            //Precisa Finalizar o methodo.
            return cliente.Nascimento.Year;
        }
    }
}
