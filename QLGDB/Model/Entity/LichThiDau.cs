namespace QLGDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichThiDau")]
    public partial class LichThiDau
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LichThiDau()
        {
            KetQuas = new HashSet<KetQua>();
        }

        public int Id { get; set; }

        public int? IdGiai { get; set; }

        public int? IdDoi1 { get; set; }

        public int? IdDoi2 { get; set; }

        public DateTime? ThoiThiDau { get; set; }

        public int? SBTDOI1 { get; set; }

        public int? SBTDOI2 { get; set; }

        public virtual DoiBong DoiBong { get; set; }

        public virtual DoiBong DoiBong1 { get; set; }

        public virtual GiaiDau GiaiDau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KetQua> KetQuas { get; set; }
    }
}
