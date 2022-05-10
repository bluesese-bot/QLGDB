using System;

namespace QLGDB.Model
{
    public class KetQuaViewModel
    {
        public int Id { get; set; }
        public string IdGiai { get; set; }
        public string IdDoi1 { get; set; }
        public string IdDoi2 { get; set; }
        public DateTime? ThoiThiDau { get; set; }
        public int? SBTDOI1 { get; set; }
        public int? SBTDOI2 { get; set; }
    }
}
