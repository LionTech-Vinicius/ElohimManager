using SejaProManager.Domains.Entidades;
using SejaProManager.Domains.IRepositorios;
using SejaProManager.Repository.Context;

namespace SejaProManager.Repository
{
    public class FinanceiroRepository : BaseRepository<Financeiro>, IFinanceiroRepository
    {
        public FinanceiroRepository(SejaProManagerContext context) : base(context)
        {

        }
    }
}
