using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfase
{
    public interface IMaintenance_DAL
    {
        List<cls_Mantenimiento> ConsultarMante(cls_Mantenimiento Obj_Entidad);
        bool AlmacenarMante(cls_Mantenimiento Obj_Entidad);
        bool EliminarMante(cls_Mantenimiento Obj_Entidad);
    }
}
