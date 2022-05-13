using AMS_Interface_22.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AMS_Interface_22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IServiceBase<Product> service;
        public ProductController(IServiceBase<Product> service)
        {
            this.service = service;

        }

        public Task<ActionResult> GetAll()
        {
            var entity = this.service.GetAll();
            return Ok(entity);
            
        }
    }
}