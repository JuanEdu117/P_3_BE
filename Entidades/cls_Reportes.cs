using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class cls_Reportes
    {
        #region VARIABLES PUBLICAS
        public int Id_Reporte { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Mantenimiento { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaUltimoServicio { get; set; }
        public DateTime FechaProximoContacto { get; set; }
        public DateTime FechaReporte { get; set; }
        public string Motivo { get; set; }
        public cls_Reportes() 
        { 
            Id_Reporte = 0;
            Id_Cliente = 0;
            Id_Mantenimiento = 0;
            NombreCliente = string.Empty;
            FechaUltimoServicio = DateTime.MinValue;
            FechaProximoContacto = DateTime.MinValue;
            FechaReporte = DateTime.MinValue;
            Motivo = string.Empty;
        }
        #endregion
    }
}
