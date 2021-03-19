using Microsoft.EntityFrameworkCore;
using SejaProManager.Domains.DTOs.Cargo;
using SejaProManager.Domains.Entidades;
using SejaProManager.Domains.IRepositorios;
using SejaProManager.Domains.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SejaProManager.Service
{
    public class CargoService : ICargoService
    {
        private readonly ICargoRepository repository;

        public CargoService(ICargoRepository repository)
        {
            this.repository = repository;
        }

        public async Task Add(CargoInsertDTO cargo)
        {
            Cargo cargoInsert = new Cargo();
            cargoInsert.Nome = cargo.Nome;

            await repository.Add(cargoInsert);
        }

        public async Task<List<CargoResponseDTO>> GetCargos()
        {
            try
            {
                return await repository.Query().Select(s => new CargoResponseDTO
                {
                    Id = s.Id,
                    Nome = s.Nome
                }).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao consultar Cargos: {ex.Message}");
            }
        }

        public async Task Update(CargoUpdateDTO cargo)
        {
            Cargo cargoUpdate = new Cargo();

            var res = await repository.Query().Where(w => w.Id == cargo.Id).FirstOrDefaultAsync();

            if (res != null)
                await repository.Update(cargoUpdate);
        }
    }
}
