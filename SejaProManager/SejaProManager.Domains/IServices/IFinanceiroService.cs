using SejaProManager.Domains.DTOs.Financeiro;
using SejaProManager.Domains.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SejaProManager.Domains.IServices
{
    public interface IFinanceiroService
    {
        Task Add(Financeiro financeiro);

        Task Update(Financeiro financeiro);

        Task<List<FinanceiroFindDTO>> GetAll();

        Task<List<FinanceiroFindDTO>> GetByTipo(string tipo);

        Task<List<FinanceiroFindDTO>> GetById(int id);
    }
}
