using AutoMapper;
using domain.Entity;
using domain.Model;
using domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class TabelaContaCapitalController : ControllerBase
    {
        public IBaseService<tabelaContaCapital> Service { get; }
        public IMapper Mapper { get; }
        public TabelaContaCapitalController(IBaseService<tabelaContaCapital> service, IMapper mapper)
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
                var results = this.Mapper.Map<tabelaContaCapitalModel[]>(entity);
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
            var results = this.Mapper.Map<tabelaContaCapitalModel>(entity);
            return Ok(results);
        }

        [HttpPost]
        public async Task<IActionResult> Post(tabelaContaCapitalModel tabelaContaCapitalModel)
        {
            var tabelacontacapital1 = this.Mapper.Map<tabelaContaCapital>(tabelaContaCapitalModel);

            this.Service.Add(tabelacontacapital1);

            if (await this.Service.SaveChangesAsync())
                return Created($"api/Produto/{tabelaContaCapitalModel.id}", tabelaContaCapitalModel);
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
        public async Task<IActionResult> Put(string Id, tabelaContaCapitalModel model)
        {
            var entity = await this.Service.GetById(Id);

            if (entity == null) return NotFound();
            this.Mapper.Map(model, entity);
            this.Service.Update(entity);

            if (await this.Service.SaveChangesAsync())

                return Created($"api/tabelacontacapital/{model.id}", this.Mapper.Map<tabelaContaCapitalModel>(entity));
            return BadRequest();
        }
    }
}

