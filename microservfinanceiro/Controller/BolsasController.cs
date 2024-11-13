using microservfinanceiro.Financeiro.Entities;
using microservfinanceiro.Financeiro.Enumerables;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace microservfinanceiro.Controller
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class BolsasController : ControllerBase
    {
        private IBolsasService _service;

        public BolsasController(IBolsasService service){
            this._service = service;
        }
        [HttpGet]
        public async Task<IResult> Get(){
            var listaBolsas =  await _service.GetAllAsync();
            return Results.Ok(listaBolsas);
        }
        [HttpPost]
        public async Task<IResult> Post(Bolsas aluno){
            if(aluno == null){
                return Results.BadRequest();
            }

            var alunoSalvo = await _service.SaveAsync(aluno);

            return Results.Ok(alunoSalvo);
        }
        [HttpPut("{id}")]
        public async Task<IResult> Put(Guid id, [FromBody] Bolsas bolsa) {
            if(bolsa is null || id == Guid.Empty)
                return Results.BadRequest();

            bolsa = await _service.UpdateAsync(id, bolsa);
            if(bolsa is null)
                return Results.NotFound();

            return Results.Ok(bolsa);
        }
    
    }
}
