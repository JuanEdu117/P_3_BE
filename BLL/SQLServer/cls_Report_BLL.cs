using BLL.Interfase;
using DAL.Interfase;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SQLServer
{
    public class cls_Report_BLL : IReport_BLL
    {
        #region VARIABLE PRIVADA
        private readonly IReport_DAL _IReport_DAL;
        #endregion

        #region COSNTRUCTOR
        public cls_Report_BLL (IReport_DAL iReport_DAL)
        {
            _IReport_DAL = iReport_DAL;
        }
        #endregion
        public List<cls_Reportes> ConsultarReportes(cls_Reportes Obj_Entidad)
        {
            return _IReport_DAL.ConsultarReportes(Obj_Entidad);
        }
        public bool AlmacenarReportes(cls_Reportes Obj_Entidad)
        {
            return _IReport_DAL.AlmacenarReportes(Obj_Entidad);
        }
        public bool EliminarReportes(cls_Reportes Obj_Entidad)
        {
            return _IReport_DAL.EliminarReportes(Obj_Entidad);
        }
    }
}
