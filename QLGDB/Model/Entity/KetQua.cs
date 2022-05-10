namespace QLGDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KetQua")]
    public partial class KetQua
    {
        public int Id { get; set; }

        public int? IdLichThiDau { get; set; }

        public int? IdDoiWin { get; set; }

        public virtual DoiBong DoiBong { get; set; }

        public virtual LichThiDau LichThiDau { get; set; }
    }
}
