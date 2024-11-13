using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microservcolegio.Secretaria.Entities;
using microservfinanceiro.Financeiro.Entities;
using Microsoft.EntityFrameworkCore;

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

        public async Task<Bolsas> UpdateAsync(Guid Id, Bolsas bolsa)
        {
            Guid oldId = Guid.Empty;
            var dbBolsa = await _dbContext.Bolsas.Where(b => b.Id == bolsa.Id).FirstOrDefaultAsync();
            if(dbBolsa is not null){
                dbBolsa = bolsa;
                dbBolsa.Id = oldId;
                await _dbContext.SaveChangesAsync();
                return dbBolsa;
            }
            return null;

        }

            public async Task<Bolsas> DeleteAsync(Guid Id){
            Guid oldId = Guid.Empty;
            var dbBolsa = await _dbContext.Bolsas.Where(b => b.Id == Id).FirstOrDefaultAsync();
                if(dbBolsa is not null){
                    _dbContext.Remove(dbBolsa);
                    await _dbContext.SaveChangesAsync();
                    return dbBolsa;
                }
            return null;
        }
    }
}