//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLGDB.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DoiBong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoiBong()
        {
            this.DoiBongCauThus = new HashSet<DoiBongCauThu>();
            this.LichThiDaus = new HashSet<LichThiDau>();
            this.LichThiDaus1 = new HashSet<LichThiDau>();
        }
    
        public int Id { get; set; }
        public string TenDoi { get; set; }
        public string Tenkhoa { get; set; }
        public Nullable<int> IdGiaiDau { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoiBongCauThu> DoiBongCauThus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichThiDau> LichThiDaus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichThiDau> LichThiDaus1 { get; set; }
    }
}