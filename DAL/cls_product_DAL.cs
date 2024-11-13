using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_product_DAL
    {
        #region VARIABLE PRIVADA   
        private static List<cls_product> _lstProduct = new List<cls_product>
    {
        new cls_product { iId = 1, sNombre = "Value 1" },
        new cls_product { iId = 2, sNombre = "Value 2" }
    };
        #endregion

        #region MÉTODOS

        #region PRODUCT
        public List<cls_product> GetAll()
        {
            return _lstProduct;
        }
        public cls_product GetById(int id)
        {
            return _lstProduct.FirstOrDefault(v => v.iId == id);
        }
        public List<cls_product> ConsultaFiltrada(cls_product P_Entidad)
        {
            List<cls_product> lstResultado = new List<cls_product>();
            try
            {
                if (!string.IsNullOrEmpty(P_Entidad.iId.ToString()))
                {
                    lstResultado = _lstProduct.Where(doc => doc.iId == P_Entidad.iId).OrderBy(orden => orden.sNombre).ToList();
                }
                else if (!string.IsNullOrEmpty(P_Entidad.sNombre))
                {
                    lstResultado = _lstProduct.Where(doc => doc.sNombre.Equals(P_Entidad.sNombre)).OrderBy(orden => orden.sNombre).ToList();
                }
                else
                {
                    lstResultado = _lstProduct.OrderBy(orden => orden.sNombre).ToList(); // Devuelve todo ordenado por nombre
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return lstResultado;
        }
        public void Add(cls_product obj_Product)
        {
            obj_Product.iId = _lstProduct.Max(v => v.iId) + 1;
            _lstProduct.Add(obj_Product);
        }
        public void Update(cls_product Obj_Product)
        {
            var existingProduct = GetById(Obj_Product.iId);
            if (existingProduct != null)
            {
                existingProduct.sNombre = Obj_Product.sNombre;
            }
        }
        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _lstProduct.Remove(product);
            }
        }
        #endregion

        #endregion
    }
}
