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
    
    public partial class TICKET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TICKET()
        {
            this.PESOes = new HashSet<PESO>();
        }
    
        public int TICK_ID { get; set; }
        public string PROV_ID { get; set; }
        public Nullable<int> MAT_ID { get; set; }
        public string TICK_NUMERO { get; set; }
        public string TICK_NOMBRECONDUCTOR { get; set; }
        public string TICK_PLACAVEHICULO { get; set; }
        public string TICK_GUIA { get; set; }
        public string TICK_FORMAENTREGA { get; set; }
        public string TICK_ESTADO { get; set; }
    
        public virtual MATERIAL MATERIAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PESO> PESOes { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
    }
}
