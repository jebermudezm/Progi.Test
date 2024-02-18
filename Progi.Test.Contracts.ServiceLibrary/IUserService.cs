
using Progi.Test.Library.Model;

namespace Progi.Test.Contracts.ServiceLibrary
{
    public  interface IUserService
    {
        Task<IQueryable<User>> Get();
        Task<User> GetById(int id);
        Task<bool> Create(User user);
        Task<bool> Update(User user);
        Task<bool> Delete(int id);

    }
}
