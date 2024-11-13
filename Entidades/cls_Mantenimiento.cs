using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class cls_Mantenimiento
    {
        #region VARIABLES PUBLICAS
        public int IdMantenimiento { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaEjecutado { get; set; }
        public DateTime FechaAgendado { get; set; }
        public float MetrosPropiedad { get; set; }
        public float MetrosCercaViva { get; set; }
        public string DiasSinChapia { get; set; }
        public string FechaOtraChapia { get; set; }
        public string TipoZacate { get; set; }
        public string AplicacionProducto { get; set; }
        public string ProductoAplicado { get; set; }
        public float CostoChapia { get; set; }
        public float CostoAplicacionProducto { get; set; }
        public string EstadoMantenimiento { get; set; }
        public cls_Mantenimiento() 
        {
            IdMantenimiento = 0;
            IdCliente = 0;
            FechaEjecutado = DateTime.MinValue;
            FechaAgendado = DateTime.MinValue;
            MetrosPropiedad = 0;
            MetrosCercaViva = 0;
            DiasSinChapia = string.Empty;
            FechaOtraChapia = string.Empty;
            TipoZacate = string.Empty;
            AplicacionProducto = string.Empty;
            ProductoAplicado = string.Empty;
            CostoChapia = 0;
            CostoAplicacionProducto = 0;
            EstadoMantenimiento = string.Empty;
        }
        #endregion
    }
}
