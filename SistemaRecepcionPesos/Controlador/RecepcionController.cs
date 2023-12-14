using SistemaRecepcionPesos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcionPesos.Controlador
{
    class RecepcionController
    {
        DBEcuamareEntities bd = new DBEcuamareEntities();

        public PROVEEDOR ObtenerProveedor(string codigo)
        {
            PROVEEDOR proveedor = bd.PROVEEDORES.Find(codigo);
            return proveedor;
        }

        public TICKET ObtenerTicket(string numero, string estado)
        {
            TICKET ticket = (from tick in bd.TICKETS
                             where tick.TICK_NUMERO.Equals(numero)
                             && tick.TICK_ESTADO.Equals(estado)
                             select tick).Single();
            return ticket;
        }
        public List<String> ObtenerMateriales()
        {
            List<String> materiales = new List<string>();
            materiales = (from m in bd.MATERIALES
                          select m.MAT_NOMBRE).ToList();
            return materiales;
        }
        public string NumeroTicket()
        {
            string añoActual = DateTime.Now.Year.ToString();
            string ceros = string.Empty;

            //string ticketNumero = bd.TICKETS.Where(u=>u.TICK_NUMERO.Substring(0,4).Equals(añoActual)).Max(u => u.TICK_NUMERO.Substring(5,u.TICK_NUMERO.Length-5));
            int numMax = bd.TICKETS.Max(u=>u.TICK_ID);
            var ticket=bd.TICKETS.OrderByDescending(t=>t.TICK_ID).FirstOrDefault();
            string ticketNumero = "";
            if(ticket.TICK_NUMERO.Substring(0,4).Equals(añoActual))
            {
                ticketNumero = ticket.TICK_NUMERO.Substring(5, ticket.TICK_NUMERO.Length - 5);
            }
            int x = string.IsNullOrEmpty(ticketNumero) ? 1: Convert.ToInt32(ticketNumero);

            string numeroTicket = (x + 1).ToString();

            switch (numeroTicket.Length)
            {
                case 1:
                    ceros = "00";
                    break;
                case 2:
                    ceros = "0";
                    break;
                default:
                    break;
            }
            return añoActual + "-" + ceros + numeroTicket;
        }
        public int ObtenerCodigoMaterial(string material)
        {
            int numero = (from mat in bd.MATERIALES
                          where mat.MAT_NOMBRE.Equals(material)
                          select mat.MAT_ID).Single();

            return numero;
        }
        public string ObtenerNombreMaterial(int? codigo)
        {
            string nombre = (from mat in bd.MATERIALES
                             where mat.MAT_ID == codigo
                             select mat.MAT_NOMBRE).Single().ToString();

            return nombre;
        }
        public int ObtenerCodigoTicket(string ticket)
        {
            int numero = (from tick in bd.TICKETS
                          where tick.TICK_NUMERO.Equals(ticket)
                          select tick.TICK_ID).Single();

            return numero;
        }
        public int ObtenerUltimoCodigoTicket()
        {
            int numero = bd.TICKETS.OrderByDescending(p => p.TICK_ID).FirstOrDefault().TICK_ID;

            return numero;
        }
        public void GuardarTicket(TICKET ticket)
        {
            try
            {
                bd.TICKETS.Add(ticket);
                bd.SaveChanges();
            }catch(Exception ex)
            {

            }
            
        }
        public void GuardarPeso(PESO peso)
        {
             bd.PESOS.Add(peso);
             bd.SaveChanges();
        }
        public void ActualizarEstadoTicket(string numero, string estado)
        {
            TICKET ticket;
            string estadoActual = string.Empty;
            if (estado.Equals("SALIDA"))
            {
                estadoActual = "ENTRADA";
                ticket = ObtenerTicket(numero,estadoActual);
                bd.TICKETS.Attach(ticket);
                ticket.TICK_ESTADO = "SALIDA";
                bd.SaveChanges();
            }
            else
            {
                estadoActual = "SALIDA";
                ticket = ObtenerTicket(numero,estadoActual);
                bd.TICKETS.Attach(ticket);
                ticket.TICK_ESTADO = "FINALIZADO";
                bd.SaveChanges();
            }


            //TICKET ticket = ObtenerTicketEntrada(numero);
            //ticket.TICK_ESTADO = estado;
            //bd.SaveChanges();

        }
        public List<string> ObtenerNumeroTicketsImpurezas()
        {
            List<String> tickets = new List<string>();
            tickets = (from t in bd.TICKETS
                       where t.TICK_ESTADO.Equals("SALIDA")
                       select t.TICK_NUMERO).ToList();
            return tickets;
        }
        public List<string> ObtenerNumeroTicketsSalidas()
        {
            List<String> tickets = new List<string>();
            tickets = (from t in bd.TICKETS
                       where t.TICK_ESTADO.Equals("ENTRADA")
                       select t.TICK_NUMERO).ToList();
            return tickets;
        }
        public float ObtenerPesoImpurezas(int codigo)
        {
            float peso = (from p in bd.PESOS
                          where p.TICK_ID == codigo && p.PES_TIPO == 3
                          select p.PES_PESO.Value).Single();

            return peso;
        }
        public float ObtenerPesoEntrada(int codigo)
        {
            float peso = (from p in bd.PESOS
                          where p.TICK_ID == codigo && p.PES_TIPO == 1
                          select p.PES_PESO.Value).Single();

            return peso;
        }
        public float ObtenerPesoSalida(int codigo)
        {
            float peso = (from p in bd.PESOS
                          where p.TICK_ID == codigo && p.PES_TIPO == 2
                          select p.PES_PESO.Value).Single();

            return peso;
        }
        public int ObtenerMuestraImpurezas(int codigo)
        {
            int porcentaje = (from p in bd.PESOS
                              where p.TICK_ID == codigo && p.PES_TIPO == 3
                              select p.PES_PORCENTAJE.Value).Single();

            return porcentaje;
        }
        public float PesoBruto(float pesoEntrada, float pesoSalida)
        {
            return pesoEntrada - pesoSalida;
        }
        public float PesoNoConforme(float pesoImpurezas, int muestra)
        {
            float porcentaje = (pesoImpurezas * 100F) / muestra;
            return porcentaje;

        }
        public float PesoNeto(float pesoBruto, float pesoNoConforme)
        {
            return pesoBruto - pesoNoConforme;
        }
        public string ObtenerCOMPiso()
        {
            string com = (from conf in bd.CONFIGURACIONES
                          where conf.CON_ID == 1
                          select conf.CON_COMPISO).Single();
            return com;
        }
        public string ObtenerCOMCamionera()
        {
            string com = (from conf in bd.CONFIGURACIONES
                          where conf.CON_ID == 1
                          select conf.CON_COMCAMIONERA).Single();
            return com;
        }
        public string ObtenerSerialCamionera()
        {
            string serial = (from conf in bd.CONFIGURACIONES
                             where conf.CON_ID == 1
                             select conf.CON_SERIALCAMIONERA).Single();
            return serial;
        }
        public string ObtenerSerialPiso()
        {
            string serial = (from conf in bd.CONFIGURACIONES
                             where conf.CON_ID == 1
                             select conf.CON_SERIALPISO).Single();
            return serial;
        }
    }
}
