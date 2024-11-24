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
    public class cls_Maintenance_DAL : IMaintenance_DAL
    {
        #region VARIABLE PRIVADA
        private readonly IConfiguration _IConfiguracion;
        #endregion

        #region CONSTRUCTOR
        public cls_Maintenance_DAL (IConfiguration iConfig)
        {
            _IConfiguracion = iConfig;
        }
        #endregion

        #region METODOS
        public List<cls_Mantenimiento> ConsultarMante(cls_Mantenimiento Obj_Entidad)
        {
            DynamicParameters parametros = new DynamicParameters(); //Crea un objeto para pasar el procedimiento almacenado
            parametros.Add("@FILTRO", Obj_Entidad.IdMantenimiento, DbType.Int32, ParameterDirection.Input); //Agrega "@FILTRO" con el valor del ID
            //Abre una conexión SQL con la cadena de conexión 
            using (var CNXSQL = new SqlConnection(_IConfiguracion.GetConnectionString("ConexionSQLServer")))
            {   //Ejecuta el procedimiento almacenado con los parámetros
                return (List<cls_Mantenimiento>)CNXSQL.Query<cls_Mantenimiento>("dbo.Sp_ConsultarMante", parametros, commandType: CommandType.StoredProcedure);
            }
        }
        public bool AlmacenarMante(cls_Mantenimiento Obj_Entidad)
        {
            DynamicParameters parametros = new DynamicParameters(); //Crea un objeto para pasar el procedimiento almacenado
            parametros.Add("@mante_id", Obj_Entidad.IdMantenimiento, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@client_id", Obj_Entidad.IdCliente, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@dateEject", Obj_Entidad.FechaEjecutado, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@dateAgenda", Obj_Entidad.FechaAgendado, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@mPropiedad", Obj_Entidad.MetrosPropiedad, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@mCercaViva", Obj_Entidad.MetrosCercaViva, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@daySinChapia", Obj_Entidad.DiasSinChapia, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@dateOtraChapia", Obj_Entidad.FechaOtraChapia, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@Zacate", Obj_Entidad.TipoZacate, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@aplicProduct", Obj_Entidad.AplicacionProducto, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@product", Obj_Entidad.ProductoAplicado, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@costChapia", Obj_Entidad.CostoChapia, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@costAplicProduct", Obj_Entidad.CostoAplicacionProducto, DbType.Decimal, ParameterDirection.Input);
            parametros.Add("@estadoMante", Obj_Entidad.EstadoMantenimiento, DbType.String, ParameterDirection.Input, 50);
            //Crea una excepción para que no se cree un mantenimiento sin cliente
            try
            {   //Abre una conexión SQL con la cadena de conexión 
                using (var CNXSQL = new SqlConnection(_IConfiguracion.GetConnectionString("ConexionSQLServer")))
                {   //Ejecuta el procedimiento almacenado con los parámetros
                    return CNXSQL.Execute("dbo.Sp_AlmacenarMante", parametros, commandType: CommandType.StoredProcedure) > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }         
        }
        public bool EliminarMante(cls_Mantenimiento Obj_Entidad)
        {
            DynamicParameters parametros = new DynamicParameters(); //Crea un objeto para pasar el procedimiento almacenado
            parametros.Add("@mante_id", Obj_Entidad.IdMantenimiento, DbType.Int32, ParameterDirection.Input); //Agrega el parámetro con el ID que se desea eliminar
            //Crea una excepción para que no se cree un mantenimiento sin cliente
            try
            {   //Abre una conexión SQL con la cadena de conexión 
                using (var CNXSQL = new SqlConnection(_IConfiguracion.GetConnectionString("ConexionSQLServer")))
                {   //Ejecuta el procedimiento almacenado con los parámetros
                    return CNXSQL.Execute("dbo.Sp_EliminarMante", parametros, commandType: CommandType.StoredProcedure) > 0;
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
