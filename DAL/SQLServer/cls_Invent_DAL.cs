using DAL.Interfase;
using Dapper;
using Entidades;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SQLServer
{
    public class cls_Invent_DAL : IInvent_DAL
    {
        #region VARIABLE PRIVADA
        private readonly IConfiguration _IConfiguracion;
        #endregion

        #region CONSTRUCTOR
        public cls_Invent_DAL(IConfiguration iConfig)
        {
            _IConfiguracion = iConfig;
        }
        #endregion

        #region METODOS    
        public List<cls_Inventario> ConsultarInventario(cls_Inventario Obj_Entidad)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@FILTRO", Obj_Entidad.IdInventario, DbType.Int32, ParameterDirection.Input);

            using (var CNXSQL = new SqlConnection(_IConfiguracion.GetConnectionString("ConexionSQLServer")))
            {
                return (List<cls_Inventario>)CNXSQL.Query<cls_Inventario>("dbo.Sp_ConsultarInventario", parametros, commandType: CommandType.StoredProcedure);
            }
        }
        public bool AlmacenarInventario(cls_Inventario Obj_Entidad)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@invent_id", Obj_Entidad.IdInventario, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@descrip", Obj_Entidad.Descripcion, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@maquina", Obj_Entidad.TipoMaquina, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@h_actual", Obj_Entidad.HorasActuales, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@h_max", Obj_Entidad.HorasMaximas, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@h_mante", Obj_Entidad.HorasMantenimiento, DbType.Decimal, ParameterDirection.Input);

            using (var CNXSQL = new SqlConnection(_IConfiguracion.GetConnectionString("ConexionSQLServer")))
            {
                return CNXSQL.Execute("dbo.Sp_AlmacenarInventario", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }
        public bool EliminarInventario(cls_Inventario Obj_Entidad)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@invent_id", Obj_Entidad.IdInventario, DbType.Int32, ParameterDirection.Input);

            using (var CNXSQL = new SqlConnection(_IConfiguracion.GetConnectionString("ConexionSQLServer")))
            {
                return CNXSQL.Execute("dbo.Sp_EliminarInventario", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }
        #endregion      
    }
}
