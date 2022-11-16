using AutoMapper;
using Domain.Interfaces;
using Domain.Model;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TabelaQuartoController : ControllerBase
    {
    private readonly IBaseService<tabelaQuarto> _service;

        private readonly IMapper _mapper;

    public TabelaQuartoController(IBaseService<tabelaQuarto> service, IMapper mapper)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var entity = await _service.GetAll();
                var results = _mapper.Map<tabelaQuartoModel[]>(entity);

                return Ok(results);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(
            [FromRoute] string Id)
        {
            var entity = await _service.GetById(Id);
            var results = _mapper.Map<tabelaQuartoModel>(entity);

            return Ok(results);
        }

        [HttpPost]
        public async Task<IActionResult> Post(
            [FromBody] tabelaQuartoModel tabelaQuartoModel)
        {
        var tabelaquarto1 = _mapper.Map<tabelaQuarto>(tabelaQuartoModel);

            _service.Add(tabelaquarto1);

            if (await _service.SaveChangesAsync())
                return Created($"api/Produto/{tabelaQuartoModel.Id}", tabelaQuartoModel);

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(
            [FromRoute] string id)
        {
            var entity = await _service.GetById(id);

            if (entity == null) return NotFound();
            
            _service.Delete(entity);

            if (await _service.SaveChangesAsync()) return Ok();
            
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(
            [FromRoute] string id,
            [FromBody] tabelaQuartoModel model)
        {
            var entity = await _service.GetById(id);

            if (entity == null) return NotFound();

            _mapper.Map(model, entity);
            _service.Update(entity);

            if (await _service.SaveChangesAsync())
                return Created($"api/tabelaquarto/{model.Id}", _mapper.Map<tabelaQuartoModel>(entity));

            return BadRequest();
        }
    }
}
