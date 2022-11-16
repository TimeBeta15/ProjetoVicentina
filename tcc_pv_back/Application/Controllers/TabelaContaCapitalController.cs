using AutoMapper;
using Domain.Interfaces;
using Domain.Model;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TabelaContaCapitalController : ControllerBase
    {
        private readonly IBaseService<tabelaContaCapital> _service;

        private readonly IMapper _mapper;

        public TabelaContaCapitalController(IBaseService<tabelaContaCapital> service, IMapper mapper)
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
                var results = _mapper.Map<tabelaContaCapitalModel[]>(entity);

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
            var results = _mapper.Map<tabelaContaCapitalModel>(entity);

            return Ok(results);
        }

        [HttpPost]
        public async Task<IActionResult> Post(
            [FromBody] tabelaContaCapitalModel tabelaContaCapitalModel)
        {
            var tabelacontacapital1 = _mapper.Map<tabelaContaCapital>(tabelaContaCapitalModel);

            _service.Add(tabelacontacapital1);

            if (await _service.SaveChangesAsync())
                return Created($"api/Produto/{tabelaContaCapitalModel.Id}", tabelaContaCapitalModel);

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
            [FromBody] tabelaContaCapitalModel model)
        {
            var entity = await _service.GetById(id);

            if (entity == null) return NotFound();

            _mapper.Map(model, entity);
            _service.Update(entity);

            if (await _service.SaveChangesAsync())
                return Created($"api/tabelacontacapital/{model.Id}", _mapper.Map<tabelaContaCapitalModel>(entity));

            return BadRequest();
        }
    }
}
