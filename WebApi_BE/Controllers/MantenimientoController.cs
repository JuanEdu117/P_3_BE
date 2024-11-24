using BLL;
using BLL.Interfase;
using Entidades;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_BE.Controllers
{
    [Route("api/Mantenimiento")]
    [ApiController]
    public class MantenimientoController : Controller
    {
        #region VARIABLE PRIVADA
        private readonly IMaintenance_BLL _IMaintenance_BLL;
        #endregion

        #region CONTRUCTOR
        public MantenimientoController(IMaintenance_BLL iMante_BLL)
        {
            _IMaintenance_BLL = iMante_BLL;
        }
        #endregion

        #region EVENTOS APERTURA VIEW
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region MÉTODOS

        #region SQLSERVER
        [HttpGet]
        [Route(nameof(ConsultaMaintenance))] 
        public List<cls_Mantenimiento> ConsultaMaintenance() //Llama al método de la capa lógica para obtener la lista 
        {
            return _IMaintenance_BLL.ConsultarMante(new cls_Mantenimiento());
        }

        //Recibe un objeto que contiene los datos que se quieren almacenar
        //Llama al método de la capa BLL para realizar la operación 
        [HttpPost]
        [Route(nameof(AlmacenaMaintenance))]
        public bool AlmacenaMaintenance(cls_Mantenimiento Obj_Entidad)
        {
            return _IMaintenance_BLL.AlmacenarMante(Obj_Entidad);
        }

        //Recibe el ID como parámetro 
        //Crea un objeto con el ID y lo pasa a la capa BLL para ejecutar la eliminación
        [HttpDelete]
        [Route(nameof(EliminaMaintenance))]
        public bool EliminaMaintenance([FromHeader] int _iIdMante)
        {
            return _IMaintenance_BLL.EliminarMante(new cls_Mantenimiento { IdMantenimiento = _iIdMante });
        }
        #endregion

        #region PROYECT#2
        // GET: api/values
        /*
        [HttpGet]
        [Route(nameof(ListarMantenimiento))] //BORRAR ROUTE DE SER NECESARIO
        public ActionResult<List<cls_Mantenimiento>> ListarMantenimiento() //Get()
        {
            return Obj_Mantenimiento_BLL.GetAllValues();
        }

        // GET: api/values/5
        [HttpGet("{id}")]
        [Route(nameof(FiltrarMantenimiento))]
        public ActionResult<cls_Mantenimiento> FiltrarMantenimiento(int id)
        {
            var value = Obj_Mantenimiento_BLL.GetValueById(id);
            if (value == null)
            {
                return NotFound();
            }
            return value;

        }

        [HttpGet]
        [Route(nameof(ConsultarMantenimiento))]
        public List<cls_Mantenimiento> ConsultarMantenimiento([FromHeader] int id)
        {
            return Obj_Mantenimiento_BLL.ConsultaFiltrada(new cls_Mantenimiento
            {
                IdMantenimiento = id
            });
        }

        // POST: api/values
        [HttpPost]
        [Route(nameof(AgregarMantenimiento))]
        public ActionResult AgregarMantenimiento([FromBody] cls_Mantenimiento P_Entidad)
        {
            Obj_Mantenimiento_BLL.AddValue(P_Entidad);
            return CreatedAtAction(nameof(FiltrarMantenimiento), new { id = P_Entidad.IdMantenimiento }, P_Entidad); //nameof(Get())
        }

        // PUT: api/values/5
        [HttpPut("{id}")]
        [Route(nameof(ModificarMantenimiento))]
        public IActionResult ModificarMantenimiento([FromHeader] int id, [FromBody] cls_Mantenimiento P_Entidad)
        {
            if (P_Entidad.IdMantenimiento != id)
            {
                return BadRequest();
            }
            var existingValue = Obj_Mantenimiento_BLL.GetValueById(id);
            if (existingValue == null)
            {
                return NotFound();
            }
            Obj_Mantenimiento_BLL.UpdateValue(P_Entidad);
            return NoContent();
        }

        // DELETE: api/values/5
        [HttpDelete("{id}")]
        [Route(nameof(EliminarMantenimiento))]
        public IActionResult EliminarMantenimiento([FromHeader] int id)
        {
            var value = Obj_Mantenimiento_BLL.GetValueById(id);
            if (value == null)
            {
                return NotFound();
            }
            Obj_Mantenimiento_BLL.DeleteValue(id);
            return NoContent();
        }
        */
        #endregion

        #endregion
    }
}
