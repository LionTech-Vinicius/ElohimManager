using Microsoft.EntityFrameworkCore;
using SejaProManager.Domains.DTOs.Congregacao;
using SejaProManager.Domains.Entidades;
using SejaProManager.Domains.IRepositorios;
using SejaProManager.Domains.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SejaProManager.Service
{
    public class CongregacaoService : ICongregacaoService
    {
        private readonly ICongregacaoRepository repository;

        public CongregacaoService(ICongregacaoRepository repository)
        {
            this.repository = repository;
        }

        public async Task Add(CongregacaoInsertDTO congregacao)
        {
            Congregacao congregacaoInsert = new Congregacao();
            congregacaoInsert.Nome = congregacao.Nome;
            congregacaoInsert.NomeResp = congregacao.NomeResp;
            congregacaoInsert.DtFundacao = congregacao.DtFundacao;
            congregacaoInsert.Endereco = congregacao.Endereco;
            congregacaoInsert.Observacao = congregacao.Observacao;

            await repository.Add(congregacaoInsert);
        }

        public async Task<List<CongregacaoFindDTO>> GetCongregacoes()
        {
            return await repository.Query().Select(s => new CongregacaoFindDTO { 
                Id = s.Id,
                Nome = s.Nome,
                DtFundacao = s.DtFundacao,
                NomeResp = s.NomeResp,
                Observacao = s.Observacao
            }).ToListAsync();
        }

        public async Task Update(CongregacaoUpdateDTO congregacao)
        {

            Congregacao congregacaoUpdate = new Congregacao();
            congregacaoUpdate.Nome = congregacao.Nome;
            congregacaoUpdate.NomeResp = congregacao.NomeResp;
            congregacaoUpdate.DtFundacao = congregacao.DtFundacao;
            congregacaoUpdate.Endereco = congregacao.Endereco;
            congregacaoUpdate.Observacao = congregacao.Observacao;

            await repository.Add(congregacaoUpdate);
        }
    }
}
