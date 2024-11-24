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
    public class cls_Maintenance_BLL : IMaintenance_BLL
    {
        #region VARIABLE PRIVADA
        private readonly IMaintenance_DAL _IMaintenance_DAL;
        #endregion

        #region COSNTRUCTOR
        public cls_Maintenance_BLL(IMaintenance_DAL iMaintenance_DAL)
        {
            _IMaintenance_DAL = iMaintenance_DAL;
        }
        #endregion
        public List<cls_Mantenimiento> ConsultarMante(cls_Mantenimiento Obj_Entidad)
        {   //Llama al método de la capa de datos para obtener la información
            return _IMaintenance_DAL.ConsultarMante(Obj_Entidad);
        }
        public bool AlmacenarMante(cls_Mantenimiento Obj_Entidad)
        {   //Llama al método de la capa de datos para almacenar la información
            return _IMaintenance_DAL.AlmacenarMante(Obj_Entidad);
        }
        public bool EliminarMante(cls_Mantenimiento Obj_Entidad)
        {   //Llama al método de la capa de datos para eliminar la información
            return _IMaintenance_DAL.EliminarMante(Obj_Entidad);
        }
    }
}
