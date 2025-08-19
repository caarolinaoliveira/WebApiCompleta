using System;
using System.Threading.Tasks;
using Dev.Business.Models;
using System.Collections.Generic;

namespace Dev.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}