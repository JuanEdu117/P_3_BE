using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfase
{
    public interface IReport_DAL
    {
        List<cls_Reportes> ConsultarReportes(cls_Reportes Obj_Entidad); //Método para consultar
        bool AlmacenarReportes(cls_Reportes Obj_Entidad); //Método para almacenar en la base de datos
        bool EliminarReportes(cls_Reportes Obj_Entidad); //Método para eliminar en la base de datos
    }
}
