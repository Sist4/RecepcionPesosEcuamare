using SistemaRecepcionPesos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcionPesos.Controlador
{
    class ConfiguracionController
    {
        DBEcuamareEntities bd = new DBEcuamareEntities();

        public string ObtenerSerialCamionera()
        {
            string serial = (from conf in bd.CONFIGURACIONES
                             where conf.CON_ID==1
                             select conf.CON_SERIALCAMIONERA).Single();
            return serial;
        }
        public string ObtenerCOMCamionera()
        {
            string com = (from conf in bd.CONFIGURACIONES
                             where conf.CON_ID == 1
                             select conf.CON_COMCAMIONERA).Single();
            return com;
        }
        public string ObtenerSerialPiso()
        {
            string serial = (from conf in bd.CONFIGURACIONES
                             where conf.CON_ID == 1
                             select conf.CON_SERIALPISO).Single();
            return serial;
        }
        public string ObtenerCOMPiso()
        {
            string com = (from conf in bd.CONFIGURACIONES
                          where conf.CON_ID == 1
                          select conf.CON_COMPISO).Single();
            return com;
        }
        public void ActualizarCamionera(string serial,string com)
        {
            CONFIGURACION conf = bd.CONFIGURACIONES.Where(c => c.CON_ID == 1).FirstOrDefault();
            bd.CONFIGURACIONES.Attach(conf);
            conf.CON_SERIALCAMIONERA = serial;
            conf.CON_COMCAMIONERA = com;
            bd.SaveChanges();
        }
        public void ActualizarPiso(string serial, string com)
        {
            CONFIGURACION conf = bd.CONFIGURACIONES.Where(c => c.CON_ID == 1).FirstOrDefault();
            bd.CONFIGURACIONES.Attach(conf);
            conf.CON_SERIALPISO = serial;
            conf.CON_COMPISO = com;
            bd.SaveChanges();
        }

    }
}
