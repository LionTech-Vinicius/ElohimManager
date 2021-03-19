using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SejaProManager.Domains.DTOs.Membros;
using SejaProManager.Domains.Entidades;
using SejaProManager.Domains.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SejaProManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembrosController : ControllerBase
    {
        private readonly IMembroService membroService;

        public MembrosController(IMembroService membroService)
        {
            this.membroService = membroService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMembrosAsync()
        {
             return Ok(await membroService.GetMembrosAsync());
        }

        [HttpGet("/id")]
        public async Task<IActionResult> GetMembroByIdAsync(int id)
        {
            return Ok(await membroService.GetMembroById(id));
        }

        [HttpGet("/mes")]
        public async Task<IActionResult> GetListAniversariantes(int mes)
        {
            return Ok(await membroService.GetMembrosNiversAsync(mes));
        }

        [HttpPost]
        public async Task<IActionResult> AddMembroAsync(Membro membro)
        {
            await membroService.Add(membro);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(UpdateMembroDTO updateMembroDTO)
        {
            Membro membro = new Membro();
            await membroService.Update(membro);

            return Ok();
        }
    }
}
