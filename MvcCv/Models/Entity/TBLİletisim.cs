//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCv.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLİletisim
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    }
}
