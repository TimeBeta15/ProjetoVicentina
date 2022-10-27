using AutoMapper;
using domain.Entity;
using domain.Model;
using domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class TabelaVerbaEstadualController : ControllerBase
    {
        public IBaseService<tabelaVerbaEstadual> Service { get; }
        public IMapper Mapper { get; }
        public TabelaVerbaEstadualController(IBaseService<tabelaVerbaEstadual> service, IMapper mapper)
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
                var results = this.Mapper.Map<tabelaVerbaEstadualModel[]>(entity);
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
            var results = this.Mapper.Map<tabelaVerbaEstadualModel>(entity);
            return Ok(results);
        }

        [HttpPost]
        public async Task<IActionResult> Post(tabelaVerbaEstadualModel tabelaVerbaEstadualModel)
        {
            var tabelaverbaestadual1 = this.Mapper.Map<tabelaVerbaEstadual>(tabelaVerbaEstadualModel);

            this.Service.Add(tabelaverbaestadual1);

            if (await this.Service.SaveChangesAsync())
                return Created($"api/Produto/{tabelaVerbaEstadualModel.id}", tabelaVerbaEstadualModel);
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
        public async Task<IActionResult> Put(string Id, tabelaVerbaEstadualModel model)
        {
            var entity = await this.Service.GetById(Id);

            if (entity == null) return NotFound();
            this.Mapper.Map(model, entity);
            this.Service.Update(entity);

            if (await this.Service.SaveChangesAsync())

                return Created($"api/tabelaverbaestadual/{model.id}", this.Mapper.Map<tabelaVerbaEstadualModel>(entity));
            return BadRequest();
        }
    }
}

