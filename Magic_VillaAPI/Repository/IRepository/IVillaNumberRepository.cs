using Magic_VillaAPI.Models;
using System.Linq.Expressions;

namespace Magic_VillaAPI.Repository.IRepository
{

    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {


        Task<VillaNumber> UpdateAsync(VillaNumber entity);

    }
}
