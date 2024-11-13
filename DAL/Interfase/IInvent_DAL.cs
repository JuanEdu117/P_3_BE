using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfase
{
    public interface IInvent_DAL
    {
        List<cls_Inventario> ConsultarInventario(cls_Inventario Obj_Entidad);
        bool AlmacenarInventario(cls_Inventario Obj_Entidad);
        bool EliminarInventario(cls_Inventario Obj_Entidad);
    }
}
