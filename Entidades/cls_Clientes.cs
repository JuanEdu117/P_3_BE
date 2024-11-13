using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class cls_Clientes
    {
        #region VARIABLES PUBLICAS
        public int Identificacion { get; set; }       
        public string NombreCompleto { get; set; }        
        public string Provincia { get; set; }        
        public string Canton { get; set; }       
        public string Distrito { get; set; }      
        public string DireccionExacta { get; set; }       
        public int MantenimientoInvierno { get; set; }       
        public int MantenimientoVerano { get; set; }
        public cls_Clientes() 
        { 
            Identificacion = 0;
            NombreCompleto = string.Empty;
            Provincia = string.Empty;
            Canton = string.Empty;
            Distrito = string.Empty;
            DireccionExacta = string.Empty;
            MantenimientoInvierno = 0;
            MantenimientoVerano = 0;
        }
        #endregion
    }
}
