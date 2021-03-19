using Microsoft.EntityFrameworkCore;
using SejaProManager.Domains.DTOs.Membros;
using SejaProManager.Domains.Entidades;
using SejaProManager.Domains.IServices;
using SejaProManager.Repository.IRepositorios;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SejaProManager.Service
{
    public class MembroService : IMembroService
    {
        private readonly IMembroRepository repository;

        public MembroService(IMembroRepository repository)
        {
            this.repository = repository;
        }

        public async Task Add(Membro membro)
        {
            await repository.Add(membro);
        }

        public async Task Update(Membro membro)
        {
            await repository.Update(membro);
        }

        public Task<Membro> GetMembroById(int id)
        {
            return repository.Query().Where(w => w.Id == id).FirstOrDefaultAsync();
        }

        public Task<List<MembrosGridDTO>> GetMembrosAsync()
        {
            return repository.Query().Select(s => new MembrosGridDTO { 
                Id = s.Id,
                Nome = s.Nome,
                Aniversario = s.DtNascimento
            }).ToListAsync();
        }

        public Task<List<MembrosNiverDTO>> GetMembrosNiversAsync(int mes)
        {
            return repository.Query()
                             .Where(w => w.DtNascimento.Month == mes)
                             .Select(s => new MembrosNiverDTO
                             {
                                Nome = s.Nome,
                                Nascimento = s.DtNascimento
                             }).ToListAsync();
        }
    }
}
