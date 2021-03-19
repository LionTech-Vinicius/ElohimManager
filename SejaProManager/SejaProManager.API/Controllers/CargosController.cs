using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SejaProManager.Domains.DTOs.Cargo;
using SejaProManager.Domains.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SejaProManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargosController : ControllerBase
    {
        private readonly ICargoService cargoService;

        public CargosController(ICargoService cargoService)
        {
            this.cargoService = cargoService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(CargoInsertDTO cargo)
        {
            await cargoService.Add(cargo);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await cargoService.GetCargos());
        }
    }
}
