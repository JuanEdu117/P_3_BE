using BLL;
using Entidades;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_BE.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductController : Controller
    {
        #region VARIABLE PRIVADA
        //private cls_product_BLL Obj_Product_BLL = new cls_product_BLL();
        #endregion

        #region EVENTO DE APERTURA VIEW
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region MÉTODOS

        #region SQLSERVER

        #endregion

        #region PROYECT #2
        /*
        // GET: api/values
        [HttpGet]
        [Route(nameof(ListarProduct))] //BORRAR ROUTE DE SER NECESARIO
        public ActionResult<List<cls_product>> ListarProduct() //Get()
        {
            return Obj_Product_BLL.GetAllValues();
        }

        // GET: api/values/5
        [HttpGet("{id}")]
        [Route(nameof(FiltrarProduct))]
        public ActionResult<cls_product> FiltrarProduct(int id)
        {
            var value = Obj_Product_BLL.GetValueById(id);
            if (value == null)
            {
                return NotFound();
            }
            return value;
            
        }

        [HttpGet]
        [Route(nameof(ConsultarProduct))]
        public List<cls_product> ConsultarProduct([FromHeader] int id) 
        {
            return Obj_Product_BLL.ConsultaFiltrada(new cls_product
                {
                    iId = id
                });
        }

        // POST: api/values
        [HttpPost]
        [Route(nameof(AgregarProduct))]
        public ActionResult AgregarProduct([FromBody] cls_product Obj_Product)
        {
            Obj_Product_BLL.AddValue(Obj_Product);
            return CreatedAtAction(nameof(FiltrarProduct), new { id = Obj_Product.iId }, Obj_Product); //nameof(Get())
        }

        // PUT: api/values/5
        [HttpPut("{id}")]
        [Route(nameof(ModificarProduct))]
        public IActionResult ModificarProduct([FromHeader]int id, [FromBody] cls_product Obj_Product)
        {
            if (Obj_Product.iId != id)
            {
                return BadRequest();
            }
            var existingValue = Obj_Product_BLL.GetValueById(id);
            if (existingValue == null)
            {
                return NotFound();
            }
            Obj_Product_BLL.UpdateValue(Obj_Product);
            return NoContent();
        }

        // DELETE: api/values/5
        [HttpDelete("{id}")]
        [Route(nameof(EliminarProduct))]
        public IActionResult EliminarProduct([FromHeader] int id)
        {
            var value = Obj_Product_BLL.GetValueById(id);
            if (value == null)
            {
                return NotFound();
            }
            Obj_Product_BLL.DeleteValue(id);
            return NoContent();
        }
        */
        #endregion

        #endregion
    }



}
