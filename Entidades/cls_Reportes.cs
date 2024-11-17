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
        public string Nombre_Cliente { get; set; }
        public DateTime Fecha_Ultimo_Servicio { get; set; }
        public DateTime Proxima_Fecha_Contacto { get; set; }
        public DateTime Fecha_Reporte { get; set; }
        public string Motivo { get; set; }
        public cls_Reportes() 
        { 
            Id_Reporte = 0;
            Id_Cliente = 0;
            Id_Mantenimiento = 0;
            Nombre_Cliente = string.Empty;
            Fecha_Ultimo_Servicio = DateTime.MinValue;
            Proxima_Fecha_Contacto = DateTime.MinValue;
            Fecha_Reporte = DateTime.MinValue;
            Motivo = string.Empty;
        }
        #endregion
    }
}
