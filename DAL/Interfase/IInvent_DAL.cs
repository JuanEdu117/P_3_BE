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
        List<cls_Inventario> ConsultarInventario(cls_Inventario Obj_Entidad); //Método para consultar
        bool AlmacenarInventario(cls_Inventario Obj_Entidad); //Método para almacenar en la base de datos
        bool EliminarInventario(cls_Inventario Obj_Entidad); //Método para eliminar en la base de datos
    }
}
