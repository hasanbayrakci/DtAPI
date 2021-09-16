using DtAPI.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DtAPI.Seeder
{
    public class ApiDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApiDbContext>();

                if(!context.DtApis.Any())
                {
                    context.DtApis.AddRange(new DtApi()
                    {
                        user_id = 1,
                        kurum_adi = "Deneme Kurum",
                        ilan_adi = "Deneme İlan",
                        unique_id = Guid.NewGuid().ToString(),
                        ilan_data = "sfwerwerwer",
                        durum = 0
                    });

                    context.SaveChanges();
                }

            }
        }
    }
}
