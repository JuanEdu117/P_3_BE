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
        List<cls_Empleados> ConsultarEmpleados(cls_Empleados Obj_Entidad); //Método para consultar en la base de datos
        bool AlmacenarEmpleados(cls_Empleados Obj_Entidad); //Método para almacenar en la base de datos
        bool EliminarEmpleados(cls_Empleados Obj_Entidad); //Método para eliminar en la base de datos
    }
}
