using System.Collections.Generic;
using WeflyAPI.Models;

namespace WeflyAPI.Repository
{
    public interface ICityReposioty<T> where T : BaseEntity
    {
        T GetCity(string cityCode=null);

        IEnumerable<T> GetCities(string cityCode);
    }
}
