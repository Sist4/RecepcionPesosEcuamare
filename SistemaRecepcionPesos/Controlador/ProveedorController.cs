using SistemaRecepcionPesos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcionPesos.Controlador
{
    class ProveedorController
    {
        DBEcuamareEntities bd = new DBEcuamareEntities();
        public List<PROVEEDOR> ObtenerProveedores()
        {
            return bd.PROVEEDORES.ToList();
        }
        public void GuardarProveedor(PROVEEDOR proveedor)
        {
            bd.PROVEEDORES.Add(proveedor);
            bd.SaveChanges();
        }

        public PROVEEDOR ObtenerProveedorPorId(string id)
        {
            PROVEEDOR proveedor = (from prov in bd.PROVEEDORES
                                 where prov.PROV_ID.Equals(id)
                                 select prov).Single();
            return proveedor;
        }
        public bool ActualizarProveedor(PROVEEDOR proveedor, string nombre,string direccion,string telefono)
        {
            try
            {
                bd.PROVEEDORES.Attach(proveedor);
                proveedor.PROV_NOMBRE = nombre;
                proveedor.PROV_DIRECCION = direccion;
                proveedor.PROV_TELEFONO = telefono;
                bd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool ExisteProveedorEnTicket(string id)
        {
            bool existe = bd.TICKETS.Any(x => x.PROV_ID.Equals(id));
            return existe;
        }
        public bool EliminarProveedor(string id)
        {
            try
            {
                PROVEEDOR proveedor = bd.PROVEEDORES.Single(x => x.PROV_ID.Equals(id));
                bd.PROVEEDORES.Remove(proveedor);
                bd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
