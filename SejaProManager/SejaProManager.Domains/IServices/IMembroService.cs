using SejaProManager.Domains.DTOs.Membros;
using SejaProManager.Domains.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SejaProManager.Domains.IServices
{
    public interface IMembroService
    {
        Task Add(Membro membro);
        Task Update(Membro membro);

        Task<List<MembrosGridDTO>> GetMembrosAsync();
        Task<Membro> GetMembroById(int id);
        Task<List<MembrosNiverDTO>> GetMembrosNiversAsync(int mes);
    }
}
