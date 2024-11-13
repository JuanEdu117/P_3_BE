using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class cls_product
    {
        #region VARIABLES PUBLICAS
        public int iId { get; set; }
        public string sNombre { get; set; }
        public cls_product() 
        {
            iId = 0;
            sNombre = string.Empty;
        }
        #endregion
    }
}
