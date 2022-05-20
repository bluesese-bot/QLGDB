using AutoMapper;
using QLGDB.Model;
using System.Collections.Generic;
using System.Linq;

namespace QLGDB.Service
{
    /// <summary>
    /// GiaiDauService layer
    /// </summary>
    public class GiaiDauService
    {
        private readonly DBcontext _contextService = new DBcontext();
        public List<GiaiDauViewModel> Query(GiaiDauQueryModel payload)
        {
            IQueryable<GiaiDau> query = _contextService.GiaiDaus;
            if (payload.TenGiaiDau != null)
            {
                query = query.Where(x => x.TenGiaiDau == payload.TenGiaiDau);
            }
            if (payload.ThoiGianBatDau != null)
            {
                query = query.Where(x => x.ThoiGianBatDau == payload.ThoiGianBatDau);
            }
            if (payload.ThoiGianKetThuc != null)
            {
                query = query.Where(x => x.ThoiGianKetThuc == payload.ThoiGianKetThuc);
            }
            var list = query.ToList();
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<GiaiDau, GiaiDauViewModel> ()
                );
            var mapper = new Mapper(config);
            var res = mapper.Map<List<GiaiDau>, List<GiaiDauViewModel>>(list);
            return res;
        }
        public bool Add(GiaiDauAddModel payload)
        {
            var GiaiDau = _contextService.GiaiDaus.Where(x => x.TenGiaiDau == payload.TenGiaiDau).FirstOrDefault();
            if (GiaiDau != null)
                return false;
            var entity = new GiaiDau
            {
                TenGiaiDau = payload.TenGiaiDau,
                ThoiGianBatDau = payload.ThoiGianBatDau,
                ThoiGianKetThuc = payload.ThoiGianKetThuc,
            };
            _contextService.GiaiDaus.Add(entity);
            _contextService.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var GiaiDau = _contextService.GiaiDaus.Where(x => x.Id == id).FirstOrDefault();
            if (GiaiDau == null)
                return false;
            _contextService.GiaiDaus.Remove(GiaiDau);
            _contextService.SaveChanges();
            return true;
        }

        public bool Edit(GiaiDauUpdateModel payload)
        {
            var GiaiDau = _contextService.GiaiDaus.Find(payload.Id);
            if (GiaiDau == null)
                return false;
            GiaiDau.TenGiaiDau = payload.TenGiaiDau;
            GiaiDau.ThoiGianBatDau = payload.ThoiGianBatDau;
            GiaiDau.ThoiGianKetThuc = payload.ThoiGianKetThuc;
            _contextService.SaveChanges();
            return true;
        }
    }
}