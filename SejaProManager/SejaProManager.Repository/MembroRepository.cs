using SejaProManager.Domains.Entidades;
using SejaProManager.Repository.Context;
using SejaProManager.Repository.IRepositorios;

namespace SejaProManager.Repository
{
    public class MembroRepository : BaseRepository<Membro>, IMembroRepository
    {
        public MembroRepository(SejaProManagerContext context) : base(context)
        {
                
        }
    }
}
