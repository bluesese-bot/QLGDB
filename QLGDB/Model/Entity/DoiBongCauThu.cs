namespace QLGDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoiBongCauThu")]
    public partial class DoiBongCauThu
    {
        public int Id { get; set; }

        public int? IdDoi { get; set; }

        public int? IdCauThu { get; set; }

        public virtual CauThu CauThu { get; set; }

        public virtual DoiBong DoiBong { get; set; }
    }
}
