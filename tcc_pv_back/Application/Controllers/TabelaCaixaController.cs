using AutoMapper;
using domain.Entity;
using domain.Model;
using domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class TabelaCaixaController : ControllerBase
    {
        public IBaseService<tabelaCaixa> Service { get; }
        public IMapper Mapper { get; }
        public TabelaCaixaController(IBaseService<tabelaCaixa> service, IMapper mapper)
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
                var results = this.Mapper.Map<tabelaCaixaModel[]>(entity);
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
            var results = this.Mapper.Map<tabelaCaixaModel>(entity);
            return Ok(results);
        }

        [HttpPost]
        public async Task<IActionResult> Post(tabelaCaixaModel tabelaCaixaModel)
        {
            var tabelacaixa1 = this.Mapper.Map<tabelaCaixa>(tabelaCaixaModel);

            this.Service.Add(tabelacaixa1);

            if (await this.Service.SaveChangesAsync())
                return Created($"api/Produto/{tabelaCaixaModel.id}", tabelaCaixaModel);
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
        public async Task<IActionResult> Put(string Id, tabelaCaixaModel model)
        {
            var entity = await this.Service.GetById(Id);

            if (entity == null) return NotFound();
            this.Mapper.Map(model, entity);
            this.Service.Update(entity);

            if (await this.Service.SaveChangesAsync())

                return Created($"api/tabelacaixa/{model.id}", this.Mapper.Map<tabelaCaixaModel>(entity));
            return BadRequest();
        }
    }
}

