using AutoMapper;
using Domain.Entity;
using Domain.Interfaces;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TabelaVerbaMunicipalController : ControllerBase
    {
        private readonly IBaseService<tabelaVerbaMunicipal> _service;

        private readonly IMapper _mapper;

        public TabelaVerbaMunicipalController(IBaseService<tabelaVerbaMunicipal> service, IMapper mapper)
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
                var results = _mapper.Map<tabelaVerbaMunicipalModel[]>(entity);

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
            var results = _mapper.Map<tabelaVerbaMunicipalModel>(entity);

            return Ok(results);
        }

        [HttpPost]
        public async Task<IActionResult> Post(
            [FromBody] tabelaVerbaMunicipalModel tabelaVerbaMunicipalModel)
        {
            var tabelaverbamunicipal1 = _mapper.Map<tabelaVerbaMunicipal>(tabelaVerbaMunicipalModel);

            _service.Add(tabelaverbamunicipal1);

            if (await _service.SaveChangesAsync())
                return Created($"api/Produto/{tabelaVerbaMunicipalModel.Id}", tabelaVerbaMunicipalModel);

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
            [FromBody] tabelaVerbaMunicipalModel model)
        {
            var entity = await _service.GetById(id);

            if (entity == null) return NotFound();

            _mapper.Map(model, entity);
            _service.Update(entity);

            if (await _service.SaveChangesAsync())
                return Created($"api/tabelaverbamunicipal/{model.Id}", _mapper.Map<tabelaVerbaMunicipalModel>(entity));

            return BadRequest();
        }
    }
}
