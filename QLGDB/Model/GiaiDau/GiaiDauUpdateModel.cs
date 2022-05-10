using System;

namespace QLGDB.Model
{
    public class GiaiDauUpdateModel
    {
        public int Id { get; set; }
        public string TenGiaiDau { get; set; }
        public DateTime? ThoiGianBatDau { get; set; }
        public DateTime? ThoiGianKetThuc { get; set; }
    }
}
