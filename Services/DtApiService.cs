using DtAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DtAPI.Services
{
    public class DtApiService
    {
        private ApiDbContext _context;
        public DtApiService(ApiDbContext context)
        {
            _context = context;
        }

        public void AddIlan(DtApi dtApi)
        {
            var _ilan = new DtApi()
            {
                user_id = dtApi.user_id,
                kurum_adi = dtApi.kurum_adi,
                ilan_adi = dtApi.ilan_adi,
                unique_id = Guid.NewGuid().ToString(),
                ilan_data = dtApi.ilan_data,
                durum = dtApi.durum,
            };

            _context.DtApis.Add(_ilan);
            _context.SaveChanges();

        }

        public List<DtApi> GetAllIlan() => _context.DtApis.ToList();
        public DtApi GetIlanById(int ilanId) => _context.DtApis.FirstOrDefault(n => n.Id == ilanId);

        public DtApi UpdateIlanById(int ilanId, DtApi dtApi)
        {
            var _ilan = _context.DtApis.FirstOrDefault(n => n.Id == ilanId);

            if(_ilan != null)
            {
                _ilan.user_id = dtApi.user_id;
                _ilan.kurum_adi = dtApi.kurum_adi;
                _ilan.ilan_adi = dtApi.ilan_adi;
                _ilan.ilan_data = dtApi.ilan_data;
                _ilan.durum = dtApi.durum;
                _context.SaveChanges();
            }
            return _ilan;
        }

        public void DeleteIlanById(int ilanId)
        {
            var _ilan = _context.DtApis.FirstOrDefault(n => n.Id == ilanId);

            if (_ilan != null)
            {
                _context.DtApis.Remove(_ilan);
                _context.SaveChanges();
            }
        }


    }
}
