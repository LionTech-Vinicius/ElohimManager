using Microsoft.AspNetCore.Mvc;
using SejaProManager.Domains.DTOs.Usuario;
using SejaProManager.Domains.Entidades;
using SejaProManager.Domains.IServices;
using System;
using System.Threading.Tasks;

namespace SejaProManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        [HttpPost]
        public async Task<IActionResult> AddUsuario(UsuarioAddDTO usuario)
        {
            await usuarioService.Add(usuario);

            return Ok();
        }

        [HttpPost("/login")]
        public async Task<IActionResult> LoginUsuario(UsuarioRequestLoginDTO usuarioRequest)
        {
            return Ok(await usuarioService.UsuarioLogin(usuarioRequest));
        }

        [HttpGet]
        public async Task<IActionResult> ListarUsuarios()
        {
            return Ok(await usuarioService.Usuarios());
        }
    }
}
