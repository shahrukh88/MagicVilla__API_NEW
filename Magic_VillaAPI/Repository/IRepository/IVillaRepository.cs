using Magic_VillaAPI.Models;
using System.Linq.Expressions;

namespace Magic_VillaAPI.Repository.IRepository
{

    public interface IVillaRepository : IRepository<Villa>
    {


        Task<Villa> UpdateAsync(Villa entity);

    }
}
