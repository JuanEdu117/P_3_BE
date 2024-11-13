using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Clientes_DAL
    {
        #region VARIABLE PÚBLICA
        public static List<cls_Clientes> _lstClientesRecibe = new List<cls_Clientes>();
        #endregion

        #region VARIABLE PRIVADA   
        private static List<cls_Clientes> _lstClientes = new List<cls_Clientes>
        { new cls_Clientes {    Identificacion = 123456789, 
                                NombreCompleto = "Bill Skarsgard", 
                                Provincia = "Heredia",
                                Canton = "Heredia", 
                                Distrito = "Heredia", 
                                DireccionExacta = "Calle Flores, Casa #105", 
                                MantenimientoInvierno = 15, 
                                MantenimientoVerano = 15
                            }
        };
        #endregion
        
        #region MÉTODOS EMPLEADOS

        public List<cls_Clientes> GetAll()
        {
            return _lstClientes;
            //_lstClientesRecibe = _lstClientes;
        }
        public cls_Clientes GetById(int id)
        {
            return _lstClientes.FirstOrDefault(v => v.Identificacion == id);
        }
        public List<cls_Clientes> ConsultaFiltrada(cls_Clientes P_Entidad)
        {
            List<cls_Clientes> lstResultado = new List<cls_Clientes>();
            try
            {
                if (!string.IsNullOrEmpty(P_Entidad.Identificacion.ToString()))
                {
                    lstResultado =_lstClientes.Where(doc => doc.Identificacion == P_Entidad.Identificacion).OrderBy(orden => orden.NombreCompleto).ToList();
                }
                else if (!string.IsNullOrEmpty(P_Entidad.NombreCompleto))
                {
                    lstResultado = _lstClientes.Where(doc => doc.NombreCompleto.Equals(P_Entidad.NombreCompleto)).OrderBy(orden => orden.NombreCompleto).ToList();
                }
                else
                {
                    lstResultado = _lstClientes.OrderBy(orden => orden.NombreCompleto).ToList(); // Devuelve todo ordenado por nombre
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstResultado;
        }
        public void Add(cls_Clientes P_Entidad)
        {
            //P_Entidad.iCedula = _lstEmpleado.Max(v => v.iCedula) + 1;
            _lstClientes.Add(P_Entidad);
        }
        public void Update(cls_Clientes P_Entidad)
        {
            var existingClientes = GetById(P_Entidad.Identificacion);
            if (existingClientes != null)
            {
                existingClientes.NombreCompleto = P_Entidad.NombreCompleto;
                existingClientes.Provincia = P_Entidad.Provincia;
                existingClientes.Canton = P_Entidad.Canton;
                existingClientes.Distrito = P_Entidad.Distrito;
                existingClientes.DireccionExacta = P_Entidad.DireccionExacta;
                existingClientes.MantenimientoInvierno = P_Entidad.MantenimientoInvierno;
                existingClientes.MantenimientoVerano = P_Entidad.MantenimientoVerano;
            }
        }
        public void Delete(int id)
        {
            var clientes = GetById(id);
            if (clientes != null)
            {
                _lstClientes.Remove(clientes);
            }
        }
        #endregion
    }
}
