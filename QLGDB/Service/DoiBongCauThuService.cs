using AutoMapper;
using QLGDB.Model;
using System.Collections.Generic;
using System.Linq;

namespace QLGDB.Service
{
    /// <summary>
    /// DoiBongCauThuService layer
    /// </summary>
    public class DoiBongCauThuService
    {
        private readonly DataModel _contextService = new DataModel();
        public List<DoiBongCauThuViewModel> Query(DoiBongCauThuQueryModel payload)
        {
            IQueryable<DoiBongCauThu> query = _contextService.DoiBongCauThus;
            if (payload.IdDoi != null)
            {
                query = query.Where(x => x.IdDoi == payload.IdDoi);
            }
            if (payload.IdCauThu != null)
            {
                query = query.Where(x => x.IdCauThu == payload.IdCauThu);
            }
            var list = query.ToList();
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<DoiBongCauThu, DoiBongCauThuViewModel> ()
                );
            var mapper = new Mapper(config);
            var res = mapper.Map<List<DoiBongCauThu>, List<DoiBongCauThuViewModel>>(list);
            return res;
        }
        public bool Add(DoiBongCauThuAddModel payload)
        {
            var DoiBongCauThu = _contextService.DoiBongCauThus.Where(x => x.IdDoi == payload.IdDoi && x.IdCauThu == payload.IdCauThu).FirstOrDefault();
            if (DoiBongCauThu != null)
                return false;
            var entity = new DoiBongCauThu
            {
                IdDoi = payload.IdDoi,
                IdCauThu = payload.IdCauThu,
            };
            _contextService.DoiBongCauThus.Add(entity);
            _contextService.SaveChanges();
            return true;
        }

        public bool Delete(int idDoiBong, int IdCauThu)
        {
            var DoiBongCauThu = _contextService.DoiBongCauThus.Where(x => x.IdDoi == idDoiBong && x.IdCauThu == IdCauThu).FirstOrDefault();
            if (DoiBongCauThu == null)
                return false;
            _contextService.DoiBongCauThus.Remove(DoiBongCauThu);
            _contextService.SaveChanges();
            return true;
        }
        public bool Delete(int idDoiBong)
        {
            var DoiBongCauThu = _contextService.DoiBongCauThus.Where(x => x.IdDoi == idDoiBong).ToList();
            _contextService.DoiBongCauThus.RemoveRange(DoiBongCauThu);
            _contextService.SaveChanges();
            return true;
        }
        public bool Edit(DoiBongCauThuUpdateModel payload)
        {
            var DoiBongCauThu = _contextService.DoiBongCauThus.Find(payload.Id);
            if (DoiBongCauThu == null)
                return false;
            DoiBongCauThu.IdDoi = payload.IdDoi;
            DoiBongCauThu.IdCauThu = payload.IdCauThu;
            _contextService.SaveChanges();
            return true;
        }
    }
}