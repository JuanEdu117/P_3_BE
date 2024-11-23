using DAL.Interfase;
using Dapper;
using Entidades;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SQLServer
{
    public class cls_Client_DAL : IClient_DAL
    {
        #region VARIABLE PRIVADA
        private readonly IConfiguration _IConfiguracion;
        #endregion

        #region CONSTRUCTOR
        public cls_Client_DAL(IConfiguration iConfig)
        {
            _IConfiguracion = iConfig;
        }
        #endregion

        #region METODOS
        public List<cls_Clientes> ConsultarCliente(cls_Clientes Obj_Entidad)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@FILTRO", Obj_Entidad.Identificacion, DbType.Int32, ParameterDirection.Input);

            using (var CNXSQL = new SqlConnection(_IConfiguracion.GetConnectionString("ConexionSQLServer")))
            {
                return (List<cls_Clientes>)CNXSQL.Query<cls_Clientes>("dbo.Sp_ConsultarClientes", parametros, commandType: CommandType.StoredProcedure);
            }
        }
        public bool AlmacenarCliente(cls_Clientes Obj_Entidad)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@client_id", Obj_Entidad.Identificacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@nomb", Obj_Entidad.NombreCompleto, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@provin", Obj_Entidad.Provincia, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@cant", Obj_Entidad.Canton, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@district", Obj_Entidad.Distrito, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@direx", Obj_Entidad.DireccionExacta, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@mante_invi", Obj_Entidad.MantenimientoInvierno, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mante_vera", Obj_Entidad.MantenimientoVerano, DbType.Int32, ParameterDirection.Input);

            try
            {
                using (var CNXSQL = new SqlConnection(_IConfiguracion.GetConnectionString("ConexionSQLServer")))
                {
                    return CNXSQL.Execute("dbo.Sp_AlmacenarClientes", parametros, commandType: CommandType.StoredProcedure) > 0;
                }
            }
            catch (Exception ex)
            {                            
                return false; 
            }
        }
        public bool EliminarCliente(cls_Clientes Obj_Entidad)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@client_id", Obj_Entidad.Identificacion, DbType.Int32, ParameterDirection.Input);

            try
            {
                using (var CNXSQL = new SqlConnection(_IConfiguracion.GetConnectionString("ConexionSQLServer")))
                {
                    return CNXSQL.Execute("dbo.Sp_EliminarClientes", parametros, commandType: CommandType.StoredProcedure) > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }     
        }
        #endregion
    }
}
