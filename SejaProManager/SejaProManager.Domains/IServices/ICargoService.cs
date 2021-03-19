using SejaProManager.Domains.DTOs.Cargo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SejaProManager.Domains.IServices
{
    public interface ICargoService
    {
        Task Add(CargoInsertDTO cargo);
        Task Update(CargoUpdateDTO cargo);
        Task<List<CargoResponseDTO>> GetCargos();
    }
}
