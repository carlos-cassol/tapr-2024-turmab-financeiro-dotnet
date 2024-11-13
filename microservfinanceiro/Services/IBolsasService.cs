using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microservfinanceiro.Financeiro.Entities;

namespace Services
{
    public interface IBolsasService
    {
        public Task<List<Bolsas>> GetAllAsync();
        public Task<Bolsas> SaveAsync(Bolsas bolsa);

        public Task<Bolsas> UpdateAsync(Guid Id, Bolsas bolsas);
        public Task<Bolsas> DeleteAsync(Guid Id);
    }
}