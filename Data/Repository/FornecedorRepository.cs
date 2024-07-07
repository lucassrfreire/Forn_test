using FornecedorAPI.Models;
using Microsoft.EntityFrameworkCore;
using Playmove.Data.Interfaces;

namespace Playmove.Data.Repository
{
    public class FornecedorRepository : AppRepository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(AppDbContext context) : base(context) { }

        public async Task<List<Fornecedor>> Listar()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public async Task<Fornecedor> Obter(Guid Id)
        {
            return await DbSet.Where(x => x.Id.Equals(Id)).FirstOrDefaultAsync();
        }
    }
}
