using AutoMapper;
using domain.Entity;
using domain.Model;
using domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    public class TabelaQuartoController : ControllerBase
    {
        public IBaseService<tabelaQuarto> Service { get; }

        public IMapper Mapper { get; }

        public TabelaQuartoController(IBaseService<tabelaQuarto> service, IMapper mapper)
        {
            this.Mapper = mapper;
            this.Service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var entity = await this.Service.GetAll();
                var results = this.Mapper.Map<tabelaQuartoModel[]>(entity);
                return Ok(results);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(string Id)
        {
            var entity = await this.Service.GetById(Id);
            var results = this.Mapper.Map<tabelaQuartoModel>(entity);
            return Ok(results);
        }

        [HttpPost]
        public async Task<IActionResult> Post(tabelaQuartoModel tabelaQuartoModel)
        {
            var tabelaquarto1 = this.Mapper.Map<tabelaQuarto>(tabelaQuartoModel);

            this.Service.Add(tabelaquarto1);

            if (await this.Service.SaveChangesAsync())
                return Created($"api/Produto/{tabelaQuartoModel.Id}", tabelaQuartoModel);
            return BadRequest();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(string Id)
        {
            var entity = await this.Service.GetById(Id);

            if (entity == null) return NotFound();
            this.Service.Delete(entity);

            if (await this.Service.SaveChangesAsync()) return Ok();
            return BadRequest();
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Put(string Id, tabelaQuartoModel model)
        {
            var entity = await this.Service.GetById(Id);

            if (entity == null) return NotFound();
            this.Mapper.Map(model, entity);
            this.Service.Update(entity);

            if (await this.Service.SaveChangesAsync())
            return Created($"api/tabelaquarto/{model.Id}", this.Mapper.Map<tabelaQuartoModel>(entity));
            return BadRequest();
        }
    }
}
