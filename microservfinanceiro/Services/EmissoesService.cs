using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microservcolegio.Secretaria.Entities;
using microservfinanceiro.Financeiro.Entities;

namespace Services
{
    public class EmissoesService : IEmissoesService
    {
        private RepositoryDbContext _dbContext;

        public async Task<List<Emissoes>> GetAllAsync()
        {
            var listaEmissoes = _dbContext.Emissoes.ToList();
            return listaEmissoes;
        }

        public async Task<Emissoes> SaveAsync(Emissoes emissao)
        {
            await _dbContext.AddAsync(emissao);
            await _dbContext.SaveChangesAsync();

            return emissao;
        }
    }
}