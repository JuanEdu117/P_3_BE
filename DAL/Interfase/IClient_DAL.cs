using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfase
{
    public interface IClient_DAL
    {
        List<cls_Clientes> ConsultarCliente(cls_Clientes Obj_Entidad); //Método para consultar
        bool AlmacenarCliente(cls_Clientes Obj_Entidad); //Método para almacenar en la base de datos
        bool EliminarCliente(cls_Clientes Obj_Entidad); //Método para eliminar en la base de datos
    }
}
