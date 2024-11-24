using BLL;
using BLL.Interfase;
using Entidades;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_BE.Controllers
{
    [Route("api/Clientes")]
    [ApiController]
    public class ClientesController : Controller
    {
        #region VARIABLE PRIVADA       
        private readonly IClient_BLL _IClient_BLL;
        #endregion

        #region CONTRUCTOR
        public ClientesController(IClient_BLL iCliente_BLL) 
        {
            _IClient_BLL = iCliente_BLL;
        }
        #endregion

        #region EVENTOS APERTURA VIEW
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region MÉTODOS

        #region SQLSERVER
        [HttpGet]
        [Route(nameof(ConsultaClient))]
        public List<cls_Clientes> ConsultaClient() //Llama al método de la capa lógica para obtener la lista 
        {
            return _IClient_BLL.ConsultarCliente(new cls_Clientes());
        }

        //Recibe un objeto que contiene los datos que se quieren almacenar
        //Llama al método de la capa BLL para realizar la operación 
        [HttpPost]
        [Route(nameof(AlmacenaClient))]
        public bool AlmacenaClient(cls_Clientes Obj_Entidad)
        {
            return _IClient_BLL.AlmacenarCliente(Obj_Entidad);
        }

        //Recibe el ID como parámetro 
        //Crea un objeto con el ID y lo pasa a la capa BLL para ejecutar la eliminación
        [HttpDelete]
        [Route(nameof(EliminaClient))]
        public bool EliminaClient([FromHeader] int _iIdentify)
        {
            return _IClient_BLL.EliminarCliente(new cls_Clientes { Identificacion = _iIdentify });
        }
        #endregion

        #region PROYECT #2
        // GET: api/values
        /*
        [HttpGet]
        [Route(nameof(ListarClientes))] //BORRAR ROUTE DE SER NECESARIO
        public ActionResult<List<cls_Clientes>> ListarClientes() //Get()
        {
            return Obj_Clientes_BLL.GetAllValues();
        }

        // GET: api/values/5
        [HttpGet("{id}")]
        [Route(nameof(FiltrarClientes))]
        public ActionResult<cls_Clientes> FiltrarClientes(int id)
        {
            var value = Obj_Clientes_BLL.GetValueById(id);
            if (value == null)
            {
                return NotFound();
            }
            return value;

        }

        [HttpGet]
        [Route(nameof(ConsultarClientes))]
        public List<cls_Clientes> ConsultarClientes([FromHeader] int id)
        {
            return Obj_Clientes_BLL.ConsultaFiltrada(new cls_Clientes
            {
                Identificacion = id
            });
        }

        // POST: api/values
        [HttpPost]
        [Route(nameof(AgregarClientes))]
        public ActionResult AgregarClientes([FromBody] cls_Clientes P_Entidad)
        {
            Obj_Clientes_BLL.AddValue(P_Entidad);
            return CreatedAtAction(nameof(FiltrarClientes), new { id = P_Entidad.Identificacion }, P_Entidad); //nameof(Get())
        }

        // PUT: api/values/5
        [HttpPut("{id}")]
        [Route(nameof(ModificarClientes))]
        public IActionResult ModificarClientes([FromHeader] int id, [FromBody] cls_Clientes P_Entidad)
        {
            if (P_Entidad.Identificacion != id)
            {
                return BadRequest();
            }
            var existingValue = Obj_Clientes_BLL.GetValueById(id);
            if (existingValue == null)
            {
                return NotFound();
            }
            Obj_Clientes_BLL.UpdateValue(P_Entidad);
            return NoContent();
        }

        // DELETE: api/values/5
        [HttpDelete("{id}")]
        [Route(nameof(EliminarClientes))]
        public IActionResult EliminarClientes([FromHeader] int id)
        {
            var value = Obj_Clientes_BLL.GetValueById(id);
            if (value == null)
            {
                return NotFound();
            }
            Obj_Clientes_BLL.DeleteValue(id);
            return NoContent();
        } */
        #endregion

        #endregion
    }
}
