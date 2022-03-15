using AspNetWebApiNombres.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetWebApiNombres
{
    public static class InitialData
    {
        public static void Seed(this NombreContext dbContext)
        {
            if (!dbContext.Nombres.Any())
            {
                dbContext.Nombres.Add(new Models.Nombre
                {
                    Id=1,
                    nombre="Rasputia"
                });
                dbContext.Nombres.Add(new Models.Nombre
                {
                    Id = 2,
                    nombre = "Rafaela"
                });
                dbContext.Nombres.Add(new Models.Nombre
                {
                    Id = 3,
                    nombre = "Armando"
                });

                dbContext.SaveChanges();
            }
        }
    }
}
