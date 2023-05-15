using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using ProyectoReact.Models;

namespace ProyectoReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly GyfContext _dbcontext;

        public ProductoController(GyfContext context)
        { 
         _dbcontext = context;  
        }

        [HttpGet]
        [Route("ObtenerProducto")]

        public IActionResult ObtenerProducto() {
            List<Producto> lista = _dbcontext.Productos.ToList();

            return StatusCode(StatusCodes.Status200OK, lista);
        }
    }
}
