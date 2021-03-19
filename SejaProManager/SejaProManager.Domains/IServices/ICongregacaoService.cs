using SejaProManager.Domains.DTOs.Congregacao;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SejaProManager.Domains.IServices
{
    public interface ICongregacaoService
    {
        Task Add(CongregacaoInsertDTO congregacao);
        Task Update(CongregacaoUpdateDTO congregacao);
        Task<List<CongregacaoFindDTO>> GetCongregacoes();
    }
}
