using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SejaProManager.Domains.DTOs.Congregacao;
using SejaProManager.Domains.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SejaProManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CongregacoesController : ControllerBase
    {
        private readonly ICongregacaoService congregacaoService;

        public CongregacoesController(ICongregacaoService congregacaoService)
        {
            this.congregacaoService = congregacaoService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(CongregacaoInsertDTO congregacao)
        {
            await congregacaoService.Add(congregacao);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await congregacaoService.GetCongregacoes());
        }
    }
}
