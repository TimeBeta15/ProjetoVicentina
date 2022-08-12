using Microsoft.AspNetCore.Mvc;
using tcc_pv_api.interfaces;

namespace tcc_pv_api.Controllers
{
     [Route("api/[controller]")]
    [ApiController]
    public class ContasreceberController : ControllerBase
    {
        public int id { get; set; }
        public Datetime data { get; set; }
        public int valor { get; set; }
    }
}