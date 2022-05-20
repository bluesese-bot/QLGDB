using AutoMapper;
using QLGDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLGDB.Service
{
    /// <summary>
    /// DoiBongService layer
    /// </summary>
    public class DoiBongService
    {
        private readonly DBcontext _contextService = new DBcontext();
        public List<DoiBongViewModel> Query(DoiBongQueryModel payload)
        {
            IQueryable<DoiBong> query = _contextService.DoiBongs;
            if (payload.TenDoi != null)
            {
                query = query.Where(x => x.TenDoi == payload.TenDoi);
            }
            if (payload.Tenkhoa != null)
            {
                query = query.Where(x => x.Tenkhoa == payload.Tenkhoa);
            }
            if (payload.IdGiaiDau != null)
            {
                query = query.Where(x => x.IdGiaiDau == payload.IdGiaiDau);
            }
            var list = query.ToList();
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<DoiBong, DoiBongViewModel> ()
                );
            var mapper = new Mapper(config);
            var res = mapper.Map<List<DoiBong>, List<DoiBongViewModel>>(list);
            res.ForEach(x => x.IdGiaiDau = _contextService.GiaiDaus.Where(z => z.Id.ToString() == x.IdGiaiDau).Select(y => y.TenGiaiDau).FirstOrDefault());
            return res;
        }
        public bool Add(DoiBongAddModel payload)
        {
            var DoiBong = _contextService.DoiBongs.Where(x => x.TenDoi == payload.TenDoi).FirstOrDefault();
            if (DoiBong != null)
                return false;
            var entity = new DoiBong
            {
                TenDoi = payload.TenDoi,
                Tenkhoa = payload.Tenkhoa,
                IdGiaiDau = payload.IdGiaiDau,
            };
            _contextService.DoiBongs.Add(entity);
            _contextService.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var DoiBong = _contextService.DoiBongs.Where(x => x.Id == id).FirstOrDefault();
            if (DoiBong == null)
                return false;
            _contextService.DoiBongs.Remove(DoiBong);
            _contextService.SaveChanges();
            return true;
        }

        public bool Edit(DoiBongUpdateModel payload)
        {
            var DoiBong = _contextService.DoiBongs.Find(payload.Id);
            if (DoiBong == null)
                return false;
            DoiBong.TenDoi = payload.TenDoi;
            DoiBong.Tenkhoa = payload.Tenkhoa;
            DoiBong.IdGiaiDau = payload.IdGiaiDau;
            _contextService.SaveChanges();
            return true;
        }
        public DoiBongViewModel getDoiBong(int IdGiai,int Trandau)
        {
            var DoiBong = _contextService.DoiBongs.Where(x => x.Id == (_contextService.LichThiDaus.Where(y => y.IdGiai == IdGiai && y.TranDau == Trandau).Select(y => y.IdDoiWin).FirstOrDefault())).FirstOrDefault();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DoiBong, DoiBongViewModel>());
            var mapper = new Mapper(config);
            var res = mapper.Map<DoiBong, DoiBongViewModel>(DoiBong);
            return res;
        }
    }
}