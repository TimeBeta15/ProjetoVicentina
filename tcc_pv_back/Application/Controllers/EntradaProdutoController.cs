using AutoMapper;
using Domain.Entity;
using Domain.Interfaces;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradaProdutoController : ControllerBase
    {
        private readonly IBaseService<entradaProduto> _service;

        private readonly IMapper _mapper;

        public EntradaProdutoController(IBaseService<entradaProduto> service, IMapper mapper)
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
                var results = _mapper.Map<entradaProdutoModel[]>(entity);

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
            var results = _mapper.Map<entradaProdutoModel>(entity);

            return Ok(results);
        }

        [HttpPost]
        public async Task<IActionResult> Post(
            [FromBody] entradaProdutoModel entradaprodutoModel)
        {
            var entradaprod1 = _mapper.Map<entradaProduto>(entradaprodutoModel);

            _service.Add(entradaprod1);

            if (await _service.SaveChangesAsync())
                return Created($"api/Produto/{entradaprodutoModel.Id}", entradaprodutoModel);

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
            [FromBody] entradaProdutoModel model)
        {
            var entity = await _service.GetById(id);

            if (entity == null) return NotFound();

            _mapper.Map(model, entity);
            _service.Update(entity);

            if (await _service.SaveChangesAsync())
                return Created($"api/entradaproduto/{model.Id}", _mapper.Map<entradaProdutoModel>(entity));

            return BadRequest();
        }
    }
}
