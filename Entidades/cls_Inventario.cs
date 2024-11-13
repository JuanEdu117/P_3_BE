using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class cls_Inventario
    {
        #region VARIABLES PUBLICAS
        public int IdInventario { get; set; }       
        public string Descripcion { get; set; }        
        public string TipoMaquina { get; set; }       
        public float HorasActuales { get; set; }        
        public float HorasMaximas { get; set; }     
        public float HorasMantenimiento { get; set; }
        public cls_Inventario() 
        { 
            IdInventario = 0;
            Descripcion = string.Empty;
            TipoMaquina = string.Empty;
            HorasActuales = 0;
            HorasMaximas = 0;
            HorasMantenimiento = 0;
        }
        #endregion
    }
}
