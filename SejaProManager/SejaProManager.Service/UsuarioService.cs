using Microsoft.EntityFrameworkCore;
using SejaProManager.Domains.DTOs.Usuario;
using SejaProManager.Domains.Entidades;
using SejaProManager.Domains.IRepositorios;
using SejaProManager.Domains.IServices;
using SejaProManager.Domains.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SejaProManager.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository repository;
        private Criptografia criptografia = new Criptografia();

        public UsuarioService(IUsuarioRepository repository)
        {
            this.repository = repository;
        }

        public async Task Update(UsuarioUpdateDTO usuarioUpdate)
        {
            try
            {
                var res = await repository.Query().Where(w => w.Id == usuarioUpdate.Id).FirstOrDefaultAsync();

                if (res == null)
                {
                    throw new Exception("Usuário não localizado!");
                }
                else
                {
                    Usuario usuario = new Usuario();

                    if (usuarioUpdate.Login != null)
                    {
                        usuario.Login = usuarioUpdate.Login;
                    }
                    else
                    {
                        usuario.Login = res.Login;
                    }

                    if (usuarioUpdate.Nome != null)
                    {
                        usuario.Nome = usuarioUpdate.Nome;
                    }
                    else
                    {
                        usuario.Nome = res.Nome;
                    }

                    if (usuarioUpdate.Senha != null)
                    {
                        usuario.Senha = usuarioUpdate.Senha;
                    }
                    else
                    {
                        usuario.Senha = res.Senha;
                    }

                    if (usuarioUpdate.Perfil != null)
                    {
                        usuario.Perfil = usuarioUpdate.Perfil;
                    }
                    else
                    {
                        usuario.Perfil = res.Perfil;
                    }

                    await repository.Update(usuario);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na atualização do usuário: " + ex.Message);
            }

        }

        public async Task<UsuarioResponseLoginDTO> UsuarioLogin(UsuarioRequestLoginDTO usuarioRequestLogin)
        {
            try
            {

                UsuarioResponseLoginDTO usuarioResponse = new UsuarioResponseLoginDTO();

                var res = await repository.Query().Where(w => w.Login == usuarioRequestLogin.Login).FirstOrDefaultAsync();

                if (res == null)
                {
                    usuarioResponse.UserExistente = false;
                    usuarioResponse.Erro = "Usuário não cadastrado, favor entrar em contato com o Administrador!";
                }
                else
                {
                    if (!criptografia.ComparaMD5(usuarioRequestLogin.Senha, res.Senha))
                    {
                        usuarioResponse.UserExistente = true;
                        usuarioResponse.Erro = "Usuário e senha não confere!";
                    }
                    else
                    {
                        usuarioResponse.Nome = res.Nome;
                        usuarioResponse.Perfil = res.Perfil;
                        usuarioResponse.UserExistente = true;
                    }
                }

                return usuarioResponse;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao realizar login do usuário: " + ex.Message);
            }
        }

        public async Task Add(UsuarioAddDTO usuarioAddDTO)
        {
            Usuario usuario = new Usuario();

            usuario.Nome = usuarioAddDTO.Nome;
            usuario.Login = usuarioAddDTO.Login;
            usuario.Senha = criptografia.RetornarMD5(usuarioAddDTO.Senha);
            usuario.Perfil = usuarioAddDTO.Perfil;

            await repository.Add(usuario);
        }

        public async Task<List<UsuarioBuscaDTO>> Usuarios()
        {
            try
            {
                var res = await repository.Query()
                                          .Select(s => new UsuarioBuscaDTO
                                          {
                                              Id = s.Id,
                                              Nome = s.Nome,
                                              Login = s.Login,
                                              Perfil = s.Perfil
                                          }).ToListAsync();
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na consulta de usuários, " + ex.Message);
            }

        }
    }
}
