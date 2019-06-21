using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeflyAPI.Models;
using Microsoft.EntityFrameworkCore;
using WeflyAPI.Infrastructure;

namespace WeflyAPI.Repository
{
    public class CityRepository<T> : ICityReposioty<T> where T : BaseEntity
    {
        private clsWeflyDbContext dbContext;
        private DbSet<T> entities;

        public CityRepository(clsWeflyDbContext _db)
        {
            this.dbContext = _db;
            entities = dbContext.Set<T>();
        }

        public T GetCity(string cityCode)
        {
            if (!string.IsNullOrEmpty(cityCode))
                return entities.Where(city => city.Id == cityCode).FirstOrDefault();
            else
                return default(T);
        }

        public IEnumerable<T> GetCities(string cityCode)
        {
            if (string.IsNullOrEmpty(cityCode))            
                return entities.ToList();
            else
                return entities.Where(city => city.Id != cityCode).ToList();
        }

    }
}
