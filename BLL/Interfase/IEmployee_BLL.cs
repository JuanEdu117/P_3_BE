using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfase
{
    public interface IEmployee_BLL
    {
        List<cls_Empleados> ConsultarEmpleados(cls_Empleados Obj_Entidad);
        bool AlmacenarEmpleados(cls_Empleados Obj_Entidad);
        bool EliminarEmpleados(cls_Empleados Obj_Entidad);
    }
}
