using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microservcolegio.Secretaria.Entities;
using microservfinanceiro.Financeiro.Entities;

namespace Services
{
    public class BolsasService : IBolsasService
    {
        private RepositoryDbContext _dbContext;

        public async Task<List<Bolsas>> GetAllAsync()
        {
            var listaBolsas = _dbContext.Bolsas.ToList();
            return listaBolsas!;
        }


        public async Task<Bolsas> SaveAsync(Bolsas bolsa)
        {
            await _dbContext.AddAsync(bolsa);
            await _dbContext.SaveChangesAsync();

            return bolsa;
        }
    }
}