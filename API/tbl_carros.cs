//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_carros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_carros()
        {
            this.pedido = new HashSet<pedido>();
        }
    
        public short id { get; set; }
        public byte serie { get; set; }
        public byte trim { get; set; }
        public byte motor { get; set; }
        public byte cambio { get; set; }
        public double preco { get; set; }
        public int unidadesestoque { get; set; }
        public string Cor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pedido> pedido { get; set; }
        public virtual tbl_cambio tbl_cambio { get; set; }
        public virtual tbl_motor tbl_motor { get; set; }
        public virtual tbl_series tbl_series { get; set; }
        public virtual tbl_trim tbl_trim { get; set; }
    }
}
