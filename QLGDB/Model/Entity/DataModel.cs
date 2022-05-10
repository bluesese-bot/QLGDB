using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLGDB.Model
{
    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<CauThu> CauThus { get; set; }
        public virtual DbSet<DoiBong> DoiBongs { get; set; }
        public virtual DbSet<DoiBongCauThu> DoiBongCauThus { get; set; }
        public virtual DbSet<GiaiDau> GiaiDaus { get; set; }
        public virtual DbSet<KetQua> KetQuas { get; set; }
        public virtual DbSet<LichThiDau> LichThiDaus { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CauThu>()
                .HasMany(e => e.DoiBongCauThus)
                .WithOptional(e => e.CauThu)
                .HasForeignKey(e => e.IdCauThu);

            modelBuilder.Entity<DoiBong>()
                .HasMany(e => e.DoiBongCauThus)
                .WithOptional(e => e.DoiBong)
                .HasForeignKey(e => e.IdDoi);

            modelBuilder.Entity<DoiBong>()
                .HasMany(e => e.KetQuas)
                .WithOptional(e => e.DoiBong)
                .HasForeignKey(e => e.IdDoiWin);

            modelBuilder.Entity<DoiBong>()
                .HasMany(e => e.LichThiDaus)
                .WithOptional(e => e.DoiBong)
                .HasForeignKey(e => e.IdDoi1);

            modelBuilder.Entity<DoiBong>()
                .HasMany(e => e.LichThiDaus1)
                .WithOptional(e => e.DoiBong1)
                .HasForeignKey(e => e.IdDoi2);

            modelBuilder.Entity<GiaiDau>()
                .HasMany(e => e.LichThiDaus)
                .WithOptional(e => e.GiaiDau)
                .HasForeignKey(e => e.IdGiai);

            modelBuilder.Entity<LichThiDau>()
                .HasMany(e => e.KetQuas)
                .WithOptional(e => e.LichThiDau)
                .HasForeignKey(e => e.IdLichThiDau);
        }
    }
}
