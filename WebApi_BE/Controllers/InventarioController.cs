using BLL;
using BLL.Interfase;
using Entidades;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_BE.Controllers
{
    [Route("api/Inventario")]
    [ApiController]
    public class InventarioController : Controller
    {
        #region VARIABLE PRIVADA
        private readonly IInvent_BLL _IInvent_BLL;
        #endregion

        #region CONSTRUCTOR
        public InventarioController(IInvent_BLL iInventario_BLL) 
        {
            _IInvent_BLL = iInventario_BLL;
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
        [Route(nameof(ConsultaInvent))]
        public List<cls_Inventario> ConsultaInvent() //Llama al método de la capa lógica para obtener la lista 
        {
            return _IInvent_BLL.ConsultarInventario(new cls_Inventario());
        }

        //Recibe un objeto que contiene los datos que se quieren almacenar
        //Llama al método de la capa BLL para realizar la operación 
        [HttpPost]
        [Route(nameof(AlmacenaInvent))]
        public bool AlmacenaInvent(cls_Inventario Obj_Entidad)
        {
            return _IInvent_BLL.AlmacenarInventario(Obj_Entidad);
        }

        //Recibe el ID como parámetro 
        //Crea un objeto con el ID y lo pasa a la capa BLL para ejecutar la eliminación
        [HttpDelete]
        [Route(nameof(EliminaInvent))]
        public bool EliminaInvent([FromHeader] int _iInventId)
        {
            return _IInvent_BLL.EliminarInventario(new cls_Inventario { IdInventario = _iInventId });
        }
        #endregion       
        #endregion
    }
}
