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
    public class cls_Employee_DAL : IEmployee_DAL
    {
        #region VARIABLE PRIVADA
        private readonly IConfiguration _IConfiguracion;
        #endregion

        #region CONSTRUCTOR
        public cls_Employee_DAL(IConfiguration iConfig)
        {
            _IConfiguracion = iConfig;
        }
        #endregion

        #region METODOS    
        public List<cls_Empleados> ConsultarEmpleados(cls_Empleados Obj_Entidad)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@FILTRO", Obj_Entidad.iCedula, DbType.Int32, ParameterDirection.Input);

            using (var CNXSQL = new SqlConnection(_IConfiguracion.GetConnectionString("ConexionSQLServer")))
            {
                return (List<cls_Empleados>)CNXSQL.Query<cls_Empleados>("dbo.Sp_ConsultarEmpleados", parametros, commandType: CommandType.StoredProcedure);
            }
        }
        public bool AlmacenarEmpleados(cls_Empleados Obj_Entidad)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@cedula_id", Obj_Entidad.iCedula, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@nomb", Obj_Entidad.sNombreCompleto, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@birth", Obj_Entidad.dtmFechaNacimiento, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@manofuerte", Obj_Entidad.sLateralidad, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@ingreso", Obj_Entidad.dtmFechaIngreso, DbType.DateTime, ParameterDirection.Input);
            parametros.Add("@salario", Obj_Entidad.fSalarioHora, DbType.Decimal, ParameterDirection.Input);

            using (var CNXSQL = new SqlConnection(_IConfiguracion.GetConnectionString("ConexionSQLServer")))
            {
                return CNXSQL.Execute("dbo.Sp_AlmacenarEmpleados", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }
        public bool EliminarEmpleados(cls_Empleados Obj_Entidad)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@cedula_id", Obj_Entidad.iCedula, DbType.Int32, ParameterDirection.Input);

            using (var CNXSQL = new SqlConnection(_IConfiguracion.GetConnectionString("ConexionSQLServer")))
            {
                return CNXSQL.Execute("dbo.Sp_EliminarEmpleados", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }
        #endregion    
    }
}
