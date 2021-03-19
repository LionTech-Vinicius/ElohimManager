using SejaProManager.Domains.Entidades;
using SejaProManager.Domains.IRepositorios;
using SejaProManager.Repository.Context;

namespace SejaProManager.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(SejaProManagerContext context) : base(context)
        {

        }
    }
}
