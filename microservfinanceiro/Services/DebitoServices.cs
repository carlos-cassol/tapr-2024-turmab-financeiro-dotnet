using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microservcolegio.Secretaria.Entities;
using microservfinanceiro.Financeiro.Entities;

namespace Services
{
    public class DebitoServices : IDebitoService
    {
        private  RepositoryDbContext _dbContext;

        public async Task<List<Debitos>> GetAllAsync()
        {
            var listaDebitos = _dbContext.Debitos.ToList();
            return listaDebitos!;
        }

        public async Task<Debitos> SaveAsync(Debitos debito)
        {
            await _dbContext.AddAsync(debito);
            await _dbContext.SaveChangesAsync();

            return debito;
        }
    }
}