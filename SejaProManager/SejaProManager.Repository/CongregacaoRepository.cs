using SejaProManager.Domains.Entidades;
using SejaProManager.Domains.IRepositorios;
using SejaProManager.Repository.Context;

namespace SejaProManager.Repository
{
    public class CongregacaoRepository : BaseRepository<Congregacao>, ICongregacaoRepository
    {
        public CongregacaoRepository(SejaProManagerContext context) : base(context)
        {

        }
    }
}
