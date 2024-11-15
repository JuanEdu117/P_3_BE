using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfase
{
    public interface IMaintenance_BLL
    {
        List<cls_Mantenimiento> ConsultarMante(cls_Mantenimiento Obj_Entidad);
        bool AlmacenarMante(cls_Mantenimiento Obj_Entidad);
        bool EliminarMante(cls_Mantenimiento Obj_Entidad);
    }
}
