using Microsoft.EntityFrameworkCore;
using SejaProManager.Domains.DTOs.Financeiro;
using SejaProManager.Domains.Entidades;
using SejaProManager.Domains.IRepositorios;
using SejaProManager.Domains.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SejaProManager.Service
{
    public class FinanceiroService : IFinanceiroService
    {
        private readonly IFinanceiroRepository repository;

        public FinanceiroService(IFinanceiroRepository repository)
        {
            this.repository = repository;
        }
        public Task Add(Financeiro financeiro)
        {
            return repository.Add(financeiro);
        }

        public Task<List<FinanceiroFindDTO>> GetAll()
        {
            return repository.Query().Select(s => new FinanceiroFindDTO { 
                Id = s.Id,
                DtLancamento = s.DtLancamento,
                Descricao = s.Descricao,
                VlLancamento = s.VlLancamento,
                ContaLancamento = s.ContaLancamento,
                TipoLancamento = s.TipoLancamento,
                ObsLancamento = s.ObsLancamento,
                CreatedAt = s.CreatedAt,
                UpdatedAt = s.UpdatedAt
            }).ToListAsync();
        }

        public Task<List<FinanceiroFindDTO>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<FinanceiroFindDTO>> GetByTipo(string tipo)
        {
            throw new NotImplementedException();
        }

        public Task Update(Financeiro financeiro)
        {
            throw new NotImplementedException();
        }
    }
}
