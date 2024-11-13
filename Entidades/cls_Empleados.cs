using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class cls_Empleados
    { 
        #region VARIABLES PUBLICAS
        public int iCedula { get; set; }
        public string sNombreCompleto{ get; set; }
        public DateTime dtmFechaNacimiento { get; set; }
        public string sLateralidad { get; set; }
        public DateTime dtmFechaIngreso { get; set; }
        public float fSalarioHora { get; set; }
        public cls_Empleados() 
        {
            iCedula = 0;
            sNombreCompleto = string.Empty;
            dtmFechaNacimiento = DateTime.MinValue;
            sLateralidad = string.Empty;
            dtmFechaIngreso = DateTime.MinValue;
            fSalarioHora = 0;
        }
        #endregion
    }
}
