//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcStok.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TBLMUSTERILER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLMUSTERILER()
        {
            this.TBLSATISLAR = new HashSet<TBLSATISLAR>();
        }
    
        public int MusteriId { get; set; }

        [Required(ErrorMessage ="Bu Alan� Bo� B�rakamazs�n�z...")]
        [StringLength(50, ErrorMessage ="En Fazla 50 Karakterlik �sim Girin")]
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSATISLAR> TBLSATISLAR { get; set; }
    }
}
