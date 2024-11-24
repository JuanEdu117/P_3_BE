using BLL.Interfase;
using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_BE.Controllers
{
    [Route("api/Reportes")]
    [ApiController]
    public class ReportesController : Controller
    {
        #region VARIABLE PRIVADA
        private readonly IReport_BLL _IReport_BLL;
        #endregion

        #region CONTRUCTOR
        public ReportesController(IReport_BLL iReportes_BLL)
        {
            _IReport_BLL = iReportes_BLL;
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
        [Route(nameof(ConsultaReport))]
        public List<cls_Reportes> ConsultaReport() //Llama al método de la capa lógica para obtener la lista 
        {
            return _IReport_BLL.ConsultarReportes(new cls_Reportes());
        }

        //Recibe un objeto que contiene los datos que se quieren almacenar
        //Llama al método de la capa BLL para realizar la operación 
        [HttpPost]
        [Route(nameof(AlmacenaReport))]
        public bool AlmacenaReport(cls_Reportes Obj_Entidad)
        {
            return _IReport_BLL.AlmacenarReportes(Obj_Entidad);
        }

        //Recibe el ID como parámetro 
        //Crea un objeto con el ID y lo pasa a la capa BLL para ejecutar la eliminación
        [HttpDelete]
        [Route(nameof(EliminaReport))]
        public bool EliminaReport([FromHeader] int _iIdReporte)
        {
            return _IReport_BLL.EliminarReportes(new cls_Reportes { Id_Reporte = _iIdReporte });
        }
        #endregion
        #endregion
    }
}
