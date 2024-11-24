using BLL.Interfase;
using DAL.Interfase;
using DAL.SQLServer;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SQLServer
{
    public class cls_Invent_BLL : IInvent_BLL
    {
        #region VARIABLE PRIVADA
        private readonly IInvent_DAL _IInvent_DAL;
        #endregion

        #region COSNTRUCTOR
        public cls_Invent_BLL(IInvent_DAL iInventario_DAL) 
        {
            _IInvent_DAL = iInventario_DAL;
        }
        #endregion

        #region METODOS
        public List<cls_Inventario> ConsultarInventario(cls_Inventario Obj_Entidad)
        {   //Llama al método de la capa de datos para obtener la información
            return _IInvent_DAL.ConsultarInventario(Obj_Entidad);
        }
        public bool AlmacenarInventario(cls_Inventario Obj_Entidad)
        {   //Llama al método de la capa de datos para almacenar la información
            return _IInvent_DAL.AlmacenarInventario(Obj_Entidad);
        }
        public bool EliminarInventario(cls_Inventario Obj_Entidad)
        {   //Llama al método de la capa de datos para eliminar la información
            return _IInvent_DAL.EliminarInventario(Obj_Entidad);
        }
        #endregion
    }
}
