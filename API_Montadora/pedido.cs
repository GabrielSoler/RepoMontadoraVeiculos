//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_Montadora
{
    using System;
    using System.Collections.Generic;
    
    public partial class pedido
    {
        public byte id { get; set; }
        public short id_carro { get; set; }
        public System.DateTime databertura { get; set; }
        public System.DateTime dataentrega { get; set; }
    
        public virtual tbl_carros tbl_carros { get; set; }
    }
}
