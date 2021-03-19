using Microsoft.AspNetCore.Mvc;
using SejaProManager.Domains.DTOs.Financeiro;
using SejaProManager.Domains.Entidades;
using SejaProManager.Domains.IServices;
using System;
using System.Threading.Tasks;

namespace SejaProManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinanceirosController : ControllerBase
    {
        private readonly IFinanceiroService financeiroService;

        public FinanceirosController(IFinanceiroService financeiroService)
        {
            this.financeiroService = financeiroService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await financeiroService.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(FinanceiroInsertDTO financeiro)
        {
            Financeiro insert = new Financeiro();
            insert.Descricao = financeiro.Descricao;
            insert.DtLancamento = financeiro.DtLancamento;
            insert.VlLancamento = financeiro.VlLancamento;
            insert.ContaLancamento = financeiro.ContaLancamento;
            insert.TipoLancamento = financeiro.TipoLancamento;
            insert.ObsLancamento = financeiro.ObsLancamento;
            insert.CreatedAt = DateTime.Now;
            insert.UpdatedAt = DateTime.Now;

            await financeiroService.Add(insert);
            
            return Ok();
        }
    }
}
