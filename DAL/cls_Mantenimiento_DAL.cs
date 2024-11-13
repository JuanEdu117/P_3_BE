using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Mantenimiento_DAL
    {
        #region VARIABLE PÚBLICA
        public static List<cls_Clientes> _lstClientesRecibe;
        #endregion

        #region VARIABLE PRIVADA   
        private static List<cls_Mantenimiento> _lstMantenimiento = new List<cls_Mantenimiento>
        { new cls_Mantenimiento {   IdMantenimiento = 1,
                                    IdCliente = 1,      //_lstClientesRecibe.FirstOrDefault().Identificacion, // Referencia a la Identificacion de _lstClientes //IdCliente = 1, 
                                    FechaEjecutado = DateTime.Parse("10/10/2024"),
                                    FechaAgendado = DateTime.Parse("12/10/2024"), 
                                    MetrosPropiedad = 100, 
                                    MetrosCercaViva = 100, 
                                    DiasSinChapia = "4",
                                    FechaOtraChapia = "03/11/2024", 
                                    TipoZacate = "San Agustín", 
                                    AplicacionProducto = "Sí", 
                                    ProductoAplicado = "Random", 
                                    CostoChapia = 3000, 
                                    CostoAplicacionProducto = 9000, 
                                    EstadoMantenimiento = "En Proceso"
                                }
        };
        #endregion

        #region MÉTODOS EMPLEADOS

        public List<cls_Mantenimiento> GetAll()
        {
            return _lstMantenimiento;
        }
        public cls_Mantenimiento GetById(int id)
        {
            return _lstMantenimiento.FirstOrDefault(v => v.IdMantenimiento == id);
        }
        public List<cls_Mantenimiento> ConsultaFiltrada(cls_Mantenimiento P_Entidad)
        {
            List<cls_Mantenimiento> lstResultado = new List<cls_Mantenimiento>();
            try
            {
                if (!string.IsNullOrEmpty(P_Entidad.IdMantenimiento.ToString()))
                {
                    lstResultado = _lstMantenimiento.Where(doc => doc.IdMantenimiento == P_Entidad.IdMantenimiento).OrderBy(orden => orden.TipoZacate).ToList();
                }
                else if (!string.IsNullOrEmpty(P_Entidad.TipoZacate))
                {
                    lstResultado = _lstMantenimiento.Where(doc => doc.TipoZacate.Equals(P_Entidad.TipoZacate)).OrderBy(orden => orden.TipoZacate).ToList();
                }
                else
                {
                    lstResultado = _lstMantenimiento.OrderBy(orden => orden.TipoZacate).ToList(); // Devuelve todo ordenado por nombre
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstResultado;
        }
        public void Add(cls_Mantenimiento P_Entidad)
        {
            //P_Entidad.iCedula = _lstEmpleado.Max(v => v.iCedula) + 1;
            _lstMantenimiento.Add(P_Entidad);
        }
        public void Update(cls_Mantenimiento P_Entidad)
        {
            var existingMantenimiento = GetById(P_Entidad.IdMantenimiento);
            if (existingMantenimiento != null)
            {
                existingMantenimiento.FechaEjecutado = P_Entidad.FechaEjecutado;
                existingMantenimiento.FechaAgendado = P_Entidad.FechaAgendado;
                existingMantenimiento.MetrosPropiedad = P_Entidad.MetrosPropiedad;
                existingMantenimiento.MetrosCercaViva = P_Entidad.MetrosCercaViva;
                existingMantenimiento.DiasSinChapia = P_Entidad.DiasSinChapia;
                existingMantenimiento.FechaOtraChapia = P_Entidad.FechaOtraChapia;
                existingMantenimiento.TipoZacate = P_Entidad.TipoZacate; 
                existingMantenimiento.AplicacionProducto = P_Entidad.AplicacionProducto;
                existingMantenimiento.ProductoAplicado = P_Entidad.ProductoAplicado;
                existingMantenimiento.CostoChapia = P_Entidad.CostoChapia;
                existingMantenimiento.CostoAplicacionProducto = P_Entidad.CostoAplicacionProducto;
                existingMantenimiento.EstadoMantenimiento = P_Entidad.EstadoMantenimiento;               
            }
        }
        public void Delete(int id)
        {
            var mantenimiento = GetById(id);
            if (mantenimiento != null)
            {
                _lstMantenimiento.Remove(mantenimiento);
            }
        }
        #endregion
    }
}
