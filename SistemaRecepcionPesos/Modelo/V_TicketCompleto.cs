//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaRecepcionPesos.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_TicketCompleto
    {
        public int ID { get; set; }
        public string TICKET { get; set; }
        public string ESTADO { get; set; }
        public string PROVEEDOR { get; set; }
        public string CONDUCTOR { get; set; }
        public string VEHICULO { get; set; }
        public string N__GUIA { get; set; }
        public string FORMA_DE_ENTREGA { get; set; }
        public string MATERIAL { get; set; }
        public Nullable<int> C_MUESTRA { get; set; }
        public Nullable<System.DateTime> FECHA_ENTRADA { get; set; }
        public string USUARIO_ENTRADA { get; set; }
        public Nullable<float> PESO_ENTRADA { get; set; }
        public Nullable<System.DateTime> FECHA_IMPUREZAS { get; set; }
        public string USUARIO_IMPUREZAS { get; set; }
        public Nullable<float> PESO_IMPUREZAS { get; set; }
        public Nullable<System.DateTime> FECHA_SALIDA { get; set; }
        public string USUARIO_SALIDA { get; set; }
        public Nullable<float> PESO_SALIDA { get; set; }
        public Nullable<float> PESO_BRUTO { get; set; }
        public Nullable<float> PESO_NO_CONFORME { get; set; }
        public Nullable<float> PESO_NETO { get; set; }
    }
}