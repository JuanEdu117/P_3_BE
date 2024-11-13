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
        List<cls_Clientes> ConsultarCliente(cls_Clientes Obj_Entidad);
        bool AlmacenarCliente(cls_Clientes Obj_Entidad);
        bool EliminarCliente(cls_Clientes Obj_Entidad);
    }
}
