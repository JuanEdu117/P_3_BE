using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfase
{
    public interface IReport_BLL
    {
        List<cls_Reportes> ConsultarReportes(cls_Reportes Obj_Entidad);
        bool AlmacenarReportes(cls_Reportes Obj_Entidad);
        bool EliminarReportes(cls_Reportes Obj_Entidad);
    }
}
