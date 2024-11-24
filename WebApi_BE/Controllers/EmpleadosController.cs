using BLL;
using BLL.Interfase;
using Entidades;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_BE.Controllers
{
    [Route("api/Empleados")]
    [ApiController]
    public class EmpleadosController : Controller
    {
        #region VARIABLE PRIVADA
        private readonly IEmployee_BLL _IEmployee_BLL;
        #endregion

        #region CONSTRUCTOR
        public EmpleadosController(IEmployee_BLL iEmpleados_BLL)
        {
            _IEmployee_BLL = iEmpleados_BLL;
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
        [Route(nameof(ConsultaEmployee))]
        public List<cls_Empleados> ConsultaEmployee() //Llama al método de la capa lógica para obtener la lista 
        {
            return _IEmployee_BLL.ConsultarEmpleados(new cls_Empleados()); 
        }

        //Recibe un objeto que contiene los datos que se quieren almacenar
        //Llama al método de la capa BLL para realizar la operación 
        [HttpPost]
        [Route(nameof(AlmacenaEmployee))]
        public bool AlmacenaEmployee(cls_Empleados Obj_Entidad)
        {
            return _IEmployee_BLL.AlmacenarEmpleados(Obj_Entidad);
        }
       
        //Recibe el ID como parámetro 
        //Crea un objeto con el ID y lo pasa a la capa BLL para ejecutar la eliminación
        [HttpDelete]
        [Route(nameof(EliminaEmployee))]
        public bool EliminaEmployee([FromHeader] int _iCedula)
        {          
            return _IEmployee_BLL.EliminarEmpleados(new cls_Empleados { iCedula = _iCedula });
        }
        #endregion       
        #endregion
    }
}
