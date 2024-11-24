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
    public class cls_Client_BLL : IClient_BLL
    {
        #region VARIABLE PRIVADA
        private readonly IClient_DAL _IClient_DAL;
        #endregion

        #region COSNTRUCTOR
        public cls_Client_BLL(IClient_DAL iCliente_DAL)
        {
            _IClient_DAL = iCliente_DAL;
        }
        #endregion
        public List<cls_Clientes> ConsultarCliente(cls_Clientes Obj_Entidad)
        {   //Llama al método de la capa de datos para obtener la información
            return _IClient_DAL.ConsultarCliente(Obj_Entidad);
        }
        public bool AlmacenarCliente(cls_Clientes Obj_Entidad)
        {   //Llama al método de la capa de datos para almacenar la información
            return _IClient_DAL.AlmacenarCliente(Obj_Entidad);
        }
        public bool EliminarCliente(cls_Clientes Obj_Entidad)
        {   //Llama al método de la capa de datos para eliminar la información
            return _IClient_DAL.EliminarCliente(Obj_Entidad);
        }
    }
}
