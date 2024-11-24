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
    public class cls_Report_DAL : IReport_DAL
    {
        #region VARIABLE PRIVADA
        private readonly IConfiguration _IConfiguracion;
        #endregion

        #region CONSTRUCTOR
        public cls_Report_DAL(IConfiguration iConfig)
        {
            _IConfiguracion = iConfig;
        }
        #endregion
        #region METODOS
        public List<cls_Reportes> ConsultarReportes(cls_Reportes Obj_Entidad)
        {
            DynamicParameters parametros = new DynamicParameters(); //Crea un objeto para pasar el procedimiento almacenado
            parametros.Add("@FILTRO", Obj_Entidad.Id_Reporte, DbType.Int32, ParameterDirection.Input); //Agrega "@FILTRO" con el valor del ID
            //Abre una conexión SQL con la cadena de conexión 
            using (var CNXSQL = new SqlConnection(_IConfiguracion.GetConnectionString("ConexionSQLServer")))
            {   //Ejecuta el procedimiento almacenado con los parámetros
                return (List<cls_Reportes>)CNXSQL.Query<cls_Reportes>("dbo.Sp_ConsultarReportes", parametros, commandType: CommandType.StoredProcedure);
            }
        }
        public bool AlmacenarReportes(cls_Reportes Obj_Entidad)
        {
            DynamicParameters parametros = new DynamicParameters(); //Crea un objeto para pasar el procedimiento almacenado
            parametros.Add("@report_id", Obj_Entidad.Id_Reporte, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@client_id", Obj_Entidad.Id_Cliente, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@mante_id", Obj_Entidad.Id_Mantenimiento, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@nomb_client", Obj_Entidad.Nombre_Cliente, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@date_ultimo", Obj_Entidad.Fecha_Ultimo_Servicio, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@date_contact", Obj_Entidad.Proxima_Fecha_Contacto, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@date_report", Obj_Entidad.Fecha_Reporte, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@motive", Obj_Entidad.Motivo, DbType.String, ParameterDirection.Input, 50);
            //Abre una conexión SQL con la cadena de conexión   
            using (var CNXSQL = new SqlConnection(_IConfiguracion.GetConnectionString("ConexionSQLServer")))
            {   //Ejecuta el procedimiento almacenado con los parámetros
                return CNXSQL.Execute("dbo.Sp_AlmacenarReportes", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }
        public bool EliminarReportes(cls_Reportes Obj_Entidad)
        {
            DynamicParameters parametros = new DynamicParameters(); //Crea un objeto para pasar el procedimiento almacenado
            parametros.Add("@report_id", Obj_Entidad.Id_Reporte, DbType.Int32, ParameterDirection.Input);
            //Abre una conexión SQL con la cadena de conexión 
            using (var CNXSQL = new SqlConnection(_IConfiguracion.GetConnectionString("ConexionSQLServer")))
            {   //Ejecuta el procedimiento almacenado con los parámetros
                return CNXSQL.Execute("dbo.Sp_EliminarReportes", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }
        #endregion
    }
}
