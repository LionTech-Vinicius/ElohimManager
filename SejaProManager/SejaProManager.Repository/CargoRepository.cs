using SejaProManager.Domains.Entidades;
using SejaProManager.Domains.IRepositorios;
using SejaProManager.Repository.Context;

namespace SejaProManager.Repository
{
    public class CargoRepository : BaseRepository<Cargo>, ICargoRepository
    {
        public CargoRepository(SejaProManagerContext context) : base(context)
        {

        }
    }
}
