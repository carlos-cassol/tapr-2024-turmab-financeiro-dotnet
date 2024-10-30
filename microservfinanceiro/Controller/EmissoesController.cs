using Microsoft.AspNetCore.Mvc;
using Services;
namespace microservfinanceiro.Controller;
using microservfinanceiro.Financeiro.Entities;

[ApiController]
[Route("/api/v1/[controller]")]
public class EmissoesController : ControllerBase
{
    private readonly ILogger<EmissoesController> _logger;
    private IEmissoesService _service;
    public EmissoesController(ILogger<EmissoesController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IResult> Get(){
        var listaEmissoes =  await _service.GetAllAsync();
        return Results.Ok(listaEmissoes);
    }
    [HttpPost]
    public async Task<IResult> Post(Emissoes emissao){
        if(emissao == null){
            return Results.BadRequest();
        }

        var emissaoSalvo = await _service.SaveAsync(emissao);

        return Results.Ok(emissaoSalvo);
    }
}
