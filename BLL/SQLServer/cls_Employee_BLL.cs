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
    public class cls_Employee_BLL : IEmployee_BLL
    {
        #region VARIABLE PRIVADA
        private readonly IEmployee_DAL _IEmployee_DAL;
        #endregion

        #region COSNTRUCTOR
        public cls_Employee_BLL (IEmployee_DAL iEmpleados_DAL)
        {
            _IEmployee_DAL = iEmpleados_DAL;
        }
        #endregion

        #region METODOS
        public List<cls_Empleados> ConsultarEmpleados(cls_Empleados Obj_Entidad)
        {   //Llama al método de la capa de datos para obtener la información
            return _IEmployee_DAL.ConsultarEmpleados(Obj_Entidad);
        }
        public bool AlmacenarEmpleados(cls_Empleados Obj_Entidad)
        {   //Llama al método de la capa de datos para almacenar la información
            return _IEmployee_DAL.AlmacenarEmpleados(Obj_Entidad);
        }
        public bool EliminarEmpleados(cls_Empleados Obj_Entidad)
        {   //Llama al método de la capa de datos para eliminar la información
            return _IEmployee_DAL.EliminarEmpleados(Obj_Entidad);
        }
        #endregion
    }
}
