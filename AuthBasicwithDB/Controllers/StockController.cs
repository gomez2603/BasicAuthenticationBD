using AuthBasicwithDB.Models;
using AuthBasicwithDB.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthBasicwithDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stockService;
        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_stockService.Get());
        }
        [HttpPost]
        public IActionResult Post([FromBody] Stock stock)
        {
            if (ModelState.IsValid)
            {
                
                _stockService.Insert(stock);
                return Ok("Se Agrego el Producto al Inventario");
            }
            else
            {
                return BadRequest("Formato Invalido");
            }
        }
    }
}
