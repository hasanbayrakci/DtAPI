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
                unique_id = dtApi.unique_id,
                ilan_data = dtApi.ilan_data,
                durum = dtApi.durum,
            };

            _context.DtApis.Add(_ilan);
            _context.SaveChanges();

        }
    }
}
