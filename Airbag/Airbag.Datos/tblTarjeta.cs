//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airbag.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTarjeta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTarjeta()
        {
            this.tblCompra = new HashSet<tblCompra>();
        }
    
        public int iIdTarjeta { get; set; }
        public Nullable<int> iIdUsuario { get; set; }
        public int iMesVencimiento { get; set; }
        public int iAnioVencimiento { get; set; }
        public string cNumeroTarjeta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompra> tblCompra { get; set; }
        public virtual tblUsuario tblUsuario { get; set; }
    }
}
