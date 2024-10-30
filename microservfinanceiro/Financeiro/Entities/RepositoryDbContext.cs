using microservfinanceiro.Financeiro.Entities;
using Microsoft.Azure.Cosmos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace microservcolegio.Secretaria.Entities;

public class RepositoryDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    public DbSet<Bolsas> Bolsas {get;set;}
    public DbSet<Emissoes> Emissoes {get;set;}

    public RepositoryDbContext(IConfiguration configuration){
        this._configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
    optionsBuilder.UseCosmos(
                connectionString: this._configuration["CosmosDBURL"]!,
                databaseName: this._configuration["CosmosDBDBName"]!,
                cosmosOptionsAction: options =>
                {
                    options.ConnectionMode(ConnectionMode.Gateway);
                    options.HttpClientFactory(() => new HttpClient(new HttpClientHandler()
                    {
                        ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                    }));
                }

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
