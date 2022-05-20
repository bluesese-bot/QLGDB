using System;

namespace QLGDB.Model
{
    public class LichThiDauUpdateModel
    {
        public int Id { get; set; }
        public int? IdGiai { get; set; }
        public int? IdDoi1 { get; set; }
        public int? IdDoi2 { get; set; }
        public DateTime? ThoiThiDau { get; set; }
        public int? SBTDOI1 { get; set; }
        public int? SBTDOI2 { get; set; }
        public int? TranDau { get; set; }
        public int? IdDoiWin { get; set; }
    }
}
