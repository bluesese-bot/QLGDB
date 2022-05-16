using AutoMapper;
using QLGDB.Model;
using System.Collections.Generic;
using System.Linq;

namespace QLGDB.Service
{
    /// <summary>
    /// LichThiDauService layer
    /// </summary>
    public class LichThiDauService
    {
        private readonly DataModel _contextService = new DataModel();
        public List<LichThiDauViewModel> Query(LichThiDauQueryModel payload)
        {
            IQueryable<LichThiDau> query = _contextService.LichThiDaus;
            if (payload.IdGiai != null)
            {
                query = query.Where(x => x.IdGiai == payload.IdGiai);
            }
            if (payload.IdDoi != null)
            {
                query = query.Where(x => x.IdDoi1 == payload.IdDoi && x.IdDoi2 == payload.IdDoi);
            }
            if (payload.SBTDOI != null)
            {
                query = query.Where(x => x.SBTDOI1 == payload.SBTDOI && x.SBTDOI2 == payload.SBTDOI);
            }
            if (payload.ThoiThiDau != null)
            {
                query = query.Where(x => x.ThoiThiDau == payload.ThoiThiDau);
            }
            var list = query.ToList();
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<LichThiDau, LichThiDauViewModel> ()
                );
            var mapper = new Mapper(config);
            var res = mapper.Map<List<LichThiDau>, List<LichThiDauViewModel>>(list);
            res.ForEach(x => x.IdGiai = _contextService.GiaiDaus.Where(z => z.Id.ToString() == x.IdGiai).Select(y => y.TenGiaiDau).FirstOrDefault());
            res.ForEach(x => x.IdDoi1 = _contextService.DoiBongs.Where(z => z.Id.ToString() == x.IdDoi1).Select(y => y.TenDoi).FirstOrDefault());
            res.ForEach(x => x.IdDoi2 = _contextService.DoiBongs.Where(z => z.Id.ToString() == x.IdDoi2).Select(y => y.TenDoi).FirstOrDefault());
            return res;
        }
        public List<KetQuaViewModel> GetList(LichThiDauQueryModel payload)
        {
            IQueryable<LichThiDau> query = _contextService.LichThiDaus;
            if (payload.IdGiai != null)
            {
                query = query.Where(x => x.IdGiai == payload.IdGiai);
            }
            if (payload.IdDoi != null)
            {
                query = query.Where(x => x.IdDoi1 == payload.IdDoi && x.IdDoi2 == payload.IdDoi);
            }
            if (payload.SBTDOI != null)
            {
                query = query.Where(x => x.SBTDOI1 == payload.SBTDOI && x.SBTDOI2 == payload.SBTDOI);
            }
            else
            {
                query = query.Where(x => x.SBTDOI1 != -1 && x.SBTDOI2 != -1);
            }
            if (payload.ThoiThiDau != null)
            {
                query = query.Where(x => x.ThoiThiDau == payload.ThoiThiDau);
            }
            var list = query.ToList();
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<LichThiDau, KetQuaViewModel>()
                );
            var mapper = new Mapper(config);
            var res = mapper.Map<List<LichThiDau>, List<KetQuaViewModel>>(list);
            res.ForEach(x => x.IdGiai = _contextService.GiaiDaus.Where(z => z.Id.ToString() == x.IdGiai).Select(y => y.TenGiaiDau).FirstOrDefault());
            res.ForEach(x => x.IdDoi1 = _contextService.DoiBongs.Where(z => z.Id.ToString() == x.IdDoi1).Select(y => y.TenDoi).FirstOrDefault());
            res.ForEach(x => x.IdDoi2 = _contextService.DoiBongs.Where(z => z.Id.ToString() == x.IdDoi2).Select(y => y.TenDoi).FirstOrDefault());
            return res;
        }
        public bool Add(LichThiDauAddModel payload)
        {
            var LichThiDau = _contextService.LichThiDaus.Where(x => x.IdGiai == payload.IdGiai && x.IdDoi1 == payload.IdDoi1 && x.IdDoi2 == payload.IdDoi2 && x.IdDoi1 == payload.IdDoi2 && x.IdDoi2 == payload.IdDoi1).FirstOrDefault();
            if (LichThiDau != null)
                return false;
            var entity = new LichThiDau
            {
                IdGiai = payload.IdGiai,
                IdDoi1 = payload.IdDoi1,
                IdDoi2 = payload.IdDoi2,
                ThoiThiDau = payload.ThoiThiDau,
                SBTDOI1 = payload.SBTDOI1,
                SBTDOI2 = payload.SBTDOI2
            };
            _contextService.LichThiDaus.Add(entity);
            _contextService.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var LichThiDau = _contextService.LichThiDaus.Where(x => x.Id == id).FirstOrDefault();
            if (LichThiDau == null)
                return false;
            _contextService.LichThiDaus.Remove(LichThiDau);
            _contextService.SaveChanges();
            return true;
        }
        public bool DeletebyIDdoi(int iddoi)
        {
            var LichThiDau = _contextService.LichThiDaus.Where(x => x.IdDoi2 == iddoi || x.IdDoi1 == iddoi).ToList();
            _contextService.LichThiDaus.RemoveRange(LichThiDau);
            _contextService.SaveChanges();
            return true;
        }

        public bool Edit(LichThiDauUpdateModel payload)
        {
            var LichThiDau = _contextService.LichThiDaus.Find(payload.Id);
            if (LichThiDau == null)
                return false;
            LichThiDau.IdGiai = payload.IdGiai;
            LichThiDau.IdDoi1 = payload.IdDoi1;
            LichThiDau.IdDoi2 = payload.IdDoi2;
            LichThiDau.ThoiThiDau = payload.ThoiThiDau;
            LichThiDau.SBTDOI1 = payload.SBTDOI1;
            LichThiDau.SBTDOI2 = payload.SBTDOI2;
            _contextService.SaveChanges();
            return true;
        }
        public bool EditTySo(LichThiDauUpdateModel payload)
        {
            var LichThiDau = _contextService.LichThiDaus.Find(payload.Id);
            if (LichThiDau == null)
                return false;
            LichThiDau.SBTDOI1 = payload.SBTDOI1;
            LichThiDau.SBTDOI2 = payload.SBTDOI2;
            _contextService.SaveChanges();
            return true;
        }
    }
}