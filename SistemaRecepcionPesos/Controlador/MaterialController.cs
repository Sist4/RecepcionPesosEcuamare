using SistemaRecepcionPesos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcionPesos.Controlador
{
    class MaterialController
    {
        DBEcuamareEntities bd = new DBEcuamareEntities();
        public List<MATERIAL> ObtenerMateriales()
        {
            return bd.MATERIALES.ToList();
        }
        public void GuardarMaterial(MATERIAL material)
        {
            //validar que no sea el mismo material
            bd.MATERIALES.Add(material);
            bd.SaveChanges();
        }
        public bool ExisteMaterialEnTicket(int id)
        {
            bool existe = bd.TICKETS.Any(x =>x.MAT_ID == id);
            return existe;
        }
        public MATERIAL ObtenerMaterialPorId(int id)
        {
            MATERIAL material = (from mat in bd.MATERIALES
                                       where mat.MAT_ID == id
                                       select mat).Single();
            return material;
        }
        public bool ActualizarMaterial(MATERIAL material,string nombreEditado)
        {
            try
            {
                bd.MATERIALES.Attach(material);
                material.MAT_NOMBRE = nombreEditado;
                bd.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }

        }
        public bool EliminarMaterial(int id)
        {
            try
            {
                MATERIAL material = bd.MATERIALES.Single(x => x.MAT_ID == id);
                bd.MATERIALES.Remove(material);
                bd.SaveChanges();
                return true;
            }catch(Exception ex )
            {
                return false;
            }

        }
    }
}
