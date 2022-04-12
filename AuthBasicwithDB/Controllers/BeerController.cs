using AuthBasicwithDB.Models;
using AuthBasicwithDB.Security;
using AuthBasicwithDB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthBasicwithDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
   
  
    public class BeerController : ControllerBase
    {
        private readonly IBeerServices _beerServices;
    
           
        public BeerController(IBeerServices beerServices)
        {
            _beerServices = beerServices;
      


        }


        [HttpGet]
        public IActionResult Get()
        {
         return   Ok(_beerServices.Get());
        }
        [HttpGet("{id}")]
        public IActionResult  Get(int id)
        {
            return Ok(_beerServices.GetbyId(id));
        }
        [HttpPost]
        public IActionResult Post([FromBody] Beer beer)
        {
            if (ModelState.IsValid)
            {
                _beerServices.Insert(beer);
                return Ok("Se Creo la Cerveza");
            }
            else
            {
                return BadRequest("Formato Invalido");
            }
        }
        [HttpPut]
        public IActionResult Put(Beer beer)
        {
            if (ModelState.IsValid)
            {
                _beerServices.Update(beer);
                return Ok("Se Actualizo la Cerveza");
            }
            return BadRequest("No existe el Registro a Editar");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
                _beerServices.Delete(id);
                return Ok("Se Elimino Correctamete");
        }






    }
}
