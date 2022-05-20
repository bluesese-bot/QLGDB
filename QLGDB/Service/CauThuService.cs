using AutoMapper;
using QLGDB.Model;
using System.Collections.Generic;
using System.Linq;

namespace QLGDB.Service
{
    /// <summary>
    /// CauThuService layer
    /// </summary>
    public class CauThuService
    {
        private readonly DBcontext _contextService = new DBcontext();
        public List<CauThuViewModel> Query(CauThuQueryModel payload)
        {
            IQueryable<CauThu> query = _contextService.CauThus;
            if (payload.HoTen != null)
            {
                query = query.Where(x => x.HoTen == payload.HoTen);
            }
            if (payload.GhiChu != null)
            {
                query = query.Where(x => x.GhiChu == payload.GhiChu);
            }
            if (payload.TenLop != null)
            {
                query = query.Where(x => x.TenLop == payload.TenLop);
            }
            if (payload.Msv != null)
            {
                query = query.Where(x => x.Msv == payload.Msv);
            }
            var list = query.ToList();
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<CauThu, CauThuViewModel>()
                );
            var mapper = new Mapper(config);
            var res = mapper.Map<List<CauThu>, List<CauThuViewModel>>(list);
            return res;
        }
        public CauThuViewModel Add(CauThuAddModel payload)
        {
            var cauthu = _contextService.CauThus.Where(x => x.HoTen == payload.HoTen && x.Msv == payload.Msv).FirstOrDefault();
            if (cauthu != null)
                return null;
            var entity = new CauThu
            {
                HoTen = payload.HoTen,
                Msv = payload.Msv,
                TenLop = payload.TenLop,
                GhiChu = payload.GhiChu,
            };
            _contextService.CauThus.Add(entity);
            _contextService.SaveChanges();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CauThu, CauThuViewModel>());
            var mapper = new Mapper(config);
            var res = mapper.Map<CauThu, CauThuViewModel>(entity);
            return res;
        }

        public bool Delete(int id)
        {
            var cauthu = _contextService.CauThus.Where(x => x.Id == id).FirstOrDefault();
            if (cauthu == null)
                return false;
            _contextService.CauThus.Remove(cauthu);
            _contextService.SaveChanges();
            return true;
        }

        public bool Edit(CauThuUpdateModel payload)
        {
            var cauthu = _contextService.CauThus.Find(payload.Id);
            if (cauthu == null)
                return false;
            cauthu.HoTen = payload.HoTen;
            cauthu.Msv = payload.Msv;
            cauthu.TenLop = payload.TenLop;
            cauthu.GhiChu = payload.GhiChu;
            _contextService.SaveChanges();
            return true;
        }
        public List<CauThuViewModel> GetListCauThuByDoiBongId(int? id)
        {
            var listDB = _contextService.DoiBongCauThus.Where(x => x.IdDoi == id).Select(x => x.IdCauThu).ToList();
            var list = _contextService.CauThus.Where(x => listDB.Contains(x.Id)).ToList();
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<CauThu, CauThuViewModel>()
                );
            var mapper = new Mapper(config);
            var res = mapper.Map<List<CauThu>, List<CauThuViewModel>>(list);
            return res;
        }
    }
}