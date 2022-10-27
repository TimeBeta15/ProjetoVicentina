using AutoMapper;
using domain.Entity;
using domain.Model;
using domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class TabelaEmendaImpositivaController : ControllerBase
    {
        public IBaseService<tabelaEmendaImpositiva> Service { get; }
        public IMapper Mapper { get; }
        public TabelaEmendaImpositivaController(IBaseService<tabelaEmendaImpositiva> service, IMapper mapper)
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
                var results = this.Mapper.Map<tabelaEmendaImpositivaModel[]>(entity);
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
            var results = this.Mapper.Map<tabelaEmendaImpositivaModel>(entity);
            return Ok(results);
        }

        [HttpPost]
        public async Task<IActionResult> Post(tabelaEmendaImpositivaModel tabelaEmendaImpositivaModel)
        {
            var tabelaemendaimpositiva1 = this.Mapper.Map<tabelaEmendaImpositiva>(tabelaEmendaImpositivaModel);

            this.Service.Add(tabelaemendaimpositiva1);

            if (await this.Service.SaveChangesAsync())
                return Created($"api/Produto/{tabelaEmendaImpositivaModel.id}", tabelaEmendaImpositivaModel);
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
        public async Task<IActionResult> Put(string Id, tabelaEmendaImpositivaModel model)
        {
            var entity = await this.Service.GetById(Id);

            if (entity == null) return NotFound();
            this.Mapper.Map(model, entity);
            this.Service.Update(entity);

            if (await this.Service.SaveChangesAsync())

                return Created($"api/tabelaemendaimpositiva/{model.id}", this.Mapper.Map<tabelaEmendaImpositivaModel>(entity));
            return BadRequest();
        }
    }
}

