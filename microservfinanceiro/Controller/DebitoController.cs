using microservfinanceiro.Financeiro.Entities;
using microservfinanceiro.Financeiro.Enumerables;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace microservfinanceiro.Controller
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class DebitoController : ControllerBase
    {
        private IDebitoService _service;
        private object debito;

        public DebitoController(IDebitoService service){
            this._service = service;
        }
        [HttpGet]
        public async Task<IResult> Get(){
            var listaDebito =  await _service.GetAllAsync();
            return Results.Ok(listaDebito);
        }
        [HttpPost]
        public async Task<IResult> Post(Debitos debito){
            if(debito == null){
                return Results.BadRequest();
            }

            var debitoSalvo = await _service.SaveAsync(debito);

            return Results.Ok(debitoSalvo);
        }
    
    
    }
}
