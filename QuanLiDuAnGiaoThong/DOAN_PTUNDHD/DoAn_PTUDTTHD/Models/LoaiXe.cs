//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_PTUDTTHD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiXe()
        {
            this.YeuCauDangKyXes = new HashSet<YeuCauDangKyXe>();
            this.Xes = new HashSet<Xe>();
        }
    
        public int ID { get; set; }
        public string NhanHieu { get; set; }
        public string MauXe { get; set; }
        public Nullable<int> NamSX { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YeuCauDangKyXe> YeuCauDangKyXes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Xe> Xes { get; set; }
    }
}