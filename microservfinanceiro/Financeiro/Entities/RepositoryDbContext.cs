using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microservfinanceiro.Financeiro.Entities;
using Microsoft.Azure.Cosmos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace microservcolegio.Secretaria.Entities;

public class RepositoryDbContext : DbContext
{
    private IConfiguration _configuration;
    private DbSet<Bolsas> Bolsas {get;set;}

    public RepositoryDbContext(IConfiguration configuration){
        this._configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseCosmos(
            connectionString: this._configuration["CosmosDBURL"],
            databaseName: this._configuration["CosmosDBDBName"]
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bolsas>()
            .HasNoDiscriminator();
        modelBuilder.Entity<Bolsas>()
            .ToContainer("Bolsas");
        modelBuilder.Entity<Bolsas>()
            .Property(p => p.Id)
            .HasValueGenerator<GuidValueGenerator>();
        modelBuilder.Entity<Bolsas>()
            .HasPartitionKey(p => p.Id);

    }

}