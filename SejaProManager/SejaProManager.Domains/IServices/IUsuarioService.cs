using SejaProManager.Domains.DTOs.Usuario;
using SejaProManager.Domains.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SejaProManager.Domains.IServices
{
    public interface IUsuarioService
    {
        Task Add(UsuarioAddDTO usuario);
        Task Update(UsuarioUpdateDTO usuarioUpdate);

        Task<UsuarioResponseLoginDTO> UsuarioLogin(UsuarioRequestLoginDTO usuarioRequestLogin);
        Task<List<UsuarioBuscaDTO>> Usuarios();
    }
}
